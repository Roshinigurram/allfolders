var person1 = /** @class */ (function () {
    function person1() {
    }
    person1.prototype.getFirstName = function () {
        return this.firstname;
    };
    person1.prototype.setFirstName = function (val) {
        this.firstname = val;
    };
    person1.prototype.getLastName = function () {
        return this.lastname;
    };
    person1.prototype.setLastName = function (val) {
        this.lastname = val;
    };
    person1.prototype.GetFullName = function () {
        return (this.firstname + ' ' + this.lastname);
    };
    return person1;
}());
var obj3 = new person1();
obj3.setFirstName('roshini');
obj3.setLastName('gurram');
var resultnew = obj3.GetFullName();
console.log(resultnew);
