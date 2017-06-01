function solve(args) {
    let n = +args[0];

    // arr contains list of all numbers
    let arr = [];
    let max = Number.NEGATIVE_INFINITY;
    let temp;
    let num = 0;

    // init arr with zero
    for (let i = 1; i <= n; i += 1) {
        arr[+args[i]] = 0;
    }

    // action
    for (let i = 1; i <= n; i += 1) {

        temp = (arr[+args[i]] += 1);

        if (max < temp) {
            max = temp;
            num = +args[i];
        }
    }

    console.log(num + ' (' + max + ' times)');
}
solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);