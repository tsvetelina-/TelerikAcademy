function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let d = +args[3];
    let e = +args[4];

    if (a >= b && a >= c && a >= d && a >= e) {
        console.log(a);
    } else if (b >= a && b >= c && b >= d && b >= e) {
        console.log(b);
    } else if (c >= a && c >= b && c >= d && c >= e) {
        console.log(c);
    } else if (d >= a && d >= b && d >= c && d >= e) {
        console.log(d);
    } else {
        console.log(e);
    }

}
solve(['5', '2', '2', '4', '1']);