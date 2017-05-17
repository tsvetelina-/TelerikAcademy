function solve(args) {
    let a = args[0];
    let b = args[1];
    let c = args[2];

    if (a * b * c > 0) {
        console.log('+');
    } else if (a * b * c === 0) {
        console.log('0');
    } else {
        console.log('-');
    }
}
solve(['-2', '-2', '1']);