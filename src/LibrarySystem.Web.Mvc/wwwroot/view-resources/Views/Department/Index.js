(function ($) {
    var _$form = $('form[name=CreateDepartmentForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _departmentAppService = abp.services.app.department;


    $(document).on('click', '.edit-dept', function (e) {
        var departmentId = parseInt($(this).attr("data-dept-id"));
        
        e.preventDefault();
        window.location.href = "/Departments/CreateDepartment/" + departmentId;
    });


    $(document).on('click', '.delete-dept', function () {
        var departmentId = parseInt($(this).attr("data-dept-id"));
        var departmentName = $(this).attr("data-dept-name");

        deleteDept(departmentId, departmentName);
    });

    function deleteDept(departmentId, departmentName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                departmentName
            )),
            null,
            function(isConfirmed) {
                if (isConfirmed) {
                    if (departmentId > 0) {
                        _departmentAppService.delete({
                                id: departmentId
                            })
                            .done(function() {
                                abp.notify.info(l('SuccessfullyDeleted'));
                            });
                    }
                }
            }
        );
    }

}) (jQuery);