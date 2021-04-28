var car = /** @class */ (function () {
    function car(model) {
        this.model = model;
    }
    return car;
}());
var carobj = new car('Honda');
console.log(carobj instanceof car);
