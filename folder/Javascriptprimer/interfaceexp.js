var person = /** @class */ (function () {
    function person() {
    }
    person.prototype.GetFullName = function () {
        return (this.firstname + '' + this.lastname);
    };
    return person;
}());
var obj2 = new person();
obj2.firstname = "gurram";
obj2.lastname = "roshini";
var result = obj2.GetFullName();
console.log(result);
