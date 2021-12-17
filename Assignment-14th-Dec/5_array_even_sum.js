var arrEvenSum = function (arr) {
    var evenNo = 0;
    for (var i = 0; i < arr.length; i++)
        if (arr[i] % 2 == 0)
            evenNo = evenNo + arr[i];
    console.log("Sum of elements which are even: " + evenNo);
};
var arr = [1, 2, 4, 5, 3];
arrEvenSum(arr);
