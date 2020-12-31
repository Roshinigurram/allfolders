var DaysOfWeek;
(function (DaysOfWeek) {
    DaysOfWeek[DaysOfWeek["sunday"] = 1] = "sunday";
    DaysOfWeek[DaysOfWeek["monday"] = 2] = "monday";
    DaysOfWeek[DaysOfWeek["tuesday"] = 3] = "tuesday";
    DaysOfWeek[DaysOfWeek["wednesday"] = 4] = "wednesday";
    DaysOfWeek[DaysOfWeek["thursday"] = 5] = "thursday";
    DaysOfWeek[DaysOfWeek["friday"] = 6] = "friday";
    DaysOfWeek[DaysOfWeek["saturday"] = 7] = "saturday";
})(DaysOfWeek || (DaysOfWeek = {}));
;
var day;
day = DaysOfWeek.friday;
console.log(day);
var today = new Date().getDay();
console.log(today);
