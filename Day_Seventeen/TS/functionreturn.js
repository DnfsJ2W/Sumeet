//function defined  
function greet() {
    return "Hello World";
}
function caller() {
    var msg = greet(); //function greet() invoked  
    console.log(msg);
}
//invoke function  
caller();
