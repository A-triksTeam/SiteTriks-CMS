﻿import { Data } from './common/data.js';
import { Blur } from './common/loader.js';

/* Desktop */

var homepageDesktopFuncTionality = (function () {


    var resizeBlueNavbar = function () {
        let scrollBottom = $(window).scrollTop() + $(window).height();

        if ($(this).scrollTop() >= 100) {
            $('.header-blue').css('height', '0px')
                .css('transition', 'height 1s')
                .css('.-webkit-transition', 'height 1s');
        }

        if ($(this).scrollTop() <= 80) {
            $('.header-blue').css('height', '40px')
                .css('transition', 'height .25s');
        }
    };

    var leafImageToggle = function () {
        $('.letter-2').one('webkitAnimationEnd oanimationend msAnimationEnd animationend',
            function (e) {
                $('.leaf-button-1').css('display', 'inline-block');
                $('.close-menu').css('display', 'inline-block').click();
            });

        $('.leaf-button-2').on('click', function () {
            $('html').addClass('st-no-overflow');
        });
    };

    var drawSnowflakeGlobal = (function () {

        let LineIndex = 0;
        var circleIndex = 0;
        var index = 0;

        function addLine(selector, lines, customClass) {
            var parent = $(selector);
            var lines = GetLine(3, lines, 'diamondLine');

            for (var i = 0; i < lines.length; i++) {
                lines[i].addClass(customClass);
                parent.append(lines[i]);
            }

            $('.diamondLine').hover(function () {
                for (var i = 0; i < lines.length; i++) {
                    lines[i].addClass('hover');
                }
            }, function () {
                for (var i = 0; i < lines.length; i++) {
                    lines[i].removeClass('hover');
                }
            });

            for (var i = 0; i < lines.length; i++) {
                parent.append(lines[i]);
            }
        }

        function addElement(height, width, angle, ratioOfRadius, selector, text, lines, parentDevider, maxRadius, customClass) {

            var parent = $(selector);
            var angleInRad = DegreesToRad(angle);
            var customClass = customClass || 'default-icon-class';
            var radius = maxRadius * ratioOfRadius;
            var top = maxRadius - Math.sin(angleInRad) * radius - height / 2;
            var left = maxRadius + Math.cos(angleInRad) * radius - height / 2;

            var element = $('<div>').addClass('element')
                .addClass(customClass)
                .css('width', width).css('height', height).css('top', top).css('left', left).html(text);

            element.attr('data-index', index);

            index++;

            var lines = GetLine(3, lines, 'line');

            for (var i = 0; i < lines.length; i++) {
                parent.append(lines[i]);
            }

            $(element).hover(function () {

                for (var i = 0; i < lines.length; i++) {
                    $('.logo-center').css('z-index', '1046');
                    lines[i].addClass('hover');

                }
            }, function () {
                for (var i = 0; i < lines.length; i++) {
                    lines[i].removeClass('hover');
                }
            });

            parent.append(element);

            for (var i = 0; i < lines.length; i++) {
                parent.append(lines[i]);
            }
        }

        function DegreesToRad(angle) {
            return angle / 180 * Math.PI;
        }

        function RadToDegree(rad) {
            return rad / Math.PI * 180;
        }

        function GetLine(width, points, customClass) {
            let segments = [];

            for (var i = 0; i < points.length; i += 1) {
                let startPoint = points[i];
                let endPoint = points[i + 1];

                let lenght = Math.sqrt(Math.pow(endPoint.x - startPoint.x, 2) + Math.pow(endPoint.y - startPoint.y,
                    2));
                let angle = RadToDegree(Math.atan2(endPoint.y - startPoint.y, endPoint.x - startPoint.x)) - 90;

                let shadow = '';

                if ((angle == 45 || angle > -47 && angle < -43 || angle == 315) && customClass === 'line') {
                    shadow = '0 3px 5px #c8d0d4';
                }
                else if (angle >= -230 && angle < -200 && customClass === 'line') { // rule for 10: 30 and 11 oclock
                    shadow = '1px 0 5px #c8d0d4';
                }
                else if ((angle == 90 || angle >= 40 && angle < 50 || angle == 0) && customClass === 'line') {
                    shadow = '3px 0 5px #c8d0d4';
                }
                else if (angle > 90 && angle < 270 && customClass === 'line') {
                    shadow = '3px 0 5px #c8d0d4';
                } else if ((angle <= 90 || angle >= 270) && customClass === 'line') {
                    shadow = '-3px 0 5px #c8d0d4';
                }

                var line = $('<div>')
                    .addClass(customClass)
                    // .addClass('line' + LineIndex)            
                    .css('height', lenght)
                    .css('width', width)
                    .css('top', startPoint.y)
                    .css('left', startPoint.x)
                    .css('transform', 'rotate(' + angle + 'deg)')
                    .css('transform-origin', '50% 0%')
                    .css('box-shadow', shadow);
                segments.push(line);

                LineIndex++;

                if (i + 1 == points.length - 1) {
                    break;
                }
            }

            return segments;
        }

        function radialToXY(r, angle, centerX, centerY) {

            var angleInRad = DegreesToRad(angle);

            var top = centerY - Math.sin(angleInRad) * r;
            var left = centerX + Math.cos(angleInRad) * r;

            return {
                x: left,
                y: top
            };
        }

        var drawSnowflake = function (halfwidth, elementSizeBase, parentDevider) {
            index = 0;

            var twelveOclock = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.50 * halfwidth, 90, halfwidth, halfwidth)
            ];

            var oneThirty = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, 45, halfwidth, halfwidth)
            ];

            var threeOclock = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.55 * halfwidth, 0, halfwidth, halfwidth)

            ];

            var fourThirty = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, -45, halfwidth, halfwidth)
            ];

            var sixOclock = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.75 * halfwidth, -90, halfwidth, halfwidth)
            ];

            var sevenThirty = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, -135, halfwidth, halfwidth)
            ];

            var nineOclock = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.55 * halfwidth, 180, halfwidth, halfwidth)
            ];

            var tenThirty = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, 135, halfwidth, halfwidth)
            ];

            // smaller lines
            var two = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.3 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, 20, halfwidth, halfwidth)
            ];


            var four = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.3 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, -20, halfwidth, halfwidth)
            ];

            var ten = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.3 * halfwidth, 180, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, 160, halfwidth, halfwidth)
            ];

            var eight = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.3 * halfwidth, 180, halfwidth, halfwidth),
                radialToXY(0.5 * halfwidth, 200, halfwidth, halfwidth)
            ];

            var eleven = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.25 * halfwidth, 90, halfwidth, halfwidth),
                radialToXY(0.47 * halfwidth, 113, halfwidth, halfwidth)
            ];


            var one = [
                radialToXY(0 * halfwidth, 0, halfwidth, halfwidth),
                radialToXY(0.25 * halfwidth, 90, halfwidth, halfwidth),
                radialToXY(0.47 * halfwidth, 66, halfwidth, halfwidth)
            ];


            addElement(0.7 * elementSizeBase, 0.8 * elementSizeBase * 3, 109, 0.7, '.dandelion-menu', 'environment sync', twelveOclock, parentDevider, halfwidth, 'environment_sync'); //12
            addElement(0.5 * elementSizeBase, 0.4 * elementSizeBase * 3, 100, 0.6, '.dandelion-menu', 'instance manager', twelveOclock, parentDevider, halfwidth, 'instance_manager'); //12

            addElement(0.9 * elementSizeBase, 0.9 * elementSizeBase * 3, 45, 0.75, '.dandelion-menu', 'import tool' + '</br>' + '(Sitefinity content)', one, parentDevider, halfwidth, 'import_tool'); // 1
            addElement(0.5 * elementSizeBase, 0.5 * elementSizeBase * 3, 70, 0.52, '.dandelion-menu', '1-click installation', one, parentDevider, halfwidth, 'click_installation'); // 1

            addElement(0.8 * elementSizeBase, 0.8 * elementSizeBase * 3, 25, 0.8, '.dandelion-menu', 'version control (revision history)', oneThirty, parentDevider, halfwidth, 'version_control'); // 1.5
            addElement(0.5 * elementSizeBase, 0.5 * elementSizeBase * 3, 35, 0.5, '.dandelion-menu', 'scheduled publishing', oneThirty, parentDevider, halfwidth, 'scheduled_publishing'); // 1.5

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, 8, 0.95, '.dandelion-menu', 'auto sitemap', two, parentDevider, halfwidth, 'auto_sitemap'); // 2

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, -3, 0.94, '.dandelion-menu', 'multilingual', threeOclock, parentDevider, halfwidth, 'multilingual'); // 3
            addElement(0.5 * elementSizeBase, 0.5 * elementSizeBase * 3, 1, 0.6, '.dandelion-menu', 'thumbnail generation', threeOclock, parentDevider, halfwidth, 'thumbnail_generation'); // 3

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, -17, 0.8, '.dandelion-menu', 'forums', four, parentDevider, halfwidth, 'forums'); // 4
            addElement(0.5 * elementSizeBase, 0.4 * elementSizeBase * 3, -21, 0.6, '.dandelion-menu', 'seo optimised', four, parentDevider, halfwidth, 'seo_optimised'); // 4

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, -36, 0.8, '.dandelion-menu', 'modular', fourThirty, parentDevider, halfwidth, 'modular'); // 4.5
            addElement(0.5 * elementSizeBase, 0.3 * elementSizeBase * 3, -51, 0.57, '.dandelion-menu', 'rtl support', fourThirty, parentDevider, halfwidth, 'rtl_support'); // 4.5

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, -155, 1.1, '.dandelion-menu', 'blogs', sevenThirty, parentDevider, halfwidth, 'blogs'); // 7.5
            addElement(0.5 * elementSizeBase, 0.5 * elementSizeBase * 3, -140, 0.7, '.dandelion-menu', 'multi-device layout builder', sevenThirty, parentDevider, halfwidth, 'layout_builder'); // 7.5

            addElement(0.6 * elementSizeBase, 0.6 * elementSizeBase * 3, -167, 1.2, '.dandelion-menu', 'tagging', eight, parentDevider, halfwidth, 'tagging'); // 8
            addElement(0.4 * elementSizeBase, 0.4 * elementSizeBase * 3, -165, 0.8, '.dandelion-menu', 'granular permissions', eight, parentDevider, halfwidth, 'granular_permissions'); // 8

            addElement(0.6 * elementSizeBase, 0.7 * elementSizeBase * 3, -178, 1.3, '.dandelion-menu', 'dynamic content', nineOclock, parentDevider, halfwidth, 'dynamic_content'); // 9
            addElement(0.5 * elementSizeBase, 0.4 * elementSizeBase * 3, -180, 0.8, '.dandelion-menu', 'image tracking', nineOclock, parentDevider, halfwidth, 'image_tracking'); // 9

            addElement(0.7 * elementSizeBase, 0.9 * elementSizeBase * 3, -185, 1.4, '.dandelion-menu', 'multisite management', ten, parentDevider, halfwidth, 'multisite_management'); // 10

            addElement(0.5 * elementSizeBase, 0.6 * elementSizeBase * 3, 161, 1.2, '.dandelion-menu', 'personalization', tenThirty, parentDevider, halfwidth, 'personalization'); // 10.5
            addElement(0.5 * elementSizeBase, 0.6 * elementSizeBase * 3, 160, 0.8, '.dandelion-menu', 'cdn integrations azure-amazon', tenThirty, parentDevider, halfwidth, 'cdn_integrations'); // 10.5

            addElement(0.7 * elementSizeBase, 0.9 * elementSizeBase * 3, 150, 1.1, '.dandelion-menu', 'search ' + '</br>' + '(Google integration)', eleven, parentDevider, halfwidth, 'google_integration'); // 11
            addElement(0.5 * elementSizeBase, 0.4 * elementSizeBase * 3, 131, .62, '.dandelion-menu', 'widget tracking', eleven, parentDevider, halfwidth, 'widget_tracking'); // 11

            addLine('.dandelion-menu', sixOclock, 'sixOclock'); // 6
            addElement(80, 80, 180, 0, '.dandelion-menu', '<div class="logo-center"><img src="../../SiteTriks/StaticFiles/images/Sitetriks_logo.svg" alt="logo" style="width: 80px; height: 80px; padding-left:2px; margin-top:2px;"></div>', [], parentDevider, halfwidth); // 11
        };

        return {
            drawSnowflake: drawSnowflake
        };
    })();

    var redrawSnowflakeGlobal = (function () {

        var wrapperHalfWidth;
        var state = -1;

        var reDrawSnowflake = function () {
            let windowWidth = $(window).width();
            let containerHalfWidth;

            if (windowWidth >= 2880) {
                $('.dandelion-menu').html('');
                $('.dandelion-menu').css('height', '1225px')
                    .css('width', '1402px');
                drawSnowflakeGlobal.drawSnowflake(700, 175, 2);
                state = 3;
            }

            else if ((windowWidth > 1280 && windowWidth < 2880) && !(state == 0)) {
                $('.dandelion-menu').html('');
                $('.dandelion-menu').css('height', '700px')
                    .css('width', '802px');
                drawSnowflakeGlobal.drawSnowflake(400, 100, 2);
                state = 0;
            } else if ((windowWidth <= 1280 && windowWidth > 993) && !(state == 1)) {
                $('.dandelion-menu').html('');
                $('.dandelion-menu').css('height', '525px')
                    .css('width', '602px');
                drawSnowflakeGlobal.drawSnowflake(300, 70, 2.5);
                state = 1;
            } else if ((windowWidth <= 992) && !(state == 2)) {
                $('.dandelion-menu').html('');
                $('.dandelion-menu').css('height', '437px')
                    .css('width', '502px');
                drawSnowflakeGlobal.drawSnowflake(250, 70, 5);
                state = 2;
            }
        };

        return {
            reDrawSnowflake: reDrawSnowflake
        };
    })();

    var moveToMiddleMenuIcon = function () {

        var $dandelionMenu = $('.dandelion-menu');
        $dandelionMenu.on('click', '.element', moveToIcon);

        function scrollcb(target) {
            let targetclass = target.className.split(' ')[1];
            // find the corresponding element
            let $targetIcon;
            //  $targetIcon = $(`#${targetclass}`);

            $targetIcon = $('#' + targetclass);
            let scrollDistance = $targetIcon.offset().top - 125;

            // scroll to the element
            $('html,body').animate({
                scrollTop: scrollDistance
            },
                'slow');
        }

        function moveToIcon(e) {
            let target = e.target;

            if (!$('.more-items').hasClass('more-clicked')) {
                $('.more-items').unbind().trigger('click');
                setTimeout(function () {
                    scrollcb(target);
                }, 500);

            } else {
                scrollcb(target);
            }

        }
    };

    return {
        leafImageToggle: leafImageToggle,
        resizeBlueNavbar: resizeBlueNavbar,
        moveToMiddleMenuIcon: moveToMiddleMenuIcon,
        redrawSnowflakeGlobal: redrawSnowflakeGlobal
    };

})();

/* Mobile */

var mobileMenuFunctionality = (function () {

    var clicked = false;
    const hamburgerCompress = 'https://sitetriks.azureedge.net/static-files/images/mobile/Compress.gif';
    const hamburgerExpand = 'https://sitetriks.azureedge.net/static-files/images/mobile/Expand.gif';
    const logoDark = 'https://sitetriks.azureedge.net/static-files/images/mobile/LOGO_mob.svg';
    const logoWhite = 'https://sitetriks.azureedge.net/static-files/images/mobile/LOGO_mob_w.svg';
    const selectedSection = '<div class="col col-xs-12"><div class="selected-feature" id="static-section"><div class="feature-content"></div></div></div>';

    let $detailedMenuItem = $('.wrapper-menu-items');
    let $mainDropdown = $('#middle-box');
    let $advanatagesDropdown = $('.advantages-block');
    let $technologyDropdown = $('.technology-block');
    let $mobileViewTopMenu = $('#mobile-view-top-menu');
    let $mobileMenuIcon = $mobileViewTopMenu.find('.menu-icon');
    let windowWidth = $(window).width();

    var closeMobileMenu = function () {
        $('#mobile-view-top-menu').slideUp('slow');
        $('.hamburger-image').attr('src', hamburgerExpand);
        setTimeout(function () {
            $('.logo-mobile-image').attr('src', logoDark);
            $('.logo-container-mobile').css('background-color', 'white');
        }, 800);
        $('.hidden-by-menu').css('display', 'block');
    };

    var expandMobileMenu = function () {
        $('#mobile-view-top-menu').slideDown('slow');
        $('.hamburger-image').attr('src', hamburgerCompress);
        setTimeout(function () {
            $('.logo-mobile-image').attr('src', logoWhite);
            $('.logo-container-mobile').css('background-color', '#123e7a');
        }, 800);
        if (windowWidth < 768) {
            $('.hidden-by-menu').css('display', 'none');
        }
    };

    var changeSlogan = function () {
        if (windowWidth < 768) {
            $('.entreprice-description').text('(Basic license available)');
            $('#middle-box .arrows').css('display', 'inline-block');
        } else if (windowWidth >= 768) {
            $('.entreprice-description').text('Available with SiteTriks\'s basic license.');
            $('#middle-box .arrows').css('display', 'none');
        }
    };

    var toggleDetailedMenu = function () {
        $mainDropdown.click(function () {
            $detailedMenuItem.toggle();
            $('.main-arrows').toggle();
        });
    };


    var slideUpDownMenu = function () {
        $('#hamburger-menu img').click(function (ev) {
            if ($(':animated').length) {
                return false;
            }
            if (clicked == false) {
                expandMobileMenu();
                clicked = true;
            } else if (clicked == true) {
                closeMobileMenu();
                clicked = false;
            }
        });
    };

    /* Technology and advantages */
    let advantagesToggle = function () {
        $advanatagesDropdown.click(function () {
            $('.bullets').toggle();
            $('.dropdownOne-advantage').toggle();
        });
    };

    let technologyListToggle = function () {
        $technologyDropdown.click(function () {
            $('.technology-links').toggle();
            $('.dropdownOne-tech').toggle();
        });
    };

    var enterpriseFeaturesMenu = function () {
        $('.wrapper-menu-items').on('click', $('.item-header'), function (event) {
            var button = $(event.target);
            //$('.item-arrow').toggle();
            if (!button.hasClass('item-header')) {
                button = button.parents('.item-header');
            }

            button.toggleClass('whiteText');
            button.next().toggle();
            button.children('img').toggle();
        });
    };

    var mobileIconSelect = function () {
        $('#mobile-view-top-menu').on('click', '.menu-icon', function (event) {
            let $button = $(event.target);

            if (!$button.hasClass('menu-icon')) {
                $button = $button.parents('.menu-icon');
            }
            $('#static-section').remove();
            if ($button.hasClass('active')) {
                $button.removeClass('active');
            } else if (!$button.hasClass('active')) {
                $('.menu-icon').removeClass('active');
                $button.addClass('active');
                $button.parent().parent().next().html(selectedSection);
            }
        });
    };

    var removeMobileMenu = function () {
        let windowWidth = $(window).width();
        let windowHeight = $(window).height();

        if (windowWidth > 767 && windowHeight > 620) {
            $('#mobile-view-top-menu').css('display', 'none');
            // $('.hidden-by-menu').css('display', 'block');
            closeMobileMenu();
            clicked = false;
        }
    };

    return {
        changeSlogan: changeSlogan,
        advantagesToggle: advantagesToggle,
        technologyListToggle: technologyListToggle,
        toggleDetailedMenu: toggleDetailedMenu,
        slideUpDownMenu: slideUpDownMenu,
        mobileIconSelect: mobileIconSelect,
        enterpriseFeaturesMenu: enterpriseFeaturesMenu,
        removeMobileMenu: removeMobileMenu
    };

})();

/* Bottom menu display and functionality*/

var bottomMenuFunctionality = (function () {
    let menusChanged = false;
    let url = 'downloads';
    var $bottomSection = $('.bottom-menu').find('.feature-content');

    var changeMenu = function () {
        let windowWidth = $(window).width();
        let mobileView = $('#mobile-view-menu');
        let desktopView = $('#desktop-view-menu');

        if (windowWidth < 768) {
            Blur.remove();
            $('#desktop-view-menu').css('display', 'none');
            $('#mobile-view-menu').css('display', 'block');

        } else if (windowWidth >= 768) {
            // check state of toggle menu and close if expanded
            if ($('.toggle-menu').attr('data-open-state') === 'expanded' && windowWidth <= 768) {
                $('.shrink-menu').click();
            }

            $('#desktop-view-menu').css('display', 'block');
            $('#mobile-view-menu').css('display', 'none');

        }
    };

    var loadDefaultBottomMenu = function (url) {

        Data.getJson({ url: '/sitetriks/display/GetPageString?pageUrl=' + url }).then(function (res) {
            if (res.success) {
                $bottomSection.html(res.view);
            }
        });
    };

    return {
        changeMenu: changeMenu,
        loadDefaultBottomMenu: loadDefaultBottomMenu
    };
})();

/* Request demo button */

$('.demo-button').on('click', function () {

    $('html, body').animate({
        scrollTop: $('.bottom-menu').offset().top
    }, 500);

    bottomMenuFunctionality.loadDefaultBottomMenu('contact-us');
});

function attachReadMoreHandler() {
    $('body').on('click', '.read-more', function () {
        let $target = $(this);

        let $textBlocks = $target.parents('.tree-row').find('.content');
        let $readMoreText = $target.parents('.tree-row').find('.read-more');

        $textBlocks.each(function () {
            $(this).toggleClass('short-text');
        });

        $readMoreText.each(function () {
            let $currentTarget = $(this);
            $currentTarget.children('.more').toggle();
            $currentTarget.children('.less').toggle();
        });
    });
}

$(document).ready(function () {
    homepageDesktopFuncTionality.leafImageToggle();
    homepageDesktopFuncTionality.moveToMiddleMenuIcon();

    attachReadMoreHandler();
    //   attachTermsAndContidionsHandlers();
});
$(document).ready(function () {
    mobileMenuFunctionality.toggleDetailedMenu();
    mobileMenuFunctionality.slideUpDownMenu();
    mobileMenuFunctionality.advantagesToggle();
    mobileMenuFunctionality.technologyListToggle();
    mobileMenuFunctionality.enterpriseFeaturesMenu();
    //   moveToMiddleMenuIcon();
});

$(window).scroll(homepageDesktopFuncTionality.resizeBlueNavbar);
$(window).ready(homepageDesktopFuncTionality.moveToMiddleMenuIcon);
//$(window).ready(homepageDesktopFuncTionality.redrawSnowflakeGlobal.reDrawSnowflake);
//$(window).resize(homepageDesktopFuncTionality.redrawSnowflakeGlobal.reDrawSnowflake);

$(window).ready(mobileMenuFunctionality.changeSlogan());
$(window).resize(mobileMenuFunctionality.changeSlogan);
$(window).ready(mobileMenuFunctionality.mobileIconSelect());
$(window).ready(mobileMenuFunctionality.removeMobileMenu);
$(window).resize(mobileMenuFunctionality.removeMobileMenu);

$(window).ready(bottomMenuFunctionality.changeMenu);
$(window).resize(bottomMenuFunctionality.changeMenu);
