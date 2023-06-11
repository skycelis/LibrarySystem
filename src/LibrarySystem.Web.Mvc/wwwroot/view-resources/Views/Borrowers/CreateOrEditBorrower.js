(function ($) {
    var _$form = $('form[name=CreateBorrowerForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _borrowerAppService = abp.services.app.borrower;
    var _indexPage = "/Borrowers";
    var borrowDate = new Date();
    var returnDate = new Date();
    returnDate.setDate(borrowDate.getDate() + 7);
    var _date = new Date();
    var _month = _date.getMonth() + 1;
    var _year = _date.getFullYear();
    var _day = _date.getDate();

    if (_month < 10) _month = "0" + _month;
    if (_day < 10) _day = "0" + _day;

    var _cdate = _year + "-" + _month + "-" + _day;
    document.getElementById('BorrowDate').value = _cdate;

    //Expected Date
    var _date = new Date(document.getElementById('BorrowDate').value).getDate() + 7;
    var _expectedReturnDate = _year + "-" + _month + "-" + _cdate;
    document.getElementById('ExpectedReturnDate').valueAsDate = new Date();
    $('input').on('change', function () {
        var _cdate = new Date(document.getElementById('BorrowDate').value).getDate() + 7;
        var _expectedReturnDate = _year + "-" + _month + "-" + _cdate;
        document.getElementById('ExpectedReturnDate').value = formatDate(_newBorrowDate.addDays(7));
    });
    function formatDate() {
        var d = new Date(date),
            month = '' + (d.getMonth() + 1),
            day = '' + d.getDate(),
            year = d.getFullYear();

        return date;
    }
    function addDays(days) {
        var result = new Date();
        result.setDate(result.getDate() + days);
        return result;
    }

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var borrower = _$form.serializeFormToObject();
        borrower.BookId = parseInt(borrower.BookId);
        borrower.StudentId = parseInt(borrower.StudentId);
        abp.ui.setBusy(_$form);

        if (borrower.Id > 0) {
            _borrowerAppService.update(borrower).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _borrowerAppService.create(borrower).done(function () {
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