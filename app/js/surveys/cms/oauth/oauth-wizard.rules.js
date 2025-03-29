(function () {
    $(document).on('oauthregistrationinit.cms.app', function (e) {
        //$app.alert($app.survey._data.Text);
        var context = e.survey.context;
        if (context) {
            e.rules.updateFieldValue('AuthenticationType', context.FileName);
            if (context.Text) {
                var map = textToConfig(context.Text);
                e.rules.updateFieldValue('ClientId', map.ClientId);
                e.rules.updateFieldValue('ClientSecret', map.ClientSecret);
                e.rules.updateFieldValue('ClientUri', map.ClientUri);
                e.rules.updateFieldValue('TenantID', map.TenantID);
                e.rules.updateFieldValue('RedirectUri', map.RedirectUri);
                e.rules.updateFieldValue('LocalRedirectUri', map.LocalRedirectUri);
                e.rules.updateFieldValue('Scope', map.Scope);
                e.rules.updateFieldValue('Tokens', map.Tokens);
                e.rules.updateFieldValue('ProfileFieldList', map.ProfileFieldList);
                e.rules.updateFieldValue('SyncUser', map.SyncUser == 'true');
                e.rules.updateFieldValue('SyncRoles', map.SyncRoles == 'true');
                e.rules.updateFieldValue('AutoLogin', map.AutoLogin == 'true');
                e.rules.updateFieldValue('AccessToken', map.AccessToken);
                e.rules.updateFieldValue('RefreshToken', map.RefreshToken);
            }
        }
    }).on('oauthregistrationcalc.cms.app', function (e) {
        try {
            var data = e.dataView.data(),
                trigger = e.rules.trigger(),
                newUri;
            if (trigger == 'RedirectUri' && data.RedirectUri) {
                newUri = validateRedirectUri(data.RedirectUri, data.AuthenticationType);
                if (newUri != data.RedirectUri)
                    e.rules.updateFieldValue('RedirectUri', newUri);
            }
            else if (trigger == 'LocalRedirectUri' && data.LocalRedirectUri) {
                newUri = validateRedirectUri(data.LocalRedirectUri, data.AuthenticationType, true);
                if (newUri != data.LocalRedirectUri)
                    e.rules.updateFieldValue('LocalRedirectUri', newUri);
            }
        }
        catch (ex) {
            alert(ex);
        }
    }).on('oauthregistrationaddsys.cms.app', function (e) {
        e.preventDefault();
        var data = $app.touch.dataView().data();
        saveConfig(e.survey.context, data, function () {
            location.href = '../appservices/saas/' + data.AuthenticationType + '?storeToken=true&start=%2Fpages%2Fsite-content';
        });
    }).on('oauthregistrationsubmit.cms.app', function (e) {
        e.preventDefault();
        saveConfig(e.survey.context, $app.touch.dataView().data());
    });

    function validateRedirectUri(uri, type, httpOnly) {
        var path = '/appservices/saas/' + type;
        var i = uri.indexOf('/appservices');
        if (i == -1)
            uri += path;
        else if (uri.indexOf(path) == -1)
            uri = uri.substring(0, i) + path;
        if (!uri.startsWith('http'))
            uri = (httpOnly ? 'http://' : 'https://') + uri;
        return uri;
    }


    function saveConfig(context, data, callback) {
        var opts = {
            controller: 'SiteContent',
            values: [{ name: 'Text', newValue: configToText(data) }],
            done: function (result) {
                if (result.errors && result.errors.length)
                    $app.alert(result.errors[0]);
                else if (callback)
                    callback(result);
                else {
                    $app.touch.goBack(function () {
                        $app.touch.dataView().sync(context.SiteContentID || result.SiteContent.SiteContentID);
                    });
                }
            }
        };


        if (context.SiteContentID) {
            opts.view = 'editForm1';
            opts.command = 'Update';
            opts.values.push(
                { name: 'SiteContentID', oldValue: context.SiteContentID },
                { name: 'FileName', value: data.AuthenticationType },
                { name: 'Path', value: 'sys/saas' });
            $app.execute(opts);
        }
        else {
            opts.view = 'createForm1';
            opts.command = 'Insert';
            opts.values.push(
                { name: 'SiteContentID', value: null },
                { name: 'FileName', newValue: data.AuthenticationType },
                { name: 'Path', newValue: 'sys/saas' });

            // check for existing record
            $app.execute({
                controller: 'SiteContent',
                view: 'grid1',
                filter: [
                    { name: 'FileName', value: data.AuthenticationType, op: '=' },
                    { name: 'Path', value: 'sys/saas', op: '=' }
                ],
                done: function (result) {
                    if (result.SiteContent.length > 0)
                        $app.touch.goBack(function () {
                            $app.alert('OAuth registration "sys/saas/' + data.AuthenticationType + '" already exists.');
                        });
                    else
                        $app.execute(opts);
                }
            });
        }
    }

    function configToText(data) {
        var lines = [];
        lines.push('Client Id: ' + data.ClientId);
        lines.push('Client Secret: ' + data.ClientSecret);
        lines.push('Redirect Uri: ' + data.RedirectUri);
        if (data.SyncUser)
            lines.push('Sync User: true');
        if (data.SyncRoles)
            lines.push('Sync Roles: true');
        if (data.AutoLogin)
            lines.push('Auto Login: true');
        if (data.AuthenticationType.match(/dnn|sharepoint|identityserver|cloudidentity/))
            lines.push('Client Uri: ' + data.ClientUri);
        if (data.AuthenticationType == 'msgraph' && data.TenantID)
            lines.push('Tenant ID: ' + data.TenantID);
        if (data.AuthenticationType != 'dnn' && data.LocalRedirectUri)
            lines.push('Local Redirect Uri: ' + data.LocalRedirectUri);
        if (data.Scope)
            lines.push('Scope: ' + data.Scope);
        if (data.AuthenticationType == 'facebook' && data.ProfileFieldList)
            lines.push('Profile Field List: ' + data.ProfileFieldList);
        if (data.AuthenticationType == 'dnn' && data.Tokens)
            lines.push('Tokens: ' + data.Tokens);
        if (data.AccessToken)
            lines.push('Access Token: ' + data.AccessToken);
        if (data.RefreshToken)
            lines.push('Refresh Token: ' + data.RefreshToken);

        return lines.join('\n');
    }

    function textToConfig(text) {
        var lines = text.split('\n'),
            map = {},
            pendingProp = null;
        for (i in lines) {
            var line = lines[i];
            if (line != '') {
                var j = line.indexOf(':');
                if (pendingProp != null) {
                    map[pendingProp] = line;
                    pendingProp = null;
                }
                else if (j > -1) {
                    var name = line.substring(0, j).replace(/ /g, ''),
                        val = line.substring(j + 1);
                    map[name] = val.trim();
                    if (val.trim() == '')
                        pendingProp = name;
                }
            }
        }
        return map;
    }
})();
