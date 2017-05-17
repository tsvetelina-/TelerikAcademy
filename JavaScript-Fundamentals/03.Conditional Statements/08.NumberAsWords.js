function solve(args) {
    let number = +args[0];
    let result = '';
    let onesLow = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
    let onesUp = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
    let tensLow = ['', 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety', ];
    let tensUp = ['', 'Ten', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety', ];
    let teensLow = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
    let teensUp = ['Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];

    let hundreds = number / 100 | 0;
    let tens = (number / 10) % 10 | 0;
    let ones = number % 10;

    if (hundreds === 0 && tens === 0) {
        result = onesUp[ones];
    } else if (hundreds === 0) {
        if (tens === 1) {
            result = teensUp[ones];
        } else {
            if (ones === 0) {
                result = tensUp[tens];
            } else {
                result = tensUp[tens] + ' ' + onesLow[ones];
            }
        }
    } else {
        if (tens === 0 && ones === 0) {
            result = onesUp[hundreds] + ' hundred';
        } else if (ones === 0) {
            result = onesUp[hundreds] + ' hundred' + ' and ' + tensLow[tens];
        } else if (tens === 0) {
            result = onesUp[hundreds] + ' hundred' + ' and ' + onesLow[ones];
        } else {
            if (tens === 1 && ones >= 1) {
                result = onesUp[hundreds] + ' hundred' + ' and ' + teensLow[ones];
            } else {
                result = onesUp[hundreds] + ' hundred' + ' and ' + tensLow[tens] + ' ' + onesLow[ones];
            }
        }
    }

    return result;
}
solve(['729']);