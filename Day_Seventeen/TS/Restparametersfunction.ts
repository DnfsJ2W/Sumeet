function addNumbers(...nums:number[]) {   
    var i;    
    var sum:number = 0;  
     
    for(i = 0;i<nums.length;i++) {  
       sum = sum + nums[i];  
    }  
    console.log("sum of the numbers",sum)  
 }  
 addNumbers(1,2,3)  
 addNumbers(10,10,10,10,10) 
 function addNumbe(a?:number,b?:number,c?:number) {   
   

   
    
     
   console.log("sum of the numbers",a+b+c)  
}  
var arrnum:number[]=[1,2,3,4,5];
 addNumbe(...arrnum);