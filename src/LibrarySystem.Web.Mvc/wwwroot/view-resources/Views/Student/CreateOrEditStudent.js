(function ($) {
    var _$form = $('form[name=CreateStudentForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _studentAppService = abp.services.app.student;

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var student = _$form.serializeFormToObject();
        abp.ui.setBusy(_$form);
        if (student.Id > 0) {
            _studentAppService.update(student).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = "/Students";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _studentAppService.create(student).done(function () {
                window.location.href = "/Students";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        }

    }

    function cancel() {
        window.location.href = "/Students";
    }

    _$form.find('.save-button').click(function (e) {
        e.preventDefault();
        save();
    });

    _$form.find('.cancel-button').click(function (e) {
        e.preventDefault();
        cancel();
    });

})(jQuery);