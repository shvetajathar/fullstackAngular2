class Person
{
    private name:string
    private age:number
    public constructor(name:string,age:number)
    {
        this.name=name
        this.age=age
    }
    public getName():string{
        return this.name
    }
    public getAge():number{
        return this.age
    }
}
var person=new Person('Tom',33)
console.log(person.getName())
console.log(person.getAge())