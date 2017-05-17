function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    let discriminant = Math.pow(b, 2) - 4 * a * c;
    let x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
    let x2 = (-b - Math.sqrt(discriminant)) / (2 * a);

    if (discriminant < 0) {
        console.log('no real roots');
    } else if (discriminant === 0) {
        console.log('x1=x2=' + x1.toFixed(2));
    } else if (discriminant > 0) {
        if (x1 < x2) {
            console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
        } else {
            console.log('x1=' + x2.toFixed(2) + '; x2=' + x1.toFixed(2));
        }
    }
}
solve(['0.2', '9.572', '0.2']);