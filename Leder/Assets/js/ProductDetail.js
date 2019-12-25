function AddToCart(productId, inQuantity) {
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

$("#addcart").click(function () {
    var productId = $("#addcartval").val();
    var inQuantity = $("#ProductQuantity").val();
    AddToCart(productId, inQuantity);
});