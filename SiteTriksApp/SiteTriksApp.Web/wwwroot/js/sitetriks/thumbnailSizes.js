﻿function createEditThumbnailSize(id) {
    let $fullForm = $('.form-horizontal');
    let $sizeType = $('#size-type');
    let $sizeName = $('#size-name');
    let $multiplierY = $('#multipliery');
    let $multiplierX = $('#multiplierx');
    let $offsety = $('#offsety');
    let $offsetx = $('#offsetx');
    let $sizeHeight = $('#size-height');
    let $sizeWidth = $('#size-width');


    $('#form-create-edit').on('submit', function (ev) {
        var _this = this;
        ev.preventDefault();

        let flag = true;

        flag = checkInputCombination();

        if (flag) {
            Loader.show(true);
            Data.postForm({ url: '/sitetriks/thumbnailssizes/createedit', formData: new FormData(_this) }).then(function (res) {
                if (!res.success) {
                    Loader.hide();
                }
                return res;
            }).then(function (res) {
                if (res.success) {
                    window.location.replace('/sitetriks/thumbnailssizes');
                } else {
                    Loader.hide();
                }
            })
        }

        return false;

    });


    // Separate input checks

    // Check if the inputs are valid numbers

    // check name
    $sizeName.on('input', function (ev) {
        let $name = $(this);
        let pattern = $name.val();

        if (pattern.length < 3) {
            $name.next().text('Thumbnails name must be atleast 3 charecters');
            $name.addClass('input-error');
        } else {
            $name.next().text('');
            $name.removeClass('input-error');
        }
    });


    $sizeType.on('input', hideOffsetOptions);
    $(window).load(function () {

        console.log('loaded');
        hideOffsetOptions();
    });

    // check all numbers
    $fullForm.on('input', 'input', function () {
        let $input = $(this);
        let inputValue = $input.val();

        if ($input.attr("type") == "number") {
            if (!$(this).hasClass('ratio')) {
                checkIfNumber($input, inputValue);
            }

            if ($(this).hasClass('ratio')) {
                checkRatioValue($input, inputValue);
            }
        };
    });

    // check type
    function hideOffsetOptions() {
        let selection = $sizeType.val();
        let $offsetWrapper = $('.offsets');

        if (selection == "0") {
            $offsetWrapper.css('display', 'none');
        } else {
            $offsetWrapper.css('display', 'block');
        }
    };

    function checkRatioValue(input, value) {
        let regex = /^[0-9/,/.]+$/;

        if (!value.match(regex) || +value > 1 || +value < 0) {
            input.next().text('The input value must be a valid decimal number between 0 and 1 separated by ","');
            input.addClass('input-error');
        } else {
            input.next().text('');
            input.removeClass('input-error');
        }
    }

    function checkIfNumber(input, value) {
        let regex = /^[0-9/,/.]+$/;

        if (!value.match(regex)) {
            input.next().text('The input value must be a valid number');
            input.addClass('input-error');
        } else {
            input.next().text('');
            input.removeClass('input-error');
        }
    }

    function checkInputCombination() {

        let sizeName = $sizeName.val();
        let multiplierY = +$multiplierY.val();
        let multiplierX = +$multiplierX.val();
        let offsety = +$offsety.val();
        let offsetx = +$offsetx.val();
        let sizeHeight = +$sizeHeight.val();
        let sizeWidth = +$sizeWidth.val();
        let type = $sizeType.val();


        var isValidResize = (multiplierX * sizeWidth) + (multiplierY * sizeHeight) == 0;
        var isValidCropWindow = ((sizeWidth * sizeHeight) > 0);
        var isValidCropSize = (((multiplierX * offsetx) + (multiplierY * offsety)) == 0);

        if (sizeName.length < 3) {
            console.log('failed name check');
            return false;
        }
        if (type == "1") {
            if (!isValidCropWindow) {
                $multiplierY.next().text('In order to use the Crop option you need to set width and height.');
                $sizeHeight.addClass('input-error');
                $sizeWidth.addClass('input-error');
                return false;
            }
            else {
                $multiplierY.next().text('');
                $sizeHeight.removeClass('input-error');
                $sizeWidth.removeClass('input-error');
            }

            if (!isValidCropSize) {
                $multiplierY.next().text('If you have selected to resize with the use of the multipliers, you cannot use an offset. In case you choose to resize by the offsets the multipliers should be equal to 0.');
                $offsety.addClass('input-error');
                $offsetx.addClass('input-error');
                $multiplierY.addClass('input-error');
                $multiplierX.addClass('input-error');
                return false;
            }
            else {
                $multiplierY.next().text('');
                $offsety.removeClass('input-error');
                $offsetx.removeClass('input-error');
                $multiplierY.removeClass('input-error');
                $multiplierX.removeClass('input-error');
            }
            return true;
        }

        if (type == "0") {
            if (!isValidResize) {
                $multiplierY.next().text('If you have selected to resize with the use of the multipliers, you cannot set width or height. In case you choose to resize by width and height the multipliers should be equal to 0.');
                $multiplierY.addClass('input-error');
                $multiplierX.addClass('input-error');
                $sizeHeight.addClass('input-error');
                $sizeWidth.addClass('input-error');
                return false;
            }
            else {
                $multiplierY.next().text('');
                $multiplierY.removeClass('input-error');
                $multiplierX.removeClass('input-error');
                $sizeHeight.removeClass('input-error');
                $sizeWidth.removeClass('input-error');
            }
        }
        return true;
    }

}
