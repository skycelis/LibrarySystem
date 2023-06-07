(function ($) {
    var _$form = $('form[name=CreateBookCategoryForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _bookcategoryAppService = abp.services.app.bookCategory;
    var _indexPage = "/BookCategories";

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var bookcategory = _$form.serializeFormToObject();
        bookcategory.DepartmentId = parseInt(bookcategory.DepartmentId);
        if (bookcategory.Id != 0) {
            _bookcategoryAppService.update(bookcategory).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _bookcategoryAppService.create(bookcategory).done(function () {
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