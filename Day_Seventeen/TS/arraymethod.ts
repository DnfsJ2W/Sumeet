//concat method
var alpha = ["a", "b", "c"]; 
var numericarray:any[] = [1, 2, 3];

var alphaNumeric = alpha.concat(numericarray); 
console.log("alphaNumeric : " + alphaNumeric );




//filter method
function isBigEnough(element, index, array) { 
    return (element >= 10); 
 } 
           
 var passed = [12, 5, 8, 130, 44].filter(isBigEnough); 
 console.log("Test Value : " + passed );



 //forEach method
 let num = [7, 8, 9];
num.forEach(function (value) {
  console.log(value);
}); 


//join method
var arrex = new Array("First","Second","Third"); 
          
var strex = arrex.join(); 
console.log("str : " + strex );  
          
var strex = arrex.join(", "); 
console.log("str : " + strex );  
          
var strex = arrex.join(" + "); 
console.log("str : " + strex );

//map method
var numbers = [1, 4, 9]; 
var roots = numbers.map(Math.sqrt); 
console.log("roots is : " + roots );

//pop method
var numbers = [1, 4, 9]; 
          
var element = numbers.pop(); 
console.log("element is : " + element );  
          
var element = numbers.pop(); 
console.log("element is : " + element );


//push method
var numbers = new Array(1, 4, 9); 
var length = numbers.push(10); 
console.log("new numbers is : " + numbers );  
length = numbers.push(20); 
console.log("new numbers is : " + numbers );

//reverse method
var arr = [0, 1, 2, 3].reverse(); 
console.log("Reversed array is : " + arr );

//unshift method
var arrunshift = new Array("orange", "mango", "banana", "sugar"); 
var length = arrunshift.unshift("water"); 
console.log("Returned array is : " + arrunshift );
console.log("Length of the array is : " + length );


//splice method
var arrsplice = ["orange", "mango", "banana", "sugar", "tea"];  
var removed = arrsplice.splice(2, 0, "water");  
console.log("After adding 1: " + arrsplice );  
console.log("removed is: " + removed); 
          
removed = arrsplice.splice(3, 1);  
console.log("After removing 1: " + arrsplice );  
console.log("removed is: " + removed);


//slice method
var arrslice = ["orange", "mango", "banana", "sugar", "tea"]; 
console.log("arrslice.slice( 1, 2) : " + arrslice.slice( 1, 2) );  
console.log("arrslice.slice( 1, 3) : " + arrslice.slice( 1, 3) );


//shift method
var arrshift = [10, 1, 2, 3].shift(); 
console.log("Shifted value is : " + arrshift);