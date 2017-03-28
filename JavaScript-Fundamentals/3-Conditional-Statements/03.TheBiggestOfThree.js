function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    if (a >= b && a >= c) {
        console.log(a);
    } else if (b >= a && b >= c) {
        console.log(b);
    } else if (c >= a && c >= b) {
        console.log(c);
    }
}
solve(['3', '8', '2']);