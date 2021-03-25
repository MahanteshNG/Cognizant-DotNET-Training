function validation() {
    var name = Document.getElementById("title").value;
    var price = parseInt(Document.getElementById("price").value);

    if (name.length < 2 && name.length > 65) {
        alert("Price is required. \nIt has to be a number.");
    }
    if (isNaN(price)) {
        alert("Price is required. \nIt has to be a number.");
    }

}
