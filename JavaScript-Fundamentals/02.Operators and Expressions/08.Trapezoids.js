function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let h = +args[2];

    let area = ((a + b) / 2) * h;

    console.log(area.toFixed(7));
}
solve(['5', '7', '12']);