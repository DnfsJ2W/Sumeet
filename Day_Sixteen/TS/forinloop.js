var j;
var n = "abc";
for (j in n) {
    console.log(n[j]);
}
for (var _i = 0, n_1 = n; _i < n_1.length; _i++) {
    j = n_1[_i];
    console.log(j);
}
var fruits = ["Apple", "Orange", "Kiwi", "Banana"];
for (j in fruits) {
    console.log(fruits[j]);
}
for (var _a = 0, fruits_1 = fruits; _a < fruits_1.length; _a++) {
    var fruit = fruits_1[_a];
    console.log(fruit);
}
