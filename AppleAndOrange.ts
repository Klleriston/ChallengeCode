function countApplesAndOranges(s: number, t: number, a: number, b: number, apples: number[], oranges: number[]): void {
    let orangeCount: number = 0;
    let appleCount: number = 0;
    
     for (let i = 0; i < apples.length; i++) {
        if (a + apples[i] >= s && a + apples[i] <= t) {
            appleCount++;
        }
    }
    
    for (let j = 0; j < oranges.length; j++) {
        if (b + oranges[j] >= s && b + oranges[j] <= t) {
            orangeCount++;
        }
    }
    
    console.log(appleCount)
    console.log(orangeCount)
}
