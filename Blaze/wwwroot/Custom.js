function SetDropDown() {
    $('.ddlDepartment').select2();
    $('.ddlAttendees').select2();
    var hour = new Date().getHours().toString();
    console.log(hour);
   
    $('#startTime').timepicker({
        timeFormat: 'h:mm p',
        minTime: '09',
        maxTime: '11:00pm',
        defaultTime: hour,
        startTime: '09:00am',
        dynamic: true,
        dropdown: true,
        scrollbar: true,
        change: GetStartTime
    });
    $('#endTime').timepicker({
        timeFormat: 'h:mm p',
        minTime: '09',
        maxTime: '11:00pm',
        defaultTime: hour,
        startTime: '09:00am',
        dynamic: true,
        dropdown: true,
        scrollbar: true,
        change: GetEndTime
    });
}

function GetSelectedDepartments() {
    var getSelectDepartment = $(".ddlDepartment").val();
    DotNet.invokeMethodAsync('Blaze', 'GetDepartmentsSelected', getSelectDepartment);
}

function GetStartTime() {
    var getStartTime = $("#startTime").val();
    DotNet.invokeMethodAsync('Blaze', 'GetStartTime', getStartTime);
}
function GetEndTime() {
    var getEndTime = $("#endTime").val();
    DotNet.invokeMethodAsync('Blaze', 'GetEndTime', getEndTime);
}
function GetSelectedAttendees() {
    var getSelectAttendees = $(".ddlAttendees").val();
    DotNet.invokeMethodAsync('Blaze', 'GetAttendeesSelected', getSelectAttendees);
}
