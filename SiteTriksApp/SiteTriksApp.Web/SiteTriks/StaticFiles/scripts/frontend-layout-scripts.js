﻿/* globals SkypeWebControl, Prism, prettify */
import { Data } from './common/data.js';
import { Blur } from './common/loader.js';
import { documentationModule } from './widgets-helpers/documentation-widget.js';
import { initCarousel } from './widgets-helpers/carousel.js';
import { blogWidget } from './widgets-helpers/blog-widget.js';
import { contactFormWidget } from './widgets-helpers/contact-form.js';
import { forumWidget } from './widgets-helpers/forum-widget.js';
import { allNewsWidget } from './widgets-helpers/all-news.js';
import { licenseWidget } from './widgets-helpers/licenses-widgets.js';
import { subscriptionWidget } from './widgets-helpers/subscription.js';
import { socialShare } from './widgets-helpers/social-share.js';
import { tabsWidget } from './widgets-helpers/tabs-widget.js';
import { stwNavigation } from '../../../Assets/scripts/website/stw-navigation-widget.js';
import { stwVideoModal } from '../../../Assets/scripts/website/stw-navigation-widget.js';
//import { stwGetStartedModal } from './website/stw-navigation-widget.js';
import { stwWidgetPresentationMenu } from '../../../Assets/scripts/website/widget-presentation-menu.js';
import { stwScheduleDemoWidget } from './widgets-helpers/schedule-demo.js';
import { stwContactUsTemplate } from '../../../Assets/scripts/website/contact-us-template.js';
import { mobileMenuFunctionality } from '../../../Assets/scripts/website/stw-hp-custom.js';
import { termsAndConditions } from '../../../Assets/scripts/website/stw-hp-custom.js';
import { homepageCustomization } from '../../../Assets/scripts/website/stw-hp-custom.js';
import { stwLicenseApplication } from './widgets-helpers/license-application.js';
import { stwSupport } from '../../../Assets/scripts/website/stw-support.js';
import { stwSubscriptionWidget } from '../../../Assets/scripts/website/stw-subscription-widget';
//import { stwWoorankMetadata } from '../../../Assets/scripts/website/stw-woorank-metadata';
import { stwLoadDropdown } from '../../../Assets/scripts/website/stw-load-role-country-dropdowns.js';
import { stwCanonicalUrl } from '../../../Assets/scripts/website/stw-canonical-url.js';

function treeItemsSlide() {
    $('body').on('click', '.more-items', function (event, callback, target) {
        if (callback && {}.toString.call(callback) === '[object Function]' && target) {
            $('.hidden-section').slideToggle('slow', 'swing', function () {
                callback(target);
            });

            if ($(window).width() <= 767) {
                return;

            } else {
                $('.hidden-section-last-body').slideToggle('slow', 'swing', function () {
                    callback(target);
                });
            }
        } else {
            $('.hidden-section').slideToggle('slow');
            if ($(window).width() <= 767) {
                return;

            } else {
                $('.hidden-section-last-body').slideToggle('slow');
            }
        }
        $('.more-less-text').toggle();
        $('.more-items').toggleClass('more-clicked');
    });
}

function readMore() {
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

// PrettyPrint call for Tinymc
function prettyPrintInit() {
    if ($('pre').length > 0) {
        Prism.highlightAll();
    }

    if ($('.prettyprint').length > 0) {
        prettify();
    }
}

// 1.1 Video custom playlist logic
function loadMultiplePlaylistsContent() {

    // Add search functionality to the widget
    function getChannelDatails(channelId) {
        return Data.getJson({ url: 'https://www.googleapis.com/youtube/v3/channels?key=AIzaSyCWH87Tm8-WcMBNXi7N1QoK-AYZR3mhmR8&part=contentDetails&id=' + channelId }).then(function (data) {
            let channelUpload = data.items[0].contentDetails.relatedPlaylists.uploads;
            return Data.getJson({ url: 'https://www.googleapis.com/youtube/v3/playlistItems?playlistId=' + channelUpload + '&key=AIzaSyCR5In4DZaTP6IEZQ0r1JceuvluJRzQNLE&part=snippet&maxResults=50' });
        });
    }

    function searchVideo() {
        $('body').on('click', '.search-video', function () {
            $('.suggestions').css('display', 'block');

            let $container = $('.multiple-playlists .playlist-thumbnails-list .playlist-thumbnail');
            let fullData;
            let channelId = 'UCUsTZWP1OpyBXX2_CfMv1fA';
            let titles = [];

            fullData = getChannelDatails(channelId);
            fullData.then(function (result) {
                var myData = result;

                for (let i = 0; i < myData.items.length; i += 1) {
                    titles.push(myData.items[i].snippet.title);
                }

                function findMatches(wordToMatch, videos) {
                    return videos.filter(title => {
                        const regex = new RegExp(wordToMatch, 'gi');
                        return title.match(regex);
                    });
                }

                function displayMatches() {
                    const matchArrays = findMatches(this.value, titles);

                    const html = matchArrays.map(title => {
                        let itemPosition = titles.indexOf(title);
                        let videoId = myData.items[itemPosition].snippet.resourceId.videoId;
                        return `                <li class="name" data-id ="${videoId}">${title}</li>
                `;
                    }).join('');
                    suggestions.innerHTML = html;
                }

                const searchInput = document.querySelector('.search-video');
                const suggestions = document.querySelector('.suggestions');

                searchInput.addEventListener('keyup', displayMatches);
            });
        });
    }

    function selectVideo() {
        let selected = $(this).text();

        let videoId = $(this).attr('data-id');

        $('.search-video').val(selected);

        $('.video-container iframe').attr('src', `https://www.youtube.com/embed/${videoId}`);

        // Clean the input
        $('.search-video').val('');
        $('.suggestions').css('display', 'none');
    }

    function hideSuggestionsOnOutsideClick() {
        $('body').on('click', function (ev) {
            let $target = $(ev.target);
            if ($target.hasClass('search-video') || $target.hasClass('suggestions')) {
                return;
            }
            $('.suggestions').css('display', 'none');
        });
    }

    searchVideo();
    hideSuggestionsOnOutsideClick();
    $('body').on('click', '.name', selectVideo);
}

// custom video playlist
function loadVideoById() {
    $('body').on('click', '.video-thumbnail', function () {
        var iframeCurrentSource = $('.video-container iframe').attr('src');
        var thunmbnailSource = $(this).attr('data-videoId');

        if (!(iframeCurrentSource === thunmbnailSource)) {
            $('.video-container iframe').attr('src', thunmbnailSource);
        }
    });
}

// multiple playlists
function loadVideoSource() {
    $('body').on('click', '.playlist-thumbnail', function () {
        var iframeCurrentSource = $('.video-container iframe').attr('src');
        var thunmbnailSource = $(this).attr('data-videosource');

        if (!(iframeCurrentSource === thunmbnailSource)) {
            $('.video-container iframe').attr('src', thunmbnailSource);
        }
    });
}


// Video Multiple playlists logic
$(document).ready(function () {
    if ($('st-body-content').find('.multiple-playlists')) {
        // get all thumbnails ids
        let $container = $('.multiple-playlists .playlist-thumbnails-list .playlist-thumbnail');
        let source;

        $container.each(function (_, element) {
            source = $(this).data('videoid');
            let url = getYoutubeData(source).then(function (res) {

                let finalUrl = res.items[0].snippet.thumbnails.high.url;
                let title = res.items[0].snippet.title;

                $(element).children('img').attr('src', finalUrl);
                $(element).children('.playlist-title').text(title);
            });
            //,Data.defaultError);

        });
    }

    /*******************Get Youtube Playlist Thumbnails ***********************/

    function getYoutubeData(playlistId) {
        return Data.getJson({ url: 'https://www.googleapis.com/youtube/v3/playlists?part=snippet&id=' + playlistId + '&key=AIzaSyCWH87Tm8-WcMBNXi7N1QoK-AYZR3mhmR8' });
    }

});

function initSkype() {
    // skype on demand instead of on load
    let isSkypeLoaded = false;
    let isAttemptingCall = false;

    $('body').on('click', '.skype-call', loadSkype);
    function loadSkype(ev) {
        if (typeof SkypeWebControl === 'undefined' && !isSkypeLoaded) {
            let fileref = document.createElement('script');
            fileref.setAttribute('type', 'text/javascript');
            fileref.setAttribute('src', 'https://swc.cdn.skype.com/sdk/v1/sdk.min.js');
            document.getElementsByTagName('body')[0].appendChild(fileref);

            isSkypeLoaded = true;
        }

        if (!isAttemptingCall) {
            isAttemptingCall = true;
            attemptCall();
        }
    }

    function attemptCall() {
        if (typeof SkypeWebControl === 'undefined') {
            setTimeout(attemptCall, 1000);
            return;
        } else {
            isAttemptingCall = false;
            SkypeWebControl.SDK.Chat.startChat({ ConversationType: 'person', ConversationId: 'live:info_882922' });
        }
    }
}

// Init functions
$(document).ready(function () {
    treeItemsSlide();
    readMore();
    initSkype();
    //MetaTags.populateKeyWords('input[name=SEOKeyword]');
    //MetaTags.populateDescriptions('input[name=SEODescription]');
    loadMultiplePlaylistsContent();
    loadVideoById();
    loadVideoSource();

    // load widgets logic
    initCarousel();
    documentationModule();
    blogWidget();
    forumWidget();
    allNewsWidget();
    licenseWidget();
    subscriptionWidget.init();
    contactFormWidget();
    socialShare();
    stwNavigation();
    tabsWidget();
    stwWidgetPresentationMenu();
    stwScheduleDemoWidget();
    stwVideoModal();
    //  stwGetStartedModal();
    mobileMenuFunctionality.toggleDetailedMenu();
    mobileMenuFunctionality.enterpriseFeaturesMenu();
    stwContactUsTemplate();
    stwLicenseApplication();
    termsAndConditions.toggleContent();
    stwSupport();
	stwSubscriptionWidget();
	//stwWoorankMetadata();
	stwLoadDropdown();
	stwCanonicalUrl();
    //$(document).ready(function () {
    //    homepageCustomization.setNiceScroll();
    //})

    $(document).trigger('initCarousel');
    prettyPrintInit();

    //gallery
    $('body').on('click', 'img.display-image, img.gallery-image', function (ev) {
        let $target = $(ev.target);
        let src = $target.attr('src');

        let $container = Blur.add({ hideOnBlurClick: true });
        $('<img />', {
            class: 'blur-content preview-image',
            src: src
        }).appendTo($container);
    });

    $('body').on('click', 'img.display-video', function (ev) {
        let src = ev.target.getAttribute('data-url');
        let $container = Blur.add({ hideOnBlurClick: true });
        $('<video></video>', {
            class: 'blur-content',
            width: '560',
            height: '315',
            controls: true
        }).append($('<source/>', { type: 'video/mp4', src })).appendTo($container);
    });
});
window.Data = Data;