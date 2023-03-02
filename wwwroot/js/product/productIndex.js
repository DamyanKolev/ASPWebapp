
document.getElementById("inputProductPrice").addEventListener(
    "change", (event) => {
        event.target.value = parseFloat(event.target.value).toFixed(2);
    }
)
