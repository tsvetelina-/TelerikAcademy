function solve() {
    let integer = 45,
        floatingPoint = 3.1415,
        booleanType = true,
        string = 'this is of type string',
        char = 'a';

    // console.log(typeof(integer));
    // console.log(typeof(floatingPoint));
    // console.log(typeof(booleanType));
    // console.log(typeof(string));
    // console.log(typeof(char));

    let variables = [
        45,
        3.1415,
        true,
        'this is of type string',
        'a'
    ];
    for (let i = 0; i < variables.length; i += 1) {
        console.log(typeof(variables[i]));
    }
}
solve();