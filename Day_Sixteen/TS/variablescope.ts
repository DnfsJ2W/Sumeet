var global_num = 12          //global variable  
class Numbers {  
   num_val = 13;             //class variable  or field
   static sval = 10;         //static field  
    
   storeNum():void {  
      var local_num = 14;    //local variable  
   }  
}  
console.log("Global Num: "+global_num)   
console.log(Numbers.sval)   //static variable   
var obj = new Numbers();  
console.log("Class  Field: "+obj.num_val)  
 