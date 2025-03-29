({
    "text": "Open Authentication Registration",
    "description": "Register your Single Sign-On provider.",
    "cache": false,
    topics: [
        {
            //text: 'General',
            questions: [
                {
                    name: "AuthenticationType",
                    text: 'Authentication',
                    placeholder: '(select provider)',
                    tooltip: 'The authentication provider.',
                    required: true,
                    value: null,
                    items: {
                        style: 'DropDownList',
                        list: [
                            { value: 'facebook', text: 'Facebook' },
                            { value: 'google', text: 'Google' },
                            { value: 'msgraph', text: 'Microsoft Graph' },
                            { value: 'linkedin', text: 'LinkedIn' },
                            { value: 'windowslive', text: 'Windows Live' },
                            { value: 'sharepoint', text: 'SharePoint' },
                            { value: 'identityserver', text: 'Identity Server' },
                            { value: 'dnn', text: 'DotNetNuke' },
                            { value: 'cloudidentity', text: 'Cloud Identity' },
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
                    name: 'ClientId',
                    required: true,
                    placeholder: 'Unique ID for this application.',
                    tooltip: 'Client identifier used by the authentication provider to look up configuration.',
                    visibleWhen: '$row.AuthenticationType != null'
                },
                {
                    name: 'ClientSecret',
                    required: true,
                    placeholder: 'Secret key for server-to-server communication.',
                    tooltip: 'Secret value used to authenticate server-to-server communications.',
                    visibleWhen: '$row.AuthenticationType != null'
                },
                {
                    name: 'ClientUri',
                    placeholder: 'The root URL of the authentication server.',
                    tooltip: 'Web address of the authentication provider.',
                    visibleWhen: '$row.AuthenticationType != null && ($row.AuthenticationType.match(/dnn|sharepoint|identityserver|cloudidentity/))',
                    options: { clearOnHide: true }
                },
                {
                    name: 'TenantID',
                    placeholder: 'ID of the tenant. Enter "common" for general purpose use.',
                    tooltip: 'Identifier of the authentication service used by Microsoft Graph API.',
                    visibleWhen: '$row.AuthenticationType == "msgraph"',
                    options: { clearOnHide: true }
                },
                {
                    name: 'RedirectUri',
                    placeholder: 'Public address of the app.',
                    tooltip: 'Publicly accessible address that clients will use to connect to this app.',
                    required: true,
                    causesCalculate: true,
                    visibleWhen: '$row.AuthenticationType != null'
                },
                {
                    name: 'LocalRedirectUri',
                    placeholder: 'Local development URL for testing.',
                    tooltip: 'Used in place of the Redirect Uri when app detects that it is running locally.',
                    causesCalculate: true,
                    visibleWhen: '$row.AuthenticationType != null && !$row.AuthenticationType.match(/dnn|sharepoint/)',
                    options: { clearOnHide: true }
                },
                {
                    name: 'Scope',
                    placeholder: 'Specify a space-separated list of scopes. By default, only basic profile, email address, and profile picture are requested.',
                    tooltip: 'Specify additional scopes that will be requested in the authentication request.',
                    visibleWhen: '$row.AuthenticationType != null && $row.AuthenticationType != "dnn"',
                    options: { clearOnHide: true }
                },
                {
                    name: 'Tokens',
                    length: 4000,
                    rows: 3,
                    placeholder: 'Specify a space-separated list of tokens.',
                    tooltip: 'List of DotNetNuke tokens that will be queried from the portal and saved to the user profile on login. These tokens can be accessed in business rules.',
                    visibleWhen: '$row.AuthenticationType == "dnn"',
                    options: { clearOnHide: true }
                },
                {
                    name: 'ProfileFieldList',
                    placeholder: 'Please enter an optional comma-separated list of fields for the user profile. By default only email field is requested.',
                    tooltip: 'Optional comma-separated list of fields for the user profile. For example, last_name, first_name, name, etc.',
                    visibleWhen: '$row.AuthenticationType == "facebook"',
                    options: { clearOnHide: true }
                },
                {
                    name: 'SyncUser',
                    type: 'Boolean',
                    value: true,
                    text: 'Synchronize users with authentication provider',
                    tooltip: 'When enabled, new users authenticated by the provider will have matching accounts created locally.',
                    visibleWhen: '$row.AuthenticationType != null',
                    items: { style: 'CheckBox' }
                },
                {
                    name: 'SyncRoles',
                    type: 'Boolean',
                    value: true,
                    text: 'Synchronize user roles with authentication provider',
                    tooltip: 'When enabled, roles returned by the provider will be synchronized to the matching local user account.',
                    visibleWhen: '$row.AuthenticationType != null && !$row.AuthenticationType.match(/facebook|windowslive|linkedin/) && $row.SyncUser == true',
                    items: { style: 'CheckBox' },
                    options: { clearOnHide: true }
                },
                {
                    name: 'AutoLogin',
                    type: 'Boolean',
                    text: 'Force users to login with this provider',
                    tooltip: 'When enabled, anonymous users that attempt to navigate to the app will be directed to login with this provider.',
                    visibleWhen: '$row.AuthenticationType != null',
                    items: { style: 'CheckBox' }
                },
                {
                    name: 'AccessToken',
                    visibleWhen: '$row.AccessToken != null'
                },
                {
                    name: 'RefreshToken',
                    visibleWhen: '$row.RefreshToken != null'
                }
            ]
        }
    ],
    buttons: [
        {
            id: 'a1',
            text: 'Add System Account',
            click: 'oauthregistrationaddsys.cms.app',
            //scope: 'context',
            when: function (e) {
                return (this.fieldValue('AuthenticationType') || '').match(/sharepoint|google|msgraph|identityserver/);
            }
        }
    ],
    "options": {
        "modal": {
            "fitContent": true,
            "autoGrow": true,
            max: 'sm'
        },
        "materialIcon": "settings_input_antenna",
        "discardChangesPrompt": false
    },
    "init": 'oauthregistrationinit.cms.app',
    "calculate": 'oauthregistrationcalc.cms.app',
    "submit": "oauthregistrationsubmit.cms.app",
    'submitText': Web.DataViewResources.ModalPopup.SaveButton
});