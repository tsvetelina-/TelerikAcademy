function solve(args) {
    let width = +args[0];
    let height = +args[1];

    let area = width * height;
    let perimeter = width * 2 + height * 2;

    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}
solve(['2.5', '3']);