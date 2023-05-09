(function ($) {
    var _$form = $('form[name=CreateDepartmentForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _departmentAppService = abp.services.app.department;

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var department = _$form.serializeFormToObject();
        abp.ui.setBusy(_$form);
        if (department.Id > 0) {
            _departmentAppService.update(department).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = "/Departments";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _departmentAppService.create(department).done(function () {
                window.location.href = "/Departments";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        }

    }

    function cancel() {
        window.location.href = "/Departments";
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