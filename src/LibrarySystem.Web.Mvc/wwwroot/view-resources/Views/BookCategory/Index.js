(function ($) {
    var _$form = $('form[name=CreateBookCategoryForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookcategoryAppService = abp.services.app.bookcategory;


    $(document).on('click', '.edit-bookcat', function (e) {
        var bookcategoryId = parseInt($(this).attr("data-bookcat-id"));

        e.preventDefault();
        window.location.href = "/BookCategories/CreateBookCategory/" + bookcategoryId;
    });


    $(document).on('click', '.delete-bookcat', function () {
        var bookcategoryId = parseInt($(this).attr("data-bookcat-id"));
        var bookcategoryName = $(this).attr("data-bookcat-name");

        deleteBookCategory(bookcategoryId, bookcategoryName);
    });

    function deleteBookCategory(bookcategoryId, bookcategoryName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                    bookcategoryName
                )),
            null,
            function (isConfirmed) {
                if (isConfirmed) {
                    if (bookcategoryId > 0) {
                        _bookcategoryAppService.delete({
                            id: bookcategoryId
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