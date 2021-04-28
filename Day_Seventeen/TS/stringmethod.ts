//charAt method
var str = new String("This is string"); 
console.log("str.charAt(0) is:" + str.charAt(0)); 
console.log("str.charAt(1) is:" + str.charAt(1)); 
console.log("str.charAt(2) is:" + str.charAt(2)); 
console.log("str.charAt(3) is:" + str.charAt(3)); 
console.log("str.charAt(4) is:" + str.charAt(4)); 
console.log("str.charAt(5) is:" + str.charAt(5));


//concat method
var str1 = new String( "This is string one" ); 
var str2 = new String( "This is string two" ); 
var str3 = str1.concat(str2.toString());
console.log("str1 + str2 : "+str3)



//indexOf method
var str1 = new String( "This is string one" ); 
 
var index = str1.indexOf( "string" ); 
console.log("indexOf found String :" + index );   

var index = str1.indexOf( "one" ); 
console.log("indexOf found String :" + index );

//lastIndexOf method

var str1 = new String( "This is string one and again string" ); 
var index = str1.lastIndexOf( "string" );
console.log("lastIndexOf found String :" + index ); 
  
index = str1.lastIndexOf( "one" ); 
console.log("lastIndexOf found String :" + index );

//replace method
var re = /apples/gi; 
var strdata = "Apples are round, and apples are juicy.";
var newstr = strdata.replace(re, "oranges"); 
console.log(newstr)


var re = /(\w+)\s(\w+)/; 
var strda = "zara ali"; 
var newstr = strda.replace(re, "$2, $1"); 
console.log(newstr);

//search method
var re = /apples/gi; 
var strsearch = "Apples are round, and apples are juicy.";
if (strsearch.search(re) == -1 ) { 
   console.log("Does not contain Apples" ); 
} else { 
   console.log("Contains Apples" ); 
} 


//slice method
var stri = "Apples are round, and apples are juicy."; 
var sliced = stri.slice(3, -2); 
console.log(sliced);

//split method
var strsplit = "Apples are round, and apples are juicy."; 
var splitted = strsplit.split(" ", 3); 
console.log(splitted)

//substr method
var strsubstr = "Apples are round, and apples are juicy."; 
console.log("(1,2): "    + strsubstr.substr(1,2)); 
console.log("(-2,2): "   + strsubstr.substr(-2,2)); 
console.log("(1): "      + strsubstr.substr(1)); 
console.log("(-20, 2): " + strsubstr.substr(-20,2)); 
console.log("(20, 2): "  + strsubstr.substr(20,2));


//substring method
var strsubstring = "Apples are round, and apples are juicy."; 
console.log("(1,2): "    + strsubstring.substring(1,2)); 
console.log("(0,10): "   + strsubstring.substring(0, 10)); 
console.log("(5): "      + strsubstring.substring(5));


//toLowerCase method
var strlower = "Apples are round, and Apples are Juicy."; 
console.log(strlower.toLowerCase( ))

//toUpperCase method
var strupper = "Apples are round, and Apples are Juicy."; 
console.log(strupper.toUpperCase( ));

//toString method
var strin = "Apples are round, and Apples are Juicy."; 
console.log(strin.toString( ));

//valueOf method
var str = new String("Hello world"); 
console.log(str.valueOf( ));
