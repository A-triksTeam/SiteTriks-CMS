'use strict';

function Pager($container, pager, onPageChangeHandler) {
    var sizes = pager.pageSizes || [10];
    var pageSize = pager.default || sizes[0];
    var currentPage = 1;
    var pagesCount = 1;
    var isLocked = false;

    var $page = $('<span></span>', { text: currentPage, class: 'pageControl pageNumber' });
    var $pagesCount = $('<span></span>', { text: pagesCount, class: 'pageControl pagesCount' });
    var $pageSize = $('<select></select>', { class: 'pageControl pageSize' });
    var $prevPage = $('<span></span>', { class: 'pager-arrow previousPageArrow ' + (currentPage > 1 ? '' : 'btn-disabled') });
    var $nextPage = $('<span></span>', { class: 'pager-arrow nextPageArrow ' + (currentPage < pagesCount ? '' : 'btn-disabled') });

    sizes.forEach(function (element) {
        $('<option></option>', {
            text: element,
            value: element,
            selected: String(pageSize) === String(element)
        }).appendTo($pageSize);
    });

    $container.append($pageSize).append($prevPage).append($page).append($pagesCount).append($nextPage);

    bindEvents();

    function bindEvents() {
        $pageSize.on('change', onSizeChange);
        $prevPage.on('click', onPreviousPage);
        $nextPage.on('click', onNextPage);
    }

    function dispose() {
        $pageSize.off('change', onSizeChange);
        $prevPage.off('click', onPreviousPage);
        $nextPage.off('click', onNextPage);

        $container.children().remove();
    }

    // event handlers
    function onNextPage(ev) {
        if (!isLocked && currentPage < pagesCount) {
            setCurrentPage(currentPage + 1);
            lock();
            onPageChangeHandler(currentPage, pageSize);
        }
    }

    function onPreviousPage(ev) {
        if (!isLocked && currentPage > 1) {
            setCurrentPage(currentPage - 1);
            lock();
            onPageChangeHandler(currentPage, pageSize);
        }
    }

    function onSizeChange(ev) {
        if (!isLocked) {
            setCurrentPage(1);
            setPageSize($pageSize.val());
            lock();
            onPageChangeHandler(currentPage, pageSize);
        } else {
            setPageSize(pageSize);
        }
    }

    // methods
    function setPageSize(size) {
        if (size) {
            pageSize = size;
            $pageSize.val(size);
            if (size === 'all') {
                $prevPage.hide();
                $page.hide();
                $pagesCount.hide();
                $nextPage.hide();
            } else {
                $prevPage.show();
                $page.show();
                $pagesCount.show();
                $nextPage.show();
            }
        }

        return this;
    }

    function setCurrentPage(page) {
        if (page && pageSize !== 'all') {
            currentPage = page;
            $page.text(page);
            updateArrows();
        }

        return this;
    }

    function setPagesCount(pages) {
        if (pages && pageSize !== 'all') {
            pagesCount = pages;
            $pagesCount.text(pages);
            updateArrows();
        }

        return this;
    }

    function updateArrows() {
        if (currentPage > 1) {
            $prevPage.removeClass('btn-disabled');
        } else {
            $prevPage.addClass('btn-disabled');
        }

        if (currentPage < pagesCount) {
            $nextPage.removeClass('btn-disabled');
        } else {
            $nextPage.addClass('btn-disabled');
        }
    }

    function unlock() {
        isLocked = false;
        return this;
    }

    function lock() {
        isLocked = true;
        return this;
    }

    return {
        setCurrentPage: setCurrentPage,
        setPagesCount: setPagesCount,
        setPageSize: setPageSize,
        lock: lock,
        unlock: unlock,
        dispose: dispose
    };
}

var defaultPager = {
    pageSizes: [1, 2, 5, 10, 20, 50, 100, 'all'],
    pageReadOnly: true,
    default: 20
};