var global_num = 12; //global variable  
var Numbers = /** @class */ (function () {
    function Numbers() {
        this.num_val = 13; //class variable  or field
    }
    Numbers.prototype.storeNum = function () {
        var local_num = 14; //local variable  
    };
    Numbers.sval = 10; //static field  
    return Numbers;
}());
console.log("Global Num: " + global_num);
console.log(Numbers.sval); //static variable   
var obj = new Numbers();
console.log("Class  Field: " + obj.num_val);
