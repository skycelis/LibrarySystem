﻿(function ($) {
    var _$form = $('form[name=CreateStudentForm]');
    l = abp.localization.getSource('LibrarySystem');
    var _studentAppService = abp.services.app.student;


    $(document).on('click', '.edit-student', function (e) {
        var studentId = parseInt($(this).attr("data-student-id"));

        e.preventDefault();
        window.location.href = "/Students/CreateStudent/" + studentId;
    });


    $(document).on('click', '.delete-student', function () {
        var studentId = parseInt($(this).attr("data-student-id"));
        var studentStudentName = $(this).attr("data-student-name");

        deleteStudent(studentId, studentStudentName);
    });

    function deleteStudent(studentId, studentStudentName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete',
                    studentStudentName
                )),
            null,
            function (isConfirmed) {
                if (isConfirmed) {
                    if (studentId > 0) {
                        _studentAppService.delete({
                            id: studentId
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