class Employee1
{
    id:number;
    name:string;
    salary:number;
    

    constructor(empNo, empName,empSalary) 
    {
        this.id = empNo;
        this.name = empName;
        this.salary= empSalary;

    }
    Display = ()=>{
        console.log('Department details are:\nDepartment number: ' + this.id +
            'Department name: ' + this.name + '\nDepartment location: ' + this.salary);
    };
  
}
let obj5:Employee1= new Employee1(112, 'roshini', 12000);
obj5.Display();


