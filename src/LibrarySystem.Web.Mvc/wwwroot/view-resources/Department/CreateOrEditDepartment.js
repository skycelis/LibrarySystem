(function ($) {
    var $form = $('#CreateDepartmentForm');
    var _departmentAppService = abp.services.app.department;

    function save() {
        if (!_$form.valid()) {
            return;
        }
        var
    };


    _$form.find('.save-button').on('click', (e) => {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }


    });

})(jQuery);