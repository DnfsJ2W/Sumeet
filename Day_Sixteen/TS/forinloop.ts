var j:any;  
var n:any = "abc"  
 
for(j in n) { 
   console.log(n[j])   
}
for (j of n)
{
    console.log(j)
}
