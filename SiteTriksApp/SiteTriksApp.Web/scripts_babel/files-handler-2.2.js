'use strict';

/*============================================================================
*                           --- file-handler ---
*                           
*  - version 2.3: added library support for gallery widget
*  
*  ----------------------------- DEPRECATED ---------------------------------
*  use ~/js/modules/file-handler.js instead
*============================================================================
*/

console.error('files-handler-2.2.js is DEPRECATED, use ~/js/modules/file-handler.js instead');
function loadUploadTemplate(isMultiple, type, fieldId, libraryField) {
    $('#btn-show-upload').hide();
    var $modal = $('#upload-modal');
    var $container = $('#upload-container');
    $('#files-container').html('');
    $container.html('<p>Loading...</p>');
    if (isMultiple !== true) {
        isMultiple = false;
    }

    $modal.attr('data-multiple', isMultiple);
    var url = '/sitetriks/files/uploadTemplate?isMultiple=' + isMultiple;

    if (type) {
        $modal.attr('data-type', type);
    }

    if (fieldId) {
        $modal.attr('data-id', fieldId);
    }

    $('#page').text('0');
    $('#files-list').html('');
    $('#choice-file').hide();
    $('#upload-file').show();

    return Data.getJson({ url: url }).then(function (res) {
        $container.html(res);
        // res = $.parseJSON(res);
        if (libraryField) {
            var libId = $(libraryField).val();
            if (libId) {
                $('#library').val(libId.toUpperCase());
                loadAllowedTypes(libId);
            }
        }

        return { success: true };
    }, Data.defaultError);
}

function loadUploadUserImages(type, fieldId, eventId) {
    var $modal = $('#upload-modal');
    var $container = $('#upload-container');
    $('#files-container').html('');
    $container.html('<p>Loading...</p>');

    $modal.attr('data-multiple', true).attr('data-user-images', true);

    Data.getJson({ url: '/sitetriks/files/uploadUserImages' }).then(function (res) {
        $container.html(res.view);
        return res;
    }).then(function (res) {
        if (res.success) {
            loadAllowedTypes(res.libraryId);
            $('#upload-modal').attr('data-lib-id', res.libraryId);
        }
    });

    if (type) {
        $modal.attr('data-type', type);
    }

    if (fieldId) {
        $modal.attr('data-id', fieldId);
    }

    if (eventId) {
        $modal.attr('data-event-id', eventId);
    }

    $('#page').text('0');
    $('#files-list').html('');
    $('#choice-file').hide();
    $('#upload-file').show();
}

var libraryAllowed = void 0;

function loadAllowedTypes(libraryId) {
    var $inputFiles = $('#input-files');
    var $notifier = $('#accepted-formats');
    $('#files-container').html('');
    $inputFiles.val('');
    $notifier.text('');

    return Data.getJson({ url: '/sitetriks/libraries/GetAllowedForLibrary?id=' + libraryId }).then(function (res) {
        if (typeof res === 'string' || res instanceof String) {
            res = JSON.parse(res);
        }

        if (res.success) {
            $inputFiles.attr('disabled', false).attr('accept', res.ext);
            $notifier.text('Accepted files: ' + res.ext);
            libraryAllowed = replaceAll(replaceAll(res.ext, '*', ''), ',', '|');
        } else {
            $inputFiles.attr('disabled', true);
        }
    }, function (res) {
        console.log(res);
    });
}

// On library dropdown change
$('body').on('change', '#library', function () {
    var libraryId = $('#library').val();
    loadAllowedTypes(libraryId);
});

$('body').on('click', '#btn-show-choice', showChoice);

function showChoice(ev) {
    $('#btn-show-choice').hide();
    $('#btn-show-upload').show();
    files = [];
    uploadedFiles = [];
    $('#files-container').html('');
    $('#files-list').html('');

    $('#image-libs').html('');

    var selected = $('#' + $('#upload-modal').attr('data-id')).val();

    var $option = $('<option></option>', {
        value: 'all',
        text: 'All Images'
    });
    $option.appendTo('#image-libs');

    Data.getJson({ url: '/sitetriks/libraries/GetAllImageLibraries' }).then(function (res) {
        if (res.success) {
            for (var i = 0; i < res.libraries.length; i++) {
                var _$option = $('<option></option>', {
                    value: res.libraries[i].id,
                    text: res.libraries[i].name
                });

                if (selected && selected === res.libraries[i].id) {
                    _$option.attr('selected', true);
                }

                _$option.appendTo('#image-libs');
            }
        }
    }, Data.defaultError);

    loadImages();
    $('#choice-file').show();
    $('#upload-file').hide();
    cleanUp();
}

$('body').on('change', '#image-libs', function () {
    $('#files-container').html('');
    $('#files-list').html('');

    var id = $('#image-libs option:selected').val();

    if (id == 'all') {
        loadImages();
    } else {
        loadImages(id);
    }
});

$('body').on('click', '#btn-show-upload', function (e) {
    $('#btn-show-upload').hide();
    $('#btn-show-choice').show();
    $('#page').text('0');
    $('#files-list').html('');
    $('#choice-file').hide();
    $('#upload-file').show();
});

$('body').on('click', '#gallery-source a', function (e) {
    var source = $(this).attr('id');
    $('#gallery-source').data('source-type', source);
    $('#' + source).hide();
    switch (source) {
        case 'images':
            showChoice();
            $('.gallery-library').hide();
            $('.gallery-images').show();
            $('#library').show();
            break;
        case 'library':
            $('#images').show();
            files = [];
            uploadedFiles = [];
            $('#files-container').html('');
            $('#files-list').html('');
            $('#choice-file').hide();
            $('#upload-file').hide();
            cleanUp();

            $('.gallery-images').hide();
            $('.gallery-library').show();

            $('#gallery-libs').html('');

            var selected = $('#' + $('#upload-modal').attr('data-id')).val();

            Data.getJson({ url: '/sitetriks/libraries/GetAllImageLibraries' }).then(function (res) {
                if (res.success) {
                    console.log(res);
                    for (var i = 0; i < res.libraries.length; i++) {
                        var $option = $('<option></option>', {
                            value: res.libraries[i].id,
                            text: res.libraries[i].name
                        });

                        if (selected && selected === res.libraries[i].id) {
                            $option.attr('selected', true);
                        }

                        $option.appendTo('#gallery-libs');
                    }
                }
            }, Data.defaultError);
            break;
        default:
    }
});

// Form Data object is required to send files; TODO: Wrap in object accordingly to hide sensitive fields
var uploadedFiles = [];
var files = [];

// Hello. My name is Inigo Montoya. You killed my father. Prepare to die.

// On selecting files
function displayImages(isUserInput) {
    var $inputFiles = $('#input-files');
    files = $inputFiles[0].files;
    var $container = $('#files-container');
    $container.html('');
    uploadedFiles = [];

    Data.getJson({ url: '/templates/file-upload.html' }).then(function (res) {
        var template = Handlebars.compile(res);

        for (var i = 0; i < files.length; i++) {
            var regExp = new RegExp(libraryAllowed);

            if (!regExp.test(files[i].name) && !regExp.test(files[i].type)) {
                $container.append('<p><strong><span class="text-danger">' + files[i].name + ' file type is not supported by selected library and will not be uploaded!</span></strong></p>');
                continue;
            } else {
                var $fragment = $(document.createElement('div')).addClass('img-upload-wrapper upload-element-' + i);

                var fileName = files[i].name.substring(0, files[i].name.lastIndexOf('.'));
                var fileUrl = files[i].name.replace(/\s+/g, '-').replace(/-+/g, '-').toLowerCase();

                if (!isUserInput) {
                    // classes '.input-name', '.input-url' and ids '#input-name-*', '#input-url-', '#validate-url-*' are required for the js logic
                    $fragment.append(template({ index: i, name: fileName, alt: fileName, url: fileUrl }));
                }

                if (files[i].type && files[i].type.indexOf('image/') >= 0) {
                    var file = window.URL.createObjectURL(files[i]);
                    $fragment.append('<img src="' + file + '" class="display-image">');
                } else {
                    $fragment.append('<img src="/Images/default-document-image.png">');
                }

                $container.append($fragment);
                fileUrlValidation(fileUrl, '#input-url-' + i, $('#btn-submit'));

                var date = Date.parse(new Date());
                uploadedFiles.push({
                    name: fileName + '-' + date,
                    url: fileUrl + '-' + date,
                    alt: fileName,
                    originalName: files[i].name
                });
            }
        }
    });
};

$('body').on('click', '#btn-submit-images', function () {
    var $modal = $('#upload-modal');
    var $notifier = '#file-handler-notfier';
    $('#btn-submit').attr("disabled", true);

    if (uploadedFiles.length === 0 || files.length === 0) {
        Notifier.createAlert({
            containerId: $notifier,
            message: 'No files have been selected!',
            status: 'warning'
        });
        return;
    }

    var urls = [];
    var flag = false;
    if (!$modal.attr('data-user-images')) {
        $('.input-url').each(function (i, obj) {
            var url = $(obj).val();
            if (url.length < 3) {
                flag = true;
            }
            urls.push(url);
        });
    } else {
        for (var i = 0; i < uploadedFiles.length; i++) {
            urls.push(uploadedFiles[i].url);
        }
    }

    if (flag) {
        Notifier.createAlert({
            containerId: $notifier,
            message: 'Urls must be alteast 3 characters long!',
            status: 'danger'
        });
        return;
    }

    $('.input-name').each(function (i, obj) {
        var name = $(obj).val().trim();

        if (name.length < 3) {
            flag = true;
            return;
        }
    });

    if (flag) {
        Notifier.createAlert({
            containerId: $notifier,
            message: 'Name must be atleast 3 characters!',
            status: 'danger'
        });
        return;
    }

    Data.postJson({ url: '/sitetriks/pages/validateUrls', data: { urls: urls } }).then(function (res) {

        if (res.success) {
            if (!$modal.attr('data-user-images')) {
                updateFilesInfo(uploadedFiles);
            }

            var formData = new FormData();

            uploadedFiles.forEach(function (element) {
                formData.append('filesInfo', JSON.stringify(element));
            });

            for (var i = 0; i < files.length; i++) {
                formData.append('files', files[i], files[i].name);
            }

            if (!$('#upload-modal').attr('data-user-images')) {
                formData.append('library', $('#library').val());
            } else {
                formData.append('library', $('#upload-modal').attr('data-lib-id'));
            }

            return Data.postForm({ url: '/sitetriks/files/uploadfile', formData: formData });
        } else {
            Notifier.createAlert({
                containerId: $notifier,
                title: 'Not all urls are valid!',
                message: res.message,
                status: 'danger'
            });
            $('#btn-submit').attr("disabled", false);
        }
    }, function (res) {
        return res;
    }).then(function (res) {
        if (res.success) {
            var fieldId = $modal.attr('data-id');

            switch ($modal.attr('data-type')) {
                case 'main-image':
                    $('#' + fieldId).val(res.ids[0]);
                    createImageView(fieldId, res.ids[0]);
                    break;
                case 'images':
                    var currentImages = $('#' + fieldId).val();
                    if (currentImages) {
                        if (currentImages.length > 0 && currentImages[currentImages.length - 1] !== ';') {
                            currentImages += ';';
                        }

                        $('#' + fieldId).val(currentImages + res.ids.join(';'));
                    } else {
                        $('#' + fieldId).val(res.ids.join(';'));
                    }

                    $(res.ids).each(function (_, element) {
                        createImageView(fieldId, element);
                    });

                    if ($modal.attr('data-user-images')) {
                        var eventId = $modal.attr('data-event-id');
                        $(document).trigger("addImages", { ids: res.ids, eventId: eventId });
                    }

                    break;
                case 'grid':
                    $(document).trigger('refreshGrid');
                    break;
                default:
                    location.reload(true);
                    break;
            }

            // if modal
            $('#upload-modal .close').click();
            // if not modal
            cleanUp();
        } else {
            Notifier.createAlert({
                containerId: $notifier,
                title: 'Error has occured!',
                message: res.message,
                status: 'danger'
            });
            $('#btn-submit').attr("disabled", false);
        }
    }, function (res) {
        console.log(res);
    });
});

function updateFilesInfo(files) {
    for (var i = 0; i < files.length; i++) {
        files[i].name = $('#input-name-' + i).val();
        files[i].url = $('#input-url-' + i).val();
        files[i].alt = $('#input-alt-' + i).val();
        files[i].type = $('#dropdown-type-' + i).val();
    }
}

$('#upload-modal').on('click', '.close', cleanUp);

function cleanUp(ev) {
    files = [];
    uploadedFiles = [];
    $('#file-handler-notfier').html('');
    $('#files-container').html('');
    $('#input-files').val('');
}

$('body').on('input', '#upload-modal .input-name', function () {
    var urlId = '#' + $(this).attr('id').replace('name', 'url');
    var url = $(this).val().replace(/\s+/g, '-').replace(/-+/g, '-').toLowerCase();

    fileUrlValidation(url, urlId, $('#btn-submit'));
});

$('body').on('input', '#upload-modal .input-url', function () {
    var urlId = '#' + $(this).attr('id');
    var url = $(this).val().replace(/\s+/g, '-').replace(/-+/g, '-').toLowerCase();

    fileUrlValidation(url, urlId, $('#btn-submit'));
});

function fileUrlValidation(url, urlId, $btnSubmit) {
    var $urlField = $(urlId).val(url);
    var $validationField = $(urlId.replace('input', 'validate'));

    if (!url || url.length < 3) {
        $urlField.css("border", "1px solid red");
        $validationField.text('Url must be atleast 3 characters long!');
        $btnSubmit.attr("disabled", true);
    } else {
        validateUrl('/sitetriks/files/ValidateUrl?url=' + url, $urlField, $validationField, $btnSubmit);
    }
}

function createImageView(fieldId, imgLinkId) {
    var $container = $('<div class="news-listed-images-container"></div>');
    var $deleteBtn = $('<div class="news-listed-image-delete" data-id="' + imgLinkId + '" data-field="' + fieldId + '"><span class="glyphicon glyphicon-remove"></span></div>');
    var $img = $('<img src="/files/id/' + imgLinkId + '" class="display-image" />');

    $container.append($deleteBtn).append($img).appendTo('#' + fieldId + '-container');
}

function clearImageView(fieldId) {
    $('#' + fieldId + '-container').html('');
}

$(document).on('click', '.news-listed-image-delete', function () {
    var $trigger = $(this);
    var imgId = $trigger.attr('data-id');
    var fieldId = $trigger.attr('data-field');

    if (fieldId && fieldId !== '') {
        var currentImages = $('#' + fieldId).val();
        if (currentImages) {
            $('#' + fieldId).val(currentImages.replace(imgId, ''));
        }
    }

    $trigger.parent().remove();
});

function loadImages() {
    var id = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : '';

    var page = $('#page').text();
    $('#files-list').html('<p>Loading...</p>');

    Data.getJson({ url: '/sitetriks/files/getimages?page=' + page + '&libraryId=' + id }).then(function (res) {
        if (res.success) {
            $('#files-list').html('');
            var inputType = $('#upload-modal').attr('data-multiple') === 'true' ? 'checkbox' : 'radio';

            $(res.images).each(function (_, element) {
                displayImageView(element, inputType).appendTo('#files-list');
            });
        }
    });
}

function displayImageView(image, inputType) {
    var fieldId = $('#upload-modal').attr('data-id');

    var $container = $('<div class="image-container"></div>');
    var $name = $('<span>' + image.title + '</span>');
    var $input = $('<input type="' + inputType + '" data-id="' + image.id + '" name="images-list" />');
    var $img = $('<img src="/files/' + image.url + '" class="listed-image display-image" />');

    if (fieldId.indexOf('main') >= 0) {
        if ($('#' + fieldId).val() === image.id) {
            $input.attr('checked', 'checked');
        }
    }

    $container.append($input).append($name).append($img);

    return $container;
}

$('body').on('click', '#next-page', function (e) {
    var page = Number($('#page').text());

    $('#page').text(page + 1);
    loadImages();
});

$('body').on('click', '#previous-page', function (e) {
    var page = Number($('#page').text());

    if (page <= 0) {
        return;
    }

    $('#page').text(page - 1);
    loadImages();
});

$('body').on('click', '#upload-modal #btn-select', function () {
    var fieldId = $('#upload-modal').attr('data-id');
    var $notifier = $('#file-handler-notfier');

    $('input[name=images-list]:checked').each(function (_, element) {
        var id = $(element).attr('data-id');
        $(element).removeAttr('checked');

        if (fieldId.indexOf('main') >= 0) {
            $('#' + fieldId + '-container').html('');
            $('#upload-modal .close').click();
            $('#' + fieldId).val('');
        }

        var value = $('#' + fieldId).val();

        if ($('#upload-modal').attr('data-multiple') === 'false') {
            $('#' + fieldId).val(id);
            clearImageView(fieldId);
        } else {
            $('#' + fieldId).val(value + ';' + id);
        }

        createImageView(fieldId, id);
    });

    Notifier.createAlert({
        containerId: $notifier,
        message: 'Images added successfuly!',
        status: 'success'
    });
});