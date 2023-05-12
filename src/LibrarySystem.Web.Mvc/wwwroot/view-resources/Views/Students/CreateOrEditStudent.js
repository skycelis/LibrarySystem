(function ($) {
    var _$form = $('form[name=CreateStudentForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _studentAppService = abp.services.app.student;
    var _indexPage = "/Students";

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var student = _$form.serializeFormToObject();
        student.DepartmentId = parseInt(student.DepartmentId);
        abp.ui.setBusy(_$form);
        if (student.Id > 0) {
            _studentAppService.update(student).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _studentAppService.submit(student).done(function () {
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
    //function cancel() {
    //    window.location.href = "/Students";
    //}

    //_$form.find('.save-button').closest('div#container my-3').click(function (e) {
    //    e.preventDefault();
    //    save();
    //});

    //_$form.find('.cancel-button').closest('div#container my-3').click(function (e) {
    //    e.preventDefault();
    //    cancel();
    //});

})(jQuery);