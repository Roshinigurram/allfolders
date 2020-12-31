//task1 using function
/*function MyFunction()
 {
     console.log("this is first program");
 }
 //task1 using fat arrow
 MyFunction();
 var MyFunction1=()=>
 {
     console.log("this is first in type arrow");
 };
 MyFunction1();
 //task2 addition
 var num1=20;
 var num2:number=10;
 var diff=num1-num2;
 console.log("the diff is" +diff);
// //task3 product


function multiply(num3,num4)
 {
     return num3*num4;
}
 var result=multiply(20,40)
 console.log("the product is" +result);
//task4
function datenew(date1,date2)
{
var res=Math.abs(date1-date2);
return res/(1000*60*60*24);
}
var date1 = new Date('11/24/2020');
var date2 = new Date('11/23/2020');
console.log(datenew(date1,date2));*/
//task5
function Department(deptNo, deptName, deptLoc) {
    var id;
    var name;
    var location;
}
var Display = function () {
    console.log('Department details are:\nDepartment number: ' + id +
        'Department name: ' + name + '\nDepartment location: ' + location);
};
Department(10, 'Accounting', 'New York');
Display();
