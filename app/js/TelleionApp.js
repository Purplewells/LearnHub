/*eslint eqeqeq: ["error", "smart"]*/
(function () {

    $app.ifThisThenThat((app, context) =>
        app.if(context
            .page('products')
            .list()
            .barcode()
            .field('Barcode')
            .row('Barcode', context.barcode())
        )
            .then(() => app.rowFilter('Barcode', context.barcode()))
            .then(() => app.action('Edit'))
            .then(() => app.focus('Barcode'))
    );

    $app.ifThisThenThat((app, context) =>
        app.if(context
            .page('products')
            .list()
            .barcode()
            .field('Barcode')
        )
            .then(() => app.notify('There is no product with the barcode: ' + context.barcode()))
    );

    $app.rules.PurchaseOrder = {
          Calculate: function (dataView, args) {
            $app.execute({ from: 'PurchaseOrderDetail' }).then(function (result) {

                var freight = dataView.data().Freight;
                if (freight == null)
                    freight = 0;

                var total = 0;
                result.PurchaseOrderDetail.forEach(function (detail) {
                    total += detail.ExtendedCost;
                });
                total += freight;
                $app.input.execute({ TotalAmount: total });
            });
            return false;   
        },

        after: {
            New: function (dataView, args) {
                $app.input.execute({ OrderDate: new Date() });
            }
        }
    }

    $app.rules.PurchaseOrderDetail = {
        after: {
            New: function (dataView, args) {
                $app.input.execute({ Quantity: 1 });
            }

        },
        Calculate: function (dataView, args) {
            var orderDetails = dataView.data();
            var unitPrice = orderDetails.Quantity;
            if (unitPrice == null)
                unitPrice = 0;

            var quantity = orderDetails.Quantity;
            if (quantity == null)
                quantity = 0;

            //var discount = orderDetails.Discount;
            //if (discount == null)
            //    discount = 0;

            var extendedCost = unitPrice * quantity //* (1 - discount);
            $app.input.execute({ ExtendedCost: extendedCost })
            return false;
        }
        
      
    }
    // barcode input simulator
    //'explain code below'

    // Barcode Input simulation
    $(document).on('context.app', function (e) {
        e.context.push({
            text: 'Scan Product 1',
            shortcut: 'CTRL+Shift+1',
            callback: (e) => {
                $app.input.execute('5053264925294');
            }
        });
    });
    //Low level barcode processing
    $(document).on('barcode.app', function (e) {
        $app.touchui.notify('I am handling this: ' + e.text);
        $app.input.barcode(true);
        setTimeout(function () {
            $app.input.barcode(false);
        }, 1000);
        return false;
    });

  

})();