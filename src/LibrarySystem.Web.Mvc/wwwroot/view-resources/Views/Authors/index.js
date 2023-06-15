(function ($) {
    var _$form = $('#CreateAuthorForm');
    var _authorappService = abp.services.app.author;
    l = abp.localization.getSource('LibrarySystem'),
        _$table = $('#AuthorsTable');
    var _indexPage = "/Authors";

    var _$authorsTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        listAction: {
            ajaxFunction: _authorappService.getAll,
            inputFilter: function () {
                return $('#authorSearchForm').serializeFormToObject(true);
            }
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$authorsTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                data: 'id',
                sortable: false
            },
            {
                targets: 1,
                data: 'name',
                sortable: false
            },
            {
                targets: 2,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-dark btn-rounded edit-author" data-author-id="${row.id}">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-danger delete-author" data-author-id="${row.id}" data-author-name="${row.name}">`,
                        `       <i class="fas fa-trash"></i> ${l('')}`,
                        '   </button>'
                    ].join('');
                }
            }
        ]

    })
    $('.search-button').on('click', (e) => {
        _$authorsTable.ajax.reload();
    });


    $('.txt-search').on('keypress', (e) => {
        if (e.which == 13) {
            _$authorsTable.ajax.reload();
            return false;
        }
    });

    $(document).on('click', '.edit-author', function (e) {
        var authorId = parseInt($(this).attr("data-author-id"));

        e.preventDefault();
        window.location.href = "/Authors/CreateAuthor/" + authorId;
    });


    $(document).on('click', '.delete-author', function () {
        var authorId = parseInt($(this).attr("data-author-id"));
        var authorName = $(this).attr("data-author-name");

        deleteAuthor(authorId, authorName);
    });

    function deleteAuthor(authorId, authorName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                    authorName
                )),
            null,
            function (isConfirmed) {
                if (isConfirmed) {
                    if (authorId > 0) {
                        _authorappService.delete({
                            id: authorId
                        })
                            .done(function () {
                                abp.notify.info(l('SuccessfullyDeleted'));
                                location.reload(true);
                            });
                    }
                }
            }
        );
    }

})(jQuery);