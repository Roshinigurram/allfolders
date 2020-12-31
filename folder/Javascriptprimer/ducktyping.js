var person2 = /** @class */ (function () {
    function person2() {
    }
    person2.prototype.getFullName = function () {
        return this.firstName + ' ' + this.lastName;
    };
    return person2;
}());
var objnew = new person2();
var someObj = {
    firstName: 'first',
    lastName: "last",
    getFullName: function () { return 'first' + '' + "last"; }
};
objnew = someObj;
//console.log(objnew);
someObj.firstName;
someObj.lastName;
var resultsome = someObj.getFullName();
console.log(resultsome);
