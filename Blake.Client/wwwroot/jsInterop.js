window.snakeFunctions = {
    startInputHandler: function (razorPage) {
        console.log("Starting input handler...");
        document.addEventListener('keydown', function(event) {
            console.log("Detected keydown", event);
            razorPage.invokeMethodAsync("HandleInput", event.code)
                .then(response => console.log(response));
        });
    }
};