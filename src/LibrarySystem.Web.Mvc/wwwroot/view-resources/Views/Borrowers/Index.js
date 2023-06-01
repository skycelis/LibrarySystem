(function ($) {
    var _$form = $('form[name=CreateBorrowerForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _borrowerAppService = abp.services.app.borrower;


    $(document).on('click', '.edit-brwr', function (e) {
        var borrowerId = parseInt($(this).attr("data-brwr-id"));

        e.preventDefault();
        window.location.href = "/Borrowers/CreateBorrower/" + borrowerId;
    });


    $(document).on('click', '.delete-brwr', function () {
        var borrowerId = parseInt($(this).attr("data-brwr-id"));
        var borrowerBorrowDate = $(this).attr("data-brwr-date");
        
        deleteBorrower(borrowerId, borrowerBorrowDate);      
    });

   function deleteBorrower(borrowerId) {
        abp.message.confirm(
            abp.utils.formatString(
              l('AreYouSureWantToDelete',
                   borrower
                )),
           null,
           function (isConfirmed) {
                if (isConfirmed) {
                    if (borrowerId > 0) {
                        _borrowerAppService.delete({
                           id: borrowerId
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