let nums = [10, 9, 2, 5, 3, 7, 101, 18];

let LongestIncreasingSubsequence = (array) => {
    let referenceArray = new Array(array.length).fill(1);

    for (let i = 1; i < array.length; i++) {
        for (let j = 0; j < i; j++) {
            if (array[i] > array[j] && referenceArray[i] < referenceArray[j] + 1) {
                referenceArray[i] = referenceArray[j] + 1;
            }
        }
    }
    
    let longest = 0;
    for (let i = 0; i < referenceArray.length; i++) {
        if (referenceArray[i] > longest) {
            longest = referenceArray[i];
        }
    }

    return longest;
}

console.log(LongestIncreasingSubsequence(nums));
