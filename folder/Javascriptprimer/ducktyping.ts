class person2
{
    firstName:string;
    lastName:string;
    getFullName():string{
        return this.firstName+ ' ' +this.lastName;
    }
}
let objnew=new person2();

let someObj={
     firstName:'first',
     lastName:"last",
     getFullName:()=>'first' + '' +"last"
}
objnew=someObj;

someObj.firstName;
 someObj.lastName;
 let resultsome:string=someObj.getFullName();
 console.log(resultsome);
