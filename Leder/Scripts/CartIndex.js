function EditToCart(productId, inQuantity) {
    $.ajax({
        type: 'POST',
        url: '/ShoppingCart/EditToCart',
        data: { id: productId, inQuantity }
    })
        .done(function (msg) {
            //將回傳的購物車頁面填入 CartLayout#Cart
            $('#CartLayout').html(msg);
        });
}


$("#Update").click(function () {
    for (var i = 1; i <= $("#MyCount").val(); i++) {
        var Id = $("#" + (i+1999)).val();
        var Quantity = $("#" + (i + 2999)).val();
        EditToCart(Id, Quantity);
    }
    var j = 1;
});