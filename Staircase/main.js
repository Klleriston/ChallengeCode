function staircase(n){
    for (let i=1;i<=n;i++){
        let stair = '';
        for (let s=0;s<n - i;s++){
            stair = '';
        }
        for (let h=0;h<i;h++){
            stair +="#"
        }
        console.log(stair)
    }
}
let n = 6
staircase(n)