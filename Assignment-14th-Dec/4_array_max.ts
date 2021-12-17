const maxArray = (arr: number[]) => {
    var max: number = arr[0];

    for (let i = 0; i < arr.length; i++)
        if (arr[i] > max)
            max = arr[i];
    console.log("Max element from array ["+arr+"] is: "+max);
    
}
var arr = [1, 2, 3, 5, 7];
maxArray(arr);