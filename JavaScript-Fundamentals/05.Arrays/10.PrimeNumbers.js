function solve(args) {
    let n = +args[0];
    let IsPrim = false;
    let i;

    while (n >= 2 && !IsPrim) {
        i = 2;
        IsPrim = true;

        while (IsPrim && i <= n / 2) {
            IsPrim = n % i != 0;
            i += 1;
        }
        n -= 1;
    }

    console.log(n + 1);
}
solve(['126']);