(function () {
    $(document).on('apiregistrationinit.cms.app', function (e) {
        //$app.alert($app.survey._data.Text);
        var survey = e.survey,
            context = survey.context;
        if (context) {
            e.rules.updateFieldValue('API', context.FileName);
            if (context.Text) {
                var map = textToConfig(context.Text);
                e.rules.updateFieldValue('ClientId', map.ClientId);
                e.rules.updateFieldValue('ClientSecret', map.ClientSecret);
                e.rules.updateFieldValue('ClientUri', map.ClientUri);
                e.rules.updateFieldValue('TenantID', map.TenantID);
                e.rules.updateFieldValue('RedirectUri', map.RedirectUri);
                e.rules.updateFieldValue('LocalRedirectUri', map.LocalRedirectUri);
                var scope = map.Scope;
                if (scope) {
                    scope = scope.split(/\s+/g);
                    survey.topics.forEach(function (t) {
                        t.questions.forEach(function (q) {
                            if (q.name && q.name.match(/^Scope_/)) {
                                var index = scope.indexOf(q._oauth_scope),
                                    selected = index !== -1;
                                if (selected)
                                    scope.splice(index, 1);
                                e.rules.updateFieldValue(q.name, selected);
                            }
                        });
                    });
                    scope = scope.join(' ');
                }

                e.rules.updateFieldValue('Scope', scope);
                e.rules.updateFieldValue('AccessToken', map.AccessToken);
                e.rules.updateFieldValue('RefreshToken', map.RefreshToken);
                e.rules.updateFieldValue('Key', map.Key);
            }
        }
    }).on('apiregistrationcalc.cms.app', function (e) {
        try {
            var data = e.dataView.data(),
                trigger = e.rules.trigger(),
                newUri;
            if (trigger === 'RedirectUri' && data.RedirectUri) {
                newUri = validateRedirectUri(data.RedirectUri, data.API);
                if (newUri !== data.RedirectUri)
                    e.rules.updateFieldValue('RedirectUri', newUri);
            }
            else if (trigger === 'LocalRedirectUri' && data.LocalRedirectUri) {
                newUri = validateRedirectUri(data.LocalRedirectUri, data.API, true);
                if (newUri !== data.LocalRedirectUri)
                    e.rules.updateFieldValue('LocalRedirectUri', newUri);
            }
        }
        catch (ex) {
            alert(ex);
        }
    }).on('apiregistrationaddsys.cms.app', function (e) {
        e.preventDefault();
        var data = $app.touch.dataView().data();
        saveConfig(e.survey, data, function () {
            location.href = '../appservices/saas/' + data.API + '?storeToken=true&start=%2Fpages%2Fsite-content';
        });
    }).on('apiregistrationsubmit.cms.app', function (e) {
        e.preventDefault();
        saveConfig(e.survey, $app.touch.dataView().data());
    });

    function validateRedirectUri(uri, type, httpOnly) {
        var path = '/appservices/saas/' + type;
        var i = uri.indexOf('/appservices');
        if (i === -1)
            uri += path;
        else if (uri.indexOf(path) === -1)
            uri = uri.substring(0, i) + path;
        if (!uri.startsWith('http'))
            uri = (httpOnly ? 'http://' : 'https://') + uri;
        return uri;
    }


    function saveConfig(survey, data, callback) {
        var context = survey.context,
            opts = {
                controller: 'SiteContent',
                values: [{ name: 'Text', newValue: configToText(survey, data) }],
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
                { name: 'FileName', value: data.API },
                { name: 'Path', value: 'sys/api' });
            $app.execute(opts);
        }
        else {
            opts.view = 'createForm1';
            opts.command = 'Insert';
            opts.values.push(
                { name: 'SiteContentID', value: null },
                { name: 'FileName', newValue: data.API },
                { name: 'Path', newValue: 'sys/api' });

            // check for existing record
            $app.execute({
                controller: 'SiteContent',
                view: 'grid1',
                filter: [
                    { name: 'FileName', value: data.API, op: '=' },
                    { name: 'Path', value: 'sys/api', op: '=' }
                ],
                done: function (result) {
                    if (result.SiteContent.length > 0)
                        $app.touch.goBack(function () {
                            $app.alert('API registration "sys/api/' + data.API + '" already exists.');
                        });
                    else
                        $app.execute(opts);
                }
            });
        }
    }

    function configToText(survey, data) {
        var lines = [];
        lines.push('Client Id: ' + data.ClientId);
        lines.push('Client Secret: ' + data.ClientSecret);
        lines.push('Redirect Uri: ' + data.RedirectUri);
        if (data.API.match(/dnn|sharepoint|identityserver|cloudidentity/))
            lines.push('Client Uri: ' + data.ClientUri);
        if (data.API === 'msgraph' && data.TenantID)
            lines.push('Tenant ID: ' + data.TenantID);
        if (data.API !== 'dnn' && data.LocalRedirectUri)
            lines.push('Local Redirect Uri: ' + data.LocalRedirectUri);

        var scope = (data.Scope || '').split(/\s+/g);
        survey.topics.forEach(function (t) {
            t.questions.forEach(function (q) {
                if (q.name && q.name.match(/^Scope_/) && data[q.name] && scope.indexOf(q._oauth_scope) === -1)
                    scope.push(q._oauth_scope);
            });
        });
        scope = scope.join(' ');
        if (scope)
            lines.push('Scope: ' + scope.trim());

        if (data.API === 'facebook' && data.ProfileFieldList)
            lines.push('Profile Field List: ' + data.ProfileFieldList);
        if (data.API === 'dnn' && data.Tokens)
            lines.push('Tokens: ' + data.Tokens);
        if (data.AccessToken)
            lines.push('Access Token: ' + data.AccessToken);
        if (data.RefreshToken)
            lines.push('Refresh Token: ' + data.RefreshToken);
        if (data.Key)
            lines.push('Key: ' + data.Key);

        return lines.join('\n');
    }

    function textToConfig(text) {
        var lines = text.split('\n'),
            map = {},
            pendingProp = null;
        for (i in lines) {
            var line = lines[i];
            if (line !== '') {
                var j = line.indexOf(':');
                if (pendingProp !== null) {
                    map[pendingProp] = line;
                    pendingProp = null;
                }
                else if (j > -1) {
                    var name = line.substring(0, j).replace(/ /g, ''),
                        val = line.substring(j + 1);
                    map[name] = val.trim();
                    if (val.trim() === '')
                        pendingProp = name;
                }
            }
        }
        return map;
    }
})();
