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

function ShiftCartOK() {
    $.ajax({
        type: 'POST',
        url: '/ShoppingCart/ShiftCartOK',
        data: {}
    })
        .done(function (msg) {
            //將回傳的購物車頁面填入 CartLayout#Cart
            $('#CartLayout').html(msg);
        });
}

$("#YesAddCart").click(function () {;
    $('#shiftCart').hide();
    $('.modal-backdrop').hide();
    for (var i = 1; i < $("#shiftCount").val(); i++) {
        var Id = $("#" + i).val();
        var Quantity = $("#Quantity " + i).val();
        AddToCart(Id, Quantity);
    }
    ShiftCartOK();
});

$("#NoAddCart").click(function () {
    $('#shiftCart').hide();
    $('.modal-backdrop').hide();
    ShiftCartOK();
});