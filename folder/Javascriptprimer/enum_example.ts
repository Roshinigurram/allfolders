enum DaysOfWeek {
    sunday=1,
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday
};
let day: DaysOfWeek;
day=DaysOfWeek.friday;
console.log(day);
let today=new Date().getDay();
console.log(today);
