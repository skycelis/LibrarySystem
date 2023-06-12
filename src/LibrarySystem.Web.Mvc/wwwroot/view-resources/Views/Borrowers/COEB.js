(function ($) {
    var _$form = $('form[name=CreateBorrowerForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _borrowerappService = abp.services.app.borrower;
    var _indexPage = "/Borrowers";
    var _borrowDate = new Date();
    var _returnDate = new Date();

    _returnDate.setDate(_returnDate.getDate() + 7);

    window.onload = (event) => {
        document.getElementById('borrow-date').value = _borrowDate.toISOString().slice(0, 10);
        document.getElementById('return-date').value = _returnDate.toISOString().slice(0, 10);
    }

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var borrower = _$form.serializeFormToObject();
        borrower.BookId = parseInt(borrower.BookId);
        borrower.StudentIdId = parseInt(borrower.StudentId);
        if (borrower.Id > 0) {
            _borrowerappService.update(borrower).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _borrowerappService.create(borrower).done(function () {
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