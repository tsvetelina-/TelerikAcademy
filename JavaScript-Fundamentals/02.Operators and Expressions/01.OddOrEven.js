function solve(args) {
    let number = args[0];

    if (number % 2 !== 0) {
        console.log('odd ' + number);
    }
    if (number % 2 === 0) {
        console.log('even ' + number);
    }
}
solve(['2']);