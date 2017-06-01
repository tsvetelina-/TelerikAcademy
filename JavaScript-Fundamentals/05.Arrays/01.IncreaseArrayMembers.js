function solve(args) {
    let number = +args[0];

    for (let i = 0; i < number; i += 1) {
        console.log(i * 5);
    }
}
solve(['5']);