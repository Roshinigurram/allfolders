var Employee1 = /** @class */ (function () {
    function Employee1(empNo, empName, empSalary) {
        var _this = this;
        this.Display = function () {
            console.log('Department details are:\nDepartment number: ' + _this.id +
                'Department name: ' + _this.name + '\nDepartment location: ' + _this.salary);
        };
        this.id = empNo;
        this.name = empName;
        this.salary = empSalary;
    }
    return Employee1;
}());
var obj5 = new Employee1(112, 'roshini', 12000);
obj5.Display();
