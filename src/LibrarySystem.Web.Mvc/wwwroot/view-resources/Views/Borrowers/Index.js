(function ($) {
    var _$form = $('form[name=CreateBorrowerForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _borrowerappService = abp.services.app.borrower;


    $(document).on('click', '.edit-borrower', function (e) {
        var borrowerId = parseInt($(this).attr("data-borrower-id"));

        e.preventDefault();
        window.location.href = "/Borrowers/CreateBorrower/" + borrowerId;
    });


    $(document).on('click', '.delete-borrower', function () {
        var borrowerId = parseInt($(this).attr("data-borrower-id"));
        var borrowerBorrowDate = $(this).attr("data-borrow-date");
        
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
                        _borrowerappService.delete({
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