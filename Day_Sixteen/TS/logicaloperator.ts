var avg:number = 20; 
var percentage:number = 90; 

console.log("Value of avg: "+avg+" ,value of percentage: "+percentage);
 {
    let res:boolean=true;
     res = ((avg>50)&&(percentage>80)); 
console.log("(avg>50)&&(percentage>80): "+res);

res = ((avg>50)||(percentage>80)); 
console.log("(avg>50)||(percentage>80): "+res);

res=!((avg>50)&&(percentage>80)); 
console.log("!((avg>50)&&(percentage>80)): "+res);
 }