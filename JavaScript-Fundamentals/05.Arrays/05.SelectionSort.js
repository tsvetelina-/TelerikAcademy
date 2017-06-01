function solve(args) {
    let minNumber = Math.min(),
        n = args.length;


    for (let i = 0; i < n - 1; i += 1) {
        for (let j = i + 1; j < n; j += 1) {
            if (+args[i] > +args[j]) {
                minNumber = args[j];
                args[j] = args[i];
                args[i] = minNumber;
            }
        }
    }

    for (let i = 0; i < n; i += 1) {
        let temp = args[i];
        for (let j = i + 1; j < n; j += 1) {
            if (temp === args[j]) {
                args.splice(j, 1);
                j -= 1;
            }
        }
    }

    for (i = 0; i < n; i += 1) {
        console.log(args[i]);
    }
}
solve(['6', '3', '4', '1', '5', '2', '6']);