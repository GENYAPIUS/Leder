function AddItemsToCart(productId, inQuantity) {
    $.ajax({
        type: 'POST',
        url: '/ShoppingCart/AddToCart',
        data: { id: productId, inQuantity }
    })
        .done(function (msg) {
            //將回傳的購物車頁面填入 CartLayout#Cart
            $('#CartLayout').html(msg);
        });
}

$("#addItemsToCart").click(function () {
    var productId = $("#addItemsCartVal").val();
    var inQuantity = $("#ItemsProductQuantity").val();
    AddItemsToCart(productId, inQuantity);
});