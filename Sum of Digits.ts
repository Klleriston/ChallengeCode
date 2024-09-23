function digitalRoot(n: number): any {
  while (n >= 10) {
    let sum = 0;
    let numberToArray = n.toString();
    for (let i = 0; i < numberToArray.length; i++) {
      sum += Number(numberToArray.charAt(i));
    }
    n = sum;
  }
  return n;
}

console.log(digitalRoot(16)); // 7
console.log(digitalRoot(942)); // 6
console.log(digitalRoot(132189)); //6
console.log(digitalRoot(493193)); // 2

/*
    16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
*/
