(function () {
    $(document).on('businessruleinit.cms.app', function (e) {
        //$app.alert($app.survey._data.Text);
        var context = e.survey.context;
        if (context && context.Text) {
            try {
                var data = JSON.parse(context.Text);
                e.rules.updateFieldValue('name', data.name);
                e.rules.updateFieldValue('description', data.description);
                e.rules.updateFieldValue('controller', data.controller);
                e.rules.updateFieldValue('type', data.type);
                e.rules.updateFieldValue('command', data.command);
                e.rules.updateFieldValue('argument', data.argument);
                e.rules.updateFieldValue('phase', data.phase);
                e.rules.updateFieldValue('script', data.script);
            }
            catch (ex) {
                $app.touch.notify('Error parsing the rule definition.');
            }
        }
    }).on('businessrulesubmit.cms.app', function (e) {
        e.preventDefault();
        saveConfig(e.survey.context, $app.touch.dataView().data());
    });



    function saveConfig(context, data) {
        var fileName = data.name;
        var path = 'sys/rules/' + data.controller;

        function saved(result) {
            if (result.errors && result.errors.length)
                $app.alert(result.errors[0]);
            else {
                $app.touch.goBack(function () {
                    $app.touch.dataView().sync(context.SiteContentID || result.SiteContent.SiteContentID);
                });
            }
        }


        if (context.SiteContentID)
            $app.execute({
                controller: 'SiteContent', view: 'editForm1', command: 'Update', values: [
                    { name: 'SiteContentID', oldValue: context.SiteContentID },
                    { name: 'FileName', newValue: fileName },
                    { name: 'Path', newValue: path },
                    { name: 'Text', newValue: JSON.stringify(data) }
                ]
            }).done(saved);
        else
            $app.execute({
                controller: 'SiteContent', view: 'createForm1', command: 'Insert', values: [
                    { name: 'SiteContentID', value: null },
                    { name: 'FileName', newValue: fileName },
                    { name: 'Path', newValue: path },
                    { name: 'ContentType', newValue: 'application/json' },
                    { name: 'Text', newValue: JSON.stringify(data) }
                ]
            }).done(saved);
    }

})();
