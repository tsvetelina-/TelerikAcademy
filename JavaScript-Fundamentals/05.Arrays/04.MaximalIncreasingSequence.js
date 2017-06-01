function solve(args) {
    let len = args.length,
        count = 1,
        maxCount = 0;

    for (let i = 1; i < len - 1; i += 1) {
        if (+args[i] < +args[i + 1]) {
            count += 1;
        } else {
            if (maxCount < count) {
                maxCount = count;
            }
            count = 1;
        }
    }
    if (maxCount < count) {
        maxCount = count;
    }

    console.log(maxCount);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);