'use strict';

function initLibraries(grid, config, mediator, logger) {
    var $libs = $('#libs');
    var $btnEditLibrary = $('#btn-edit-lib');
    var $btnDeleteLibrary = $('#btn-delete-lib');

    if ($libs.val()) {
        config.defaultFilters = [{
            propertyName: 'LibraryId',
            comparison: 1,
            value: $libs.val()
        }];
    } else {
        $btnEditLibrary.hide();
        $btnDeleteLibrary.hide();
    }

    var gridObj = grid.init('.grid', config);
    var $grid = $('.grid');

    var $modal = $('#file-upload-modal');
    var $container = $modal.find('.file-handler-wrapper');
    var fileHandler = FileHandler($container, ['Upload'], $libs.val(), mediator, logger, true);

    bindEvents();

    // --------------------------------------------------------
    // event handlers   
    function fileUploadedHandler(data) {
        if (data) {
            var id = data.libraryId.toLowerCase();
            if ($libs.val() !== id) {
                $libs.val(id).trigger('change');
            } else {
                $(document).trigger('refreshGrid');
            }

            $modal.modal('hide');
        }
    }

    function copyUrl(ev) {
        var $target = $(ev.target);
        var url = location.origin + "/files/" + $target.attr("data-url");

        copyToClipboard(url);
    }

    function selectLibrary(ev) {
        var value = $(this).val();

        if (value) {
            gridObj.changeDefaultFilter({
                propertyName: 'LibraryId',
                comparison: 1,
                value: value
            });

            $btnEditLibrary.show();
            $btnDeleteLibrary.show();
        } else {
            gridObj.changeDefaultFilter();

            $btnEditLibrary.hide();
            $btnDeleteLibrary.hide();
        }

        mediator.dispatch('fileLibraryChange', value);
    }

    function editLibrary(ev) {
        var prefix = $('#libs :selected').attr('data-url');

        if (prefix && prefix.length > 0) {
            window.location.href = '/sitetriks/libraries/edit?url=' + prefix;
        }
    }

    function deleteLibrary(ev) {
        var id = $('#libs').val();

        Loader.show('#fff');
        Data.deleteJson({ url: '/sitetriks/libraries/delete/', data: { id: id } }).then(function (res) {
            if (res.success) {
                location.reload(true);
            } else {
                Loader.hide();
                console.log(res);
            }
        }, Data.defaultError);
    }

    function copyToClipboard(element) {
        var $temp = $("<input>");
        $("body").append($temp);
        $temp.val(element).select();
        document.execCommand("copy");
        $temp.remove();
    }

    // --------------------------------------------------------
    function bindEvents() {
        $grid.on('click', '.copy', copyUrl);
        $libs.on('change', selectLibrary);
        $btnDeleteLibrary.on('click', deleteLibrary);
        $btnEditLibrary.on('click', editLibrary);
        mediator.on('filesUploaded', fileUploadedHandler, 'filesUploaded', 'General');
        mediator.on('alert', Notifier.createAlert, 'createAlert', 'Notifier');
    }

    function dispose() {
        $grid.off('click', '.copy', copyUrl);
        $libs.off('change', selectLibrary);
        $btnDeleteLibrary.off('click', deleteLibrary);
        $btnEditLibrary.off('click', editLibrary);
        mediator.off('filesUploaded', 'filesUploaded', 'General');
        mediator.off('alert', 'createAlert', 'Notifier');
    }

    return {
        dispose: dispose
    };
}

function editLibraries(isNameAvailableLink, libraryId) {
    var $inputName = $('#input-name');
    var $editForm = $('#create-library-form');

    bindEvents();

    function validateName(e) {
        var $target = $(e.target);
        var flag = false;

        if (!Validator.validate($target, 'Title must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (!flag) {
            Data.postJson({ url: isNameAvailableLink, data: { name: $target.val(), id: libraryId } }).then(function (res) {
                Validator.validate($target, res.message || 'Name is already taken!', function (val) {
                    return res.success;
                });
            }, Data.defaultError);
        }
    }

    function submitEditForm(ev) {
        var flag = false;
        var _this = this;

        if (!Validator.validate($inputName, 'Title must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (!flag) {
            Loader.show('#fff');
            Data.postJson({ url: isNameAvailableLink, data: { name: $inputName.val(), id: libraryId } }).then(function (res) {
                if (res.success) {
                    return Data.postForm({ formData: new FormData(_this) });
                } else {
                    Validator.validate($inputName, res.message || 'Name is already taken!', function (val) {
                        return res.success;
                    });
                    Loader.hide();
                }
            }, Data.defaultError).then(function (res) {
                if (res.success) {
                    window.location.replace('/sitetriks/libraries/');
                } else {
                    Notifier.createAlert({ containerId: '#alerts', type: 'danger', message: 'Name  is aready in use!' });
                    Loader.hide();
                }
            }, Data.defaultError);
        }
    }

    function bindEvents() {
        $editForm.on('submit', submitEditForm);
        $inputName.on('input', validateName);
    }

    function dispose() {
        $editForm.on('submit', submitEditForm);
        $inputName.on('input', validateName);
    }
}

function createLibrary(validateUrlLink, isNameAvailableLink) {
    var $btnSubmit = $('input[type="submit"]');
    var $inputName = $('#input-name');
    var $inputPrefix = $('#input-prefix');
    var $prefixValidation = $inputPrefix.next('span.text-danger');
    var $libraryType = $('#library-type');
    var $allowedTypes = $('#allowed-types');
    var $createForm = $('#create-library-form');

    populateUrl($inputName, $inputPrefix, validateUrlOnChange);
    displayAllowedTypes.apply($libraryType[0]);
    var timer = 0;
    bindEvents();

    function displayAllowedTypes(ev) {
        $allowedTypes.html('');

        Loader.show('#fff');
        Data.getJson({ url: '/sitetriks/libraries/GetAllowedForType?type=' + this.value }).then(function (res) {
            if (res.success) {
                $allowedTypes.html('Allowed files: ' + (res.type.displayName || res.type.extensions));
            }

            Loader.hide();
        });
    }

    function validateUrlOnChange(e) {
        if (timer) {
            clearTimeout(timer);
        }

        var flag = false;
        if (!Validator.validate($inputPrefix, 'Prefix must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (!flag) {
            var url = $inputPrefix.val();
            timer = setTimeout(function () {
                validateUrl(validateUrlLink + '?url=' + url, $inputPrefix, $prefixValidation, $btnSubmit);
            }, 500);
            $prefixValidation.text('');
        }
    }

    function validateName(e) {
        var $target = $(e.target);
        var flag = false;

        if (!Validator.validate($target, 'Title must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (!flag) {
            Data.postJson({ url: isNameAvailableLink, data: { name: $target.val() } }).then(function (res) {
                Validator.validate($target, res.message || 'Name is already taken!', function (val) {
                    return res.success;
                });
            }, Data.defaultError);
        }
    }

    function submitCreateForm(ev) {
        var flag = false;
        var _this = this;

        if (!Validator.validate($inputName, 'Title must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (!Validator.validate($inputPrefix, 'Prefix must be atleast 3 characters long!', function (val) {
            return Validator.hasMinimumLength(val, 3);
        })) {
            flag = true;
        }

        if (flag) {
            ev.preventDefault();
            return false;
        }

        Loader.show('#fff');
        Data.getJson({ url: validateUrlLink + '?url=' + $inputPrefix.val() }).then(function (res) {
            if (res.success) {
                return Data.postJson({
                    url: isNameAvailableLink, data: { name: $inputName.val() }
                });
            } else {
                Validator.validate($inputPrefix, res.message || 'Prefix is invalid or already in use!', function (val) {
                    return false;
                });
                Loader.hide();
            }
        }, Data.defaultError).then(function (res) {
            if (res.success) {
                return Data.postForm({ formData: new FormData(_this) });
            } else {
                Validator.validate($inputName, res.message || 'Name is already taken!', function (val) {
                    return false;
                });
                Loader.hide();
            }
        }, Data.defaultError).then(function (res) {
            if (res.success) {
                window.location.replace('/sitetriks/libraries/');
            } else {
                Notifier.createAlert({ containerId: '#alerts', type: 'danger', message: 'Name or prefix is aready in use!' });
                Loader.hide();
            }
        });

        ev.preventDefault();
        return false;
    }

    function bindEvents() {
        $createForm.on('submit', submitCreateForm);
        $inputPrefix.on('input change', validateUrlOnChange);
        $libraryType.on('change', displayAllowedTypes);
        $inputName.on('input', validateName);
    }

    function dispose() {
        $createForm.on('submit', submitCreateForm);
        $inputPrefix.on('input change', validateUrlOnChange);
        $libraryType.on('change', displayAllowedTypes);
        $inputName.on('input', validateName);
    }
}