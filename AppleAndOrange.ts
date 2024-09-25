function countApplesAndOranges(s: number, t: number, a: number, b: number, apples: number[], oranges: number[]): void {
    //laco iteracao pra s
    //laco iteracao pra t 
    
    //apples array adciona se >=s e <=t 
    //orange array adiciona se >=t e <=s 
    
    let orangeCount: number = 0;
    let appleCount: number = 0;
    
    for (let i = 0; i < apples.length; i++) {
         if(a + apples[i] >= s && a + apples[i] <= t){
            appleCount++;
        }
    }
    
    for (let j = 0; j < oranges.length; j++) {
        if (b + oranges[j] >= t && j + oranges[j] <= s) {
            orangeCount++
        }
    }
    
    console.log(appleCount)
    console.log(orangeCount)
}
