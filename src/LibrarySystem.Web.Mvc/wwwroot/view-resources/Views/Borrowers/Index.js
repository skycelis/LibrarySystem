//(function ($) {
//    var _$form = $('form[name=CreateBorrowerForm]');
//    l = abp.localization.getSource('LibrarySystem');
//    var _borrowerAppService = abp.services.app.borrower;


//    $(document).on('click', '.edit-borrower', function (e) {
//        var borrowerId = parseInt($(this).attr("data-borrower-id"));

//        e.preventDefault();
//        window.location.href = "/Borrower/CreateBorrower/" + borrowerId;
//    });


//    $(document).on('click', '.delete-borrower', function () {
//        var borrowerId = parseInt($(this).attr("data-borrower-id"));


//        deleteBorrower(borrowerId);      ~ i'll be back ~
//    });

//    function deleteBorrower(borrowerId) {
//        abp.message.confirm(
//            abp.utils.formatString(
//                l('AreYouSureWantToDelete',
//                    borrower
//                )),
//            null,
//            function (isConfirmed) {
//                if (isConfirmed) {
//                    if (borrowerId > 0) {
//                        _borrowerAppService.delete({
//                            id: borrowerId
//                        })
//                            .done(function () {
//                                abp.notify.info(l('SuccessfullyDeleted'));
//                            });
//                    }
//                }
//            }
//        );
//    }

//})(jQuery);