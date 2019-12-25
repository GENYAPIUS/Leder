function EditToCart(productId, inQuantity) {
    $.ajax({
        type: 'POST',
        url: '/ShoppingCart/EditToCart',
        data: { id: productId, inQuantity }
    })
        .done(function (msg) {
            //將回傳的購物車頁面填入 CartLayout#Cart
            $('#CartLayout').html(msg);
            Overload();
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

function Overload() {
    jQuery(".aa-cartbox").hover(function () {
        jQuery(this).find(".aa-cartbox-summary").fadeIn(1);
    }
        , function () {
            jQuery(this).find(".aa-cartbox-summary").fadeOut(1);
        }
    );
}