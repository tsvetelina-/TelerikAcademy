function solve(args) {
    let x = args[0];
    let y = args[1];
    let radius = 2;

    let distance = Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2));
    let isInCircle = Math.pow(x, 2) + Math.pow(y, 2) < Math.pow(radius, 2);

    if (isInCircle) {
        console.log("yes " + distance.toFixed(2));
    } else {
        console.log("no " + distance.toFixed(2));
    }
}
solve(['-1', '2']);