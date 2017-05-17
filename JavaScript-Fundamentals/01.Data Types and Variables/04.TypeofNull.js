function solve() {
    let nullType = null,
        undefinedType;

    // console.log(typeof(nullType));
    // console.log(typeof(undefinedType));

    let variables = [
        null,
        undefinedType
    ];
    for (let i = 0; i < variables.length; i += 1) {
        console.log(typeof(variables[i]));
    }
}
solve();