class Department
{
    id:number;
    name:string;
    location:string;
    constructor(deptNo, deptName, deptLoc) 
    {
        this.id = deptNo;
        this.name = deptName;
        this.location = deptLoc;
    }
    Display = ()=>
        console.log('Department details are:\nDepartment number: ' + this.id +
            'Department name: ' + this.name + '\nDepartment location: ' + this.location);
    
  
}
var obj:Department= new Department(10, 'Accounting', 'New York');
obj.Display();


