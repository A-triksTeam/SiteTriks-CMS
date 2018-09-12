'use strict';

var DynamicViews = function () {
    return {
        setupWidgetNameDropdown: function setupWidgetNameDropdown(selector) {
            $(selector).change(function () {
                var value = $(this).val();
                var $location = $('#location');
                var $info = $('#custom-location-info');

                if (value.indexOf('dynamic/') >= 0) {

                    var dynamicClassName = value.replace('dynamic/', '');
                    $location.show();
                    $info.show();

                    $location.val('/Views/Shared/Components/DynamicWidget/' + dynamicClassName + '/{ViewType}/{ViewName}.cshtml');
                    $info.text('Change {ViewType} and {ViewName} placeholders!');
                } else {

                    if (value === 'none') {
                        $location.show();
                    } else {
                        $location.hide();
                    }

                    $location.val('');
                    $info.hide();
                    $info.val('');
                }
            });
        }
    };
}();