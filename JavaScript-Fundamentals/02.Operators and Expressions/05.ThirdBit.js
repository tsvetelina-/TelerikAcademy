function solve(args) {

    let number = args;

    var mask = 1 << 3;
    var nAndMask = number & mask;
    var bit = nAndMask >> 3;

    console.log(bit);
}
solve(['15']);