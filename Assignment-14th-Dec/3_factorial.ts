const fact = (n: number) => {
  var fact = 1;
  //Using for loop
  // for (let i = 1; i <= n; i++){
  //     fact = fact * i;
  // }

  //Using while loop
  var i = 1;
  while (i <= n) {
    fact = fact * i;
    i++;
  }

  return fact;
};
console.log("[>]Factorial is: " + fact(5));
