function solve(args) {
    let len = args.length;

    let min = +args[0];
    let max = +args[0];
    let sum = 0;
    let avg = 0;

    for (let i = 0; i < len; i += 1) {
        if (+args[i] < min) {
            min = +args[i];
        }
        if (+args[i] > max) {
            max = +args[i];
        }

        sum += +args[i];
    }

    avg = sum / len;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}
solve(['2', '5', '1']);