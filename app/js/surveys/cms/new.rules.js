(function () {
    $(document).on('sitecontentnew.cms.app', function (e) {
        var data = e.dataView.data();
        $app.touch.whenPageShown(function () {
            if (data.NewContent === '$custom') {
                $app.touch.show({
                    controller: 'SiteContent',
                    startCommand: 'New',
                    startArgument: 'createForm1',
                    done: function (dataView) {
                        var data = dataView.data();
                        $app.touch.dataView().sync(data.SiteContentID);
                    }
                });
            }
            else {
                $app.survey({
                    controller: data.NewContent,
                    context: {}
                });
            }

        });
    });
})();