var Calulation = /** @class */ (function () {
    function Calulation() {
    }
    Calulation.prototype.add = function (a, b) {
        return a + b;
    };
    return Calulation;
}());
var obj = new Calulation();
var number = obj.add(10, 2);
console.log(number);
