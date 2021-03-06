﻿import './layout.js';
import 'bootstrap-toggle';

import { Data } from 'common/data.js';
import { Loader } from 'common/loader.js';
import { Notifier } from 'common/notifier.js';
import { handleApplicationRestart } from 'restart-app.js';

function initExtensions() {
    let $dropArea = $('#drop-area');

    $('body').on('change', '.activate-module', function (ev) {
        let isActive = this.checked;
        let name = $(this).attr('data-name');

        Loader.show('#fff');
        Data.postJson({ url: '/sitetriks/extensions/UpdateModule', data: { isActive, name } }).then(function (res) {
            if (res.success) {
                if (res.doNotRefresh) {
                    Loader.hide();
                    return;
                }

                handleApplicationRestart({ url: '/sitetriks/extensions' });
            } else {
                Loader.hide();
                Notifier.createAlert({ containerId: '#alerts', message: res.message, status: 'danger' });
                $(ev.target).bootstrapToggle('off');
            }
        }, Data.defaultError);
    });

    $('.drop-info-btn').on('click', function (ev) {
        $('#input-files').trigger('click');
    });

    $('#input-files').on('change', function (ev) {
        upload(this.files);
    });

    function upload(files) {
        let formData = new FormData();

        for (var i = 0; i < files.length; i++) {
            formData.append('files', files[i], files[i].name);
        }

        Loader.show('#fff');
        Data.postForm({ url: '/sitetriks/extensions/index', formData: formData }).then(function (res) {
            let $extensions = $('.extensions-installed');

            if (res.success) {
                for (let i = 0; i < res.installed.length; i += 1) {
                    $extensions.append('<label class="module-name clearfix">' + res.installed[i].displayName + ' <input class="activate-module" type="checkbox" data-size="mini" data-onstyle="success" data-toggle="toggle"  data-name="' + res.installed[i].name + '" /></label>');
                }

                $('.activate-module').bootstrapToggle();
            } else {
                Notifier.createAlert({ containerId: '#alerts', message: res.message, status: 'danger' });
            }

            Loader.hide();
        }, Data.defaultError);
    }

    $dropArea.on(
        'dragover',
        function (e) {
            e.preventDefault();
            e.stopPropagation();
        }
    );

    $dropArea.on(
        'dragenter',
        function (e) {
            $(this).addClass('drop-highlight');
            e.preventDefault();
            e.stopPropagation();
        }
    );

    $dropArea.on(
        'dragleave',
        function (e) {
            $(this).removeClass('drop-highlight');
            e.preventDefault();
            e.stopPropagation();
        }
    );

    $dropArea.on(
        'drop',
        function (e) {
            if (e.originalEvent.dataTransfer) {
                if (e.originalEvent.dataTransfer.files.length) {
                    e.preventDefault();
                    e.stopPropagation();

                    upload(e.originalEvent.dataTransfer.files);
                }
            }
        }
    );

    $('.upload-tab').on('click', function (ev) {
        $('.upload-tab.active').removeClass('active');
        $(this).addClass('active');
    });
}

window.initExtensions = initExtensions;
