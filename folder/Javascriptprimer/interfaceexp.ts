interface Iperson{
    firstname:string;
    lastname:string;
    GetFullName():string;
}
class person implements Iperson{
    firstname: string; 
    lastname: string;
    GetFullName(): string 
    {
        return(this.firstname+ ' ' +this.lastname);
    }


}
let obj2:person=new person();
obj2.firstname="gurram";
obj2.lastname="roshini";
let result:string=obj2.GetFullName();
console.log(result);