let redirectingSite = 'http://telerikacademy.com/';
let element = document.getElementById('popup');

(function() {
    let myPromise = new Promise((resolve, reject) => {
        resolve(document.getElementById('popup'));
    });

    function wait(time, element) {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve(element);
            }, time);
        });
    }

    function redirect(element) {
        window.location = redirectingSite;
    }

    myPromise
        .then(element => wait(2000, element))
        .then(redirect);
}());