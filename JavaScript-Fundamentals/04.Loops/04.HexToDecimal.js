function solve(args) {
    let hexNum = args[0],
        decNum = 0,
        pow = hexNum.length - 1;

    for (let i = 0; i < number.length; i += 1) {
        let digit = 0;

        switch (hexNum[i]) {
            case '0':
                digit = 0;
                break;
            case '1':
                digit = 1;
                break;
            case '2':
                digit = 2;
                break;
            case '3':
                digit = 3;
                break;
            case '4':
                digit = 4;
                break;
            case '5':
                digit = 5;
                break;
            case '6':
                digit = 6;
                break;
            case '7':
                digit = 7;
                break;
            case '8':
                digit = 8;
                break;
            case '9':
                digit = 9;
                break;
            case 'A':
                digit = 10;
                break;
            case 'B':
                digit = 11;
                break;
            case 'C':
                digit = 12;
                break;
            case 'D':
                digit = 13;
                break;
            case 'E':
                digit = 14;
                break;
            case 'F':
                digit = 15;
                break;
        }

        let decNum = digit * Math.pow(16, pow);
        pow--;
    }

    return decNum;
}
solve(['FE']);



// function hexToDec(hex) {
//     var result = 0,
//         digitValue;
//     hex = hex.toLowerCase();
//     for (var i = 0; i < hex.length; i++) {
//         digitValue = '0123456789abcdef'.indexOf(hex[i]);
//         result = result * 16 + digitValue;
//     }
//     return result;
// }
// console.log(hexToDec('FE'));