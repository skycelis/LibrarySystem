(function ($) {
    var _$form = $('form[name=CreateAuthorForm]');
    l = abp.localization.getSource('LibrarySystem');
<<<<<<< HEAD
    var _authorAppService = abp.services.app.author;
=======
    var _authorappService = abp.services.app.author;
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
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
<<<<<<< HEAD
            _authorAppService.create(author).done(function () {
=======
            _authorappService.create(author).done(function () {
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
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