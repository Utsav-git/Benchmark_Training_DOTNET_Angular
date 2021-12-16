var arr = [1, 2, 3, 4, 5];

console.log("--------------------------------");
console.log("[>] Array Elements: [" + arr+"]");
console.log("--------------------------------");
for (let i = 0; i < arr.length; i++){
    if (arr[i] % 2 == 0) {
        arr[i] = arr[i] * arr[i];
    } else if (arr[i] % 2 != 0) {
        arr[i] = arr[i] * arr[i] * arr[i];

    }
}
console.log("[>] Array with square and cube: [" + arr+"]");
console.log("--------------------------------");
