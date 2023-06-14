(function ($) {
    var _$form = $('form[name=CreateBorrowerForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _borrowerappService = abp.services.app.borrower;
    var _bookappService = abp.services.app.book;
    var _indexPage = "/Borrowers";
    var _borrowDate = new Date();
    var _expectedReturnDate = new Date();

    _expectedReturnDate.setDate(_expectedReturnDate.getDate() + 7);

    window.onload = (event) => {
        document.getElementById('BorrowDate').value = _borrowDate.toISOString().slice(0, 10);
        document.getElementById('ExpectedReturnDate').value = _expectedReturnDate.toISOString().slice(0, 10);
    }

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var borrower = _$form.serializeFormToObject();
        borrower.BookId = parseInt(borrower.BookId);
        borrower.StudentId = parseInt(borrower.StudentId);
        if (borrower.Id != 0) {
            if (borrower.ExpectedReturnDate < borrower._returnDate) {
                _borrowerappService.update(borrower).done(function () {
                    _bookappService.GetUpdateBook({ Id: borrower.BookId, }).done(function () {
                        alert("Book not returned on time");
                        window.location.href = _indexPage;
                    });
                });
            }
            else if (borrower._returnDate < borrower._borrowDate) {
                alert("Cannot return the book at an earlier time than the borrowed date");
            }
            else {
                _borrowerappService.update(borrower).done(function () {
                    window.location.href = _indexPage;
                });
            }
        }
        else {
            _borrowerappService.create(borrower).done(function () {
                window.location.href = _indexPage;
            })
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
