var str = '1'  
var str2:number = <number><any>str   //str is now of type number  
console.log(str2)


var empLCode: any = 111;   
var employeCode = <number> empLCode;   
console.log(typeof(employeCode)); //Output: number  


var str = '1'  
//var str2:number = <number><any>str   //str is now of type number  
console.log(str)

var stri = 1 ;
//var str2:number = <number><any>str   //str is now of type number  
console.log(stri)
