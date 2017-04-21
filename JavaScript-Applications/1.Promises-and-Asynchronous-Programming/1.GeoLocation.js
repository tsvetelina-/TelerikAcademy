(function() {
    var myPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((pos) => {
            resolve(pos);
        })
    });

    function parsePosition(pos) {
        return {
            lat: pos.coords.latitude,
            long: pos.coords.longitude
        }
    }

    function displayMap(pos) {
        let img = document.getElementById('image');
        img.src = 'https://www.google.bg/maps/@${pos.lat},${pos.long},11z?hl=en';
    }

    myPromise
        .then(parsePosition)
        .then(displayMap)
}());