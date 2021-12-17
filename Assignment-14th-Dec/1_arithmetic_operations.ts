const operation = (a: number, b: number, op: string) => {
  if (op.charAt(0) == "+") {
    return a + b;
  } else if (op.charAt(0) == "-") {
    return a - b;
  } else if (op.charAt(0) == "*") {
    return a * b;
  } else if (op.charAt(0) == "/") {
    return a / b;
  } else {
    return "Operator Invalid";
  }
};

console.log("-----------------------------------------");

console.log("Arithmetic Operations");

console.log("-----------------------------------------");

console.log("[>] Addition: " + operation(1, 2, "+"));
console.log("[>] Subtraction: " + operation(10, 2, "-"));
console.log("[>] Multiplication: " + operation(111, 8, "/"));
console.log("[>] Division: " + operation(1, 2, "/"));
console.log("-----------------------------------------");
