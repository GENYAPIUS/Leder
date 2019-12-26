function AddToCart(productId, inQuantity) {
    $.ajax({
        type: 'POST',
        url: '/ShoppingCart/AddToCart',
        data: { id: productId, inQuantity }
    })
        .done(function (msg) {
            //將回傳的購物車頁面填入 CartLayout#Cart
            $('#CartLayout').html(msg);
            Overload()
        });
}

$("#addcart").click(function () {
    var productId = $("#addcartval").val();
    var inQuantity = $("#ProductQuantity").val();
    AddToCart(productId, inQuantity);
});

function Overload() {
    jQuery(".aa-cartbox").hover(function () {
        jQuery(this).find(".aa-cartbox-summary").fadeIn(1);
    }
        , function () {
            jQuery(this).find(".aa-cartbox-summary").fadeOut(1);
        }
    );
}