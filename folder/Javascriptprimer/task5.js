var Employee = /** @class */ (function () {
    function Employee(empNo, empName, empSalary) {
        var _this = this;
        this.Display = function () {
            console.log('Department details are:\nDepartment number: ' + _this.id +
                'Department name: ' + _this.name + '\nDepartment location: ' + _this.salary);
        };
        this.id = empNo;
        this.name = empName;
        this.salary = empSalary;
    }
    return Employee;
}());
var obj1 = new Employee(112, 'roshini', 12000);
obj1.Display();
