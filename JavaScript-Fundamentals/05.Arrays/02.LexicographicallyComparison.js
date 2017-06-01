function solve(args) {
    let firstArr = args[0];
    let secondArr = args[1];

    let firstArrLength = firstArr.length;
    let secondArrLength = secondArr.length;

    if (firstArrLength === secondArrLength) {
        for (let i = 0; i < firstArrLength; i += 1) {
            if (firstArr[i] > secondArr[i]) {
                return '>';
            }
            if (firstArr[i] < secondArr[i]) {
                return '<';
            }
        }
        return '=';
    } else {
        let smallest = 0;
        if (firstArrLength > secondArrLength) {
            smallest = secondArrLength;
        } else {
            smallest = firstArrLength;
        }
        for (let i = 0; i < smallest; i += 1) {
            if (firstArr[i] < secondArr[i]) {
                return '<';
            }
            if (firstArr[i] > secondArr[i]) {
                return '>';
            }
        }
        if (firstArrLength > secondArrLength) {
            return '>';
        }
        if (firstArrLength < secondArrLength) {
            return '<';
        }
    }
}
solve(['hello', 'halo']);