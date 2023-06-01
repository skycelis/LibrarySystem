(function ($) {
    var _$form = $('form[name=CreateBookForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookAppService = abp.services.app.book;
    var _indexPage = "/Books";

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var book = _$form.serializeFormToObject();
        book.BookCategoryId = parseInt(book.BookCategoryId);
        book.AuthorId = parseInt(book.AuthorId);
        if (book.Id > 0) {
            _bookAppService.update(book).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _bookAppService.create(book).done(function () {
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        }

    }

    $(document).on('click', '.cancel-button', function (e) {

        window.location.href = _indexPage;

    });

    _$form.find('.save-button').click(function (e) {
        e.preventDefault();
        save();
    });

})(jQuery);