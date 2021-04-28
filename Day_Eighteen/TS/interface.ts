interface IPerson {  
    firstName:string,  
    lastName:string,  
    sayHi: ()=>string  
 }  
  
 var customer:IPerson = {  
    firstName:"Tom", 
    lastName:"Hanks",  
    sayHi: ():string =>{return "Hi there"}  
 }  
  
 console.log("Customer Object ")  
 console.log(customer.firstName)  
 console.log(customer.lastName)  
 console.log(customer.sayHi()) 