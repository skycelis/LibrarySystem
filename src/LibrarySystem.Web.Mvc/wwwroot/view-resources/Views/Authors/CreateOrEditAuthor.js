(function ($) {
    var _$form = $('form[name=CreateAuthorForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _authorAppService = abp.services.app.author;
    var _indexPage = "/Authors";

    function save() {
        if (!_$form.valid()) {
            return;
        }

        var author = _$form.serializeFormToObject();
        author.BookId = parseInt(author.BookId);
        if (author.Id != 0) {
            _authorAppService.update(author).done(function () {
                abp.notify.info(l('UpdatedSuccessfully'));
                window.location.href = _indexPage;
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        } else {
            _authorAppService.create(author).done(function () {
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