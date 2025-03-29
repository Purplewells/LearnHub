({
    "text": "Business Rule",
    "description": "Customize application behaviour.",
    "cache": false,
    topics: [
        {
            //text: 'General',
            questions: [
                {
                    name: 'name',
                    text: 'Name',
                    tooltip: 'A unique name of the business rule.',
                    required: true
                },
                {
                    name: 'description',
                    text: 'Description',
                    tooltip: 'An optional description of the business rule.',
                    placeholder: 'Optional',
                    rows: 3
                },
                {
                    name: 'controller',
                    text: 'Controller',
                    tooltip: 'The name of the data controller.',
                    required: true
                },
                {
                    name: 'type',
                    text: 'Type',
                    required: true,
                    items: {
                        style: 'DropDownList',
                        list: [
                            { value: 'Sql', text: 'SQL' },
                            { value: 'JavaScript', text: 'JavaScript' },
                            { value: 'Email', text: 'Email' }
                        ]
                    },
                    options: {
                        lookup: {
                            nullValue: false,
                            openOnTap: true
                        }
                    }
                },
                {
                    name: 'command',
                    text: 'Command',
                    required: true,
                    tooltip: 'A regular expression that will match the command name.'
                },
                {
                    name: 'argument',
                    text: 'Argument',
                    placeholder: 'Optional',
                    tooltip: 'A regular expression that will match the command argument.'
                },
                {
                    name: 'phase',
                    text: 'Phase',
                    required: true,
                    items: {
                        style: 'DropDownList',
                        list: [
                            { value: 'Before', text: 'Before' },
                            { value: 'Execute', text: 'Execute' },
                            { value: 'After', text: 'After' }
                        ]
                    },
                    options: {
                        lookup: {
                            nullValue: false,
                            openOnTap: true
                        }
                    }
                },
                {
                    name: 'script',
                    text: 'Script',
                    required: true,
                    rows: 10
                }
            ]
        }
    ],
    "options": {
        "modal": {
            "fitContent": true,
            "autoGrow": true,
            max: 'xs'
        },
        "materialIcon": "device_hub",
        "discardChangesPrompt": false
    },
    init: 'businessruleinit.cms.app',
    submit: "businessrulesubmit.cms.app",
    submitText: Web.DataViewResources.ModalPopup.SaveButton
});