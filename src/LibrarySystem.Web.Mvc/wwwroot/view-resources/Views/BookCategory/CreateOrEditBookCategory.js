(function ($) {
    var _$form = $('form[name=CreateBookCategoryForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookcategoryAppService = abp.services.app.bookcategory;

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var bookcategory = _$form.serializeFormToObject();
        abp.ui.setBusy(_$form);
        if (bookcategory.Id > 0) {
            _bookcategoryAppService.update(bookcategory).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = "/BookCategories";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _bookcategoryAppService.create(bookcategory).done(function () {
                window.location.href = "/BookCategories";
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        }

    }

    function cancel() {
        window.location.href = "/BookCategories";
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