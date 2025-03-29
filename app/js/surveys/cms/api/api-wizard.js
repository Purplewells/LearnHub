({
    "text": "API Registration",
    "description": "Register an external Application Programming Interface (API).",
    "cache": false,
    topics: [
        {
            questions: [
                {
                    name: "API",
                    placeholder: '(select provider)',
                    tooltip: 'The API provider.',
                    required: true,
                    value: null,
                    items: {
                        style: 'DropDownList',
                        list: [
                            { value: 'googledrive', text: 'Google Drive' }
                            //,
                            //{ value: 'facebook', text: 'Facebook' },
                            //{ value: 'msgraph', text: 'Microsoft Graph' },
                            //{ value: 'linkedin', text: 'LinkedIn' },
                            //{ value: 'windowslive', text: 'Windows Live' },
                            //{ value: 'sharepoint', text: 'SharePoint' },
                            //{ value: 'identityserver', text: 'Identity Server' },
                            //{ value: 'dnn', text: 'DotNetNuke' },
                            //{ value: 'cloudidentity', text: 'Cloud Identity' },
                        ]
                    },
                    readOnlyWhen: 'this.survey().context.SiteContentID != null',
                    options: {
                        lookup: {
                            openOnTap: true,
                            nullValue: false
                        }
                    }
                },
                {
                    name: 'AccessToken',
                    placeholder: 'OAuth token authorized to access API.',
                    visibleWhen: '$row.API != null'
                },
                {
                    name: 'RefreshToken',
                    placeholder: 'OAuth token provided to generate new access tokens.',
                    visibleWhen: '$row.API != null'
                },
                {
                    name: 'Key',
                    placeholder: 'Specify key authorized to access API.',
                    visibleWhen: '$row.API != null'
                }
            ]
        },
        {
            text: 'Open Authentication',
            visibleWhen: '$row.API != null',
            questions: [
                {
                    name: 'ClientId',
                    required: true,
                    placeholder: 'Unique ID for this application.',
                    tooltip: 'Client identifier used by the authentication provider to look up configuration.',
                    visibleWhen: '$row.API != null'
                },
                {
                    name: 'ClientSecret',
                    required: true,
                    placeholder: 'Secret key for server-to-server communication.',
                    tooltip: 'Secret value used to authenticate server-to-server communications.',
                    visibleWhen: '$row.API != null'
                },
                {
                    name: 'ClientUri',
                    placeholder: 'The root URL of the authentication server.',
                    tooltip: 'Web address of the authentication provider.',
                    visibleWhen: '$row.API != null && ($row.API.match(/dnn|sharepoint|identityserver|cloudidentity/))',
                    options: { clearOnHide: true }
                },
                {
                    name: 'TenantID',
                    placeholder: 'ID of the tenant. Enter "common" for general purpose use.',
                    tooltip: 'Identifier of the authentication service used by Microsoft Graph API.',
                    visibleWhen: '$row.API == "msgraph"',
                    options: { clearOnHide: true }
                },
                {
                    name: 'RedirectUri',
                    placeholder: 'Public address of the app.',
                    tooltip: 'Publicly accessible address that clients will use to connect to this app.',
                    causesCalculate: true,
                    visibleWhen: '$row.API != null'
                },
                {
                    name: 'LocalRedirectUri',
                    placeholder: 'Local development URL for testing.',
                    tooltip: 'Used in place of the Redirect Uri when app detects that it is running locally.',
                    causesCalculate: true,
                    visibleWhen: '$row.API != null && !$row.API.match(/dnn|sharepoint/)',
                    options: { clearOnHide: true }
                }
            ]
        }
        ,
        {
            text: 'Authorization Scopes',
            visibleWhen: '$row.API != null && !$row.Key',
            questions: [
                {
                    name: "Scope_Drive_ReadOnly",
                    text: 'Read-Only Access (Files)',
                    footer: 'https://www.googleapis.com/auth/drive.readonly <br/>Allows read-only access to file metadata and file content.',
                    type: 'bool',
                    value: true,
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.readonly'
                },
                {
                    name: "Scope_Drive_Metadata_ReadOnly",
                    text: 'Read-Only Access (Metadata)',
                    footer: 'https://www.googleapis.com/auth/drive.metadata.readonly <br/>Allows read-only access to file metadata (excluding <b>downloadUrl</b> and <b>thumbnail</b>), but does not allow any access to read or download file content.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.metadata.readonly'
                },
                {
                    name: "Scope_Drive",
                    text: 'Full Access (Files)',
                    footer: 'https://www.googleapis.com/auth/drive <br/>Full, permissive scope to access all of a user\'s files, excluding the Application Data folder.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive'
                },
                {
                    name: "Scope_Drive_Metadata",
                    text: 'Full Access (Metadata)',
                    footer: 'https://www.googleapis.com/auth/drive.metadata <br/>	Allows read-write access to file metadata (excluding <b>downloadUrl</b> and <b>thumbnail</b>), but does not allow any access to read, download, write or upload file content. Does not support file creation, trashing or deletion. Also does not allow changing folders or sharing in order to prevent access escalation.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.metadata'
                },
                {
                    name: "Scope_Drive_AppFolder",
                    text: 'App Folder',
                    footer: 'https://www.googleapis.com/auth/drive.appfolder <br/>Allows access to the Application Data folder.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.appfolder'
                },
                {
                    name: "Scope_Drive_File",
                    text: 'File',
                    footer: 'https://www.googleapis.com/auth/drive.file <br/>Per-file access to files created or opened by the app. File authorization is granted on a per-user basis and is revoked when the user deauthorizes the app.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.file'
                },
                {
                    name: "Scope_Drive_Install",
                    text: 'Install',
                    footer: 'https://www.googleapis.com/auth/drive.install <br/>Special scope used to let users approve installation of an app, and scope needs to be requested.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.install'
                },
                {
                    name: "Scope_Drive_Apps_ReadOnly",
                    text: 'Read-Only Access (Apps)',
                    footer: 'https://www.googleapis.com/auth/drive.apps.readonly <br/>Allows read-only access to installed apps.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.apps.readonly'
                },
                {
                    name: "Scope_Activity",
                    text: 'Drive Activity API (Full)',
                    footer: 'https://www.googleapis.com/auth/drive.activity <br/>Allows read and write access to the Drive Activity API.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.activity'
                },
                {
                    name: "Scope_Activity_ReadOnly",
                    text: 'Drive Activity API (Read-Only)',
                    footer: 'https://www.googleapis.com/auth/drive.activity.readonly <br/>Allows read-only access to the Drive Activity API.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.activity.readonly'
                },
                {
                    name: "Scope_Drive_Scripts",
                    text: 'Scripts',
                    footer: 'https://www.googleapis.com/auth/drive.scripts <br/>Allows access to Apps Script files.',
                    type: 'bool',
                    items: { style: 'CheckBox' },
                    visibleWhen: '$row.API == "googledrive"',
                    _oauth_scope: 'https://www.googleapis.com/auth/drive.scripts'
                },
                {
                    name: 'Scope',
                    placeholder: 'Specify a space-separated list of scopes.',
                    tooltip: 'Specify additional scopes that will be requested in the authentication request.',
                    visibleWhen: '$row.API != null',
                    options: { clearOnHide: true }
                }
            ]
        }],
    buttons: [
        {
            id: 'a1',
            text: 'Get Access Token',
            click: 'apiregistrationaddsys.cms.app',
            //scope: 'context',
            when: function (e) {
                return (this.fieldValue('API') || '').match(/googledrive|sharepoint||msgraph|identityserver/);
            }
        }
    ],
    "options": {
        "modal": {
            "fitContent": true,
            "autoGrow": true,
            max: 'sm'
        },
        "materialIcon": "room_service",
        "discardChangesPrompt": false
    },
    "init": 'apiregistrationinit.cms.app',
    "calculate": 'apiregistrationcalc.cms.app',
    "submit": "apiregistrationsubmit.cms.app",
    'submitText': Web.DataViewResources.ModalPopup.SaveButton
});