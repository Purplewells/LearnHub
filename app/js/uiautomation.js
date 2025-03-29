(function () {

    $app.ifThisThenThat((app, context) =>
        app.if(context
            .page('product')
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
            .page('product')
            .list()
            .barcode()
            .field('Barcode')
        )
            .then(() => app.notify('There is no product with the barcode: ' + context.barcode()))
    );

    $app.ifThisThenThat((app, context) =>
        app.if(context
            .page('products')
            .list()
            .barcode()
            .field('Barcode')
        )
            .then(() => app.action('New'))
            .then(() => app.val({
                'Barcode': context.barcode(),
                'Quantity': 1,
                'UnitsOnOrder': 0,
                'ReOrderLevel': 0
            }))
            .then(() => app.focus('Name'))
            .then(() => app.notify('This barcode is not in the inventory. Please enter the product details.', 'long'))
    );

    $app.ifThisThenThat((app, context) =>
        app.if(context
            .page('products')
            .barcode('New Product')
        )
            .then(() => app.action('New'))
            .then(() => app.focus('Name'))
            .then(() => app.notify('Please enter the new product.'))
    );

})();