function solve(args) {
    let a = Number(args[0]);
    let b = Number(args[1]);

    if (a > b) {
        console.log(b + ' ' + a);
    } else {
        console.log(a + ' ' + b);
    }
}
solve(['5', '2']);