function solve(args) {
    let number = +args[0];

    for (let i = 1; i <= number; i += 1) {
        let result = '';
        for (let j = 1; j <= number; j += 1) {
            result += (i + j - 1) + ' ';
        }
        console.log(result);
    }

}
solve(['3']);