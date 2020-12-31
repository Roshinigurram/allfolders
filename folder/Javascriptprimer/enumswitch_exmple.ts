enum DaysOfWeek {
    SUNDAY = 1,
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY
};
let today1= new Date().getDay() ;
console.log(today1)
switch (today1) {
    case DaysOfWeek.SUNDAY:
        console.log('Sunday');
        break;
    case DaysOfWeek.MONDAY:
        console.log('Monday');
        break;
    case DaysOfWeek.TUESDAY:
        console.log('Tuesday');
        break;
    case DaysOfWeek.WEDNESDAY:
        console.log('Wednesday');
        break
    default:
        break;
}
