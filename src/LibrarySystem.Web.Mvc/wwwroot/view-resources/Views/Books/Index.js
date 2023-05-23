(function ($) {
    var _$form = $('form[name=CreateBookForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookAppService = abp.services.app.book;


    $(document).on('click', '.edit-book', function (e) {
        var bookId = parseInt($(this).attr("data-book-id"));

        e.preventDefault();
        window.location.href = "/Book/CreateBook/" + bookId;
    });


    $(document).on('click', '.delete-book', function () {
        var bookId = parseInt($(this).attr("data-book-id"));
        var bookcategoryName = $(this).attr("data-bookcat-name");

        deleteBook(bookId, bookBookTitle);
    });

    function deleteBook(bookId, bookBookTitle) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                    bookBookTitle
                )),
            null,
            function (isConfirmed) {
                if (isConfirmed) {
                    if (bookId > 0) {
                        _bookAppService.delete({
                            id: bookId
                        })
                            .done(function () {
                                abp.notify.info(l('SuccessfullyDeleted'));
                            });
                    }
                }
            }
        );
    }

})(jQuery);