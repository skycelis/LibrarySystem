﻿(function ($) {
    var _$form = $('form[name=CreateBookForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookAppService = abp.services.app.book;

    $(document).on('click', '.edit-book', function (e) {
        var bookId = parseInt($(this).attr("data-book-id"));

        e.preventDefault();
        window.location.href = "/Books/CreateBook/" + bookId;
    });


    $(document).on('click', '.delete-book', function () {
        var bookId = parseInt($(this).attr("data-book-id"));
        var bookTitle = $(this).attr("data-book-name");


        deleteBook(bookId, bookTitle);
    });

    function deleteBook(bookId, bookTitle) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                    bookTitle
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
                                location.reload(true);
                            });
                    }
                }
            }
        );
    }

})(jQuery);