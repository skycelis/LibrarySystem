(function ($) {

    $(document).on('click', '.delete-dept', function () {
        var deptId = $(this).attr("data-dept-id");
        var deptName = $(this).attr("data-dept-name");

        deleteDept(deptId, deptName);
    });
    function deleteDept(deptId, deptName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureYouWantToDelete'),
                username),
            null,
            (isConfirmed) => {
                if (isConfirmed) { }
            }
    }
        );
}
}) (jQuery);