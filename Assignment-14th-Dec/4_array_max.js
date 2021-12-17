var maxArray = function (arr) {
    var max = arr[0];
    for (var i = 0; i < arr.length; i++)
        if (arr[i] > max)
            max = arr[i];
    console.log("Max element from array [" + arr + "] is: " + max);
};
var arr = [1, 2, 3, 5, 7];
maxArray(arr);
