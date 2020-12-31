
class person1
{
    private firstname: string; 
    private lastname: string;
    getFirstName():string{
        return this.firstname;
    }
    setFirstName(val:string)
    {
         this.firstname=val;
    }
    getLastName():string{
        return this.lastname;
    }
    setLastName(val:string)
    {
         this.lastname=val;
    }
    
    GetFullName(): string 
    {
        return(this.firstname+ ' ' +this.lastname);
    }


}
let obj3:person1=new person1();
obj3.setFirstName('roshini');
obj3.setLastName('gurram');
let resultnew:string=obj3.GetFullName();
console.log(resultnew);