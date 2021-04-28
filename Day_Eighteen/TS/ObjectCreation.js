var Greeting = /** @class */ (function () {
    function Greeting() {
    }
    Greeting.prototype.greet = function () {
        console.log("hello");
    };
    return Greeting;
}());
var greetobj = new Greeting();
greetobj.greet();
