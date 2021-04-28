// interface namelist {  
//     [index:number]:string  
//  }  
  
//  //var list2:namelist = ["John",1,"Bran"] //Error. 1 is not type string   
interface ages {  
     [index:string]:number  
     }  
  
 var agelist:ages;  
agelist={"John":15}   // Ok  
 console.log( agelist["John"])
 //agelist[2] = "nine"   // Error
