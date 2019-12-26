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

$(".aa-cart-quantity").change(function () {
    for (var i = 1; i <= $("#MyCount").val(); i++) {
        var Id = $("#" + (i + 1999)).val();
        var Quantity = $("#" + (i + 2999)).val();
        EditToCart(Id, Quantity);
    }
    var TotalAmountwow = 0;
    for (var i = 1; i <= $("#MyCount").val(); i++) {
    var price = $("#" + (i + 3999)).val();
        var Quantity2 = $("#" + (i + 2999)).val();
        TotalAmountwow += Number(price) * Number(Quantity2)
    }
    $("#TotalAmountwow").val("$" + TotalAmountwow)
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