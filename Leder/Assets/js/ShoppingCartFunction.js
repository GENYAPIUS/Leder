if (location.href == window.location.protocol + '//' + window.location.host + '/ShoppingCart/Order' || location.href == window.location.protocol + '//' + window.location.host + '/Checkout') {
    function No() {
        alert("再付款頁面時不能使用此功能，請在其他頁面使用");
    }

    $("#YesAddCart").click(function () {
        No();
    });
    $("#NoAddCart").click(function () {
        No();
    });
    function RemoveFromCart(productId) {
        No();
    }
    function ClearCart() {
        No();
    }
}
else {
    //加入編號為productId的商品進購物車

    function RemoveFromCart(productId) {
        $.ajax({
            type: 'POST',
            url: '/ShoppingCart/RemoveFromCart',
            data: { id: productId }
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
                Overload();
            });
}

    function AddToCart(productId,inQuantity) {
        $.ajax({
            type: 'POST',
            url: '/ShoppingCart/AddToCart',
            data: { id: productId, inQuantity }
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
                Overload();
            });
}

        function ClearCart() {
        $.ajax({
            type: 'POST',
            url: '/ShoppingCart/ClearCart',
            data: {}
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
                Overload();
            });
}

function Overload() {
    jQuery(".aa-cartbox").hover(function () {
        jQuery(this).find(".aa-cartbox-summary").fadeIn(1);
    }
        , function () {
            jQuery(this).find(".aa-cartbox-summary").fadeOut(1);
        }
    );   
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
            Overload();
        });
}

$("#YesAddCart").click(function () {
    $('#shiftCart').hide();
    $('.modal-backdrop').hide();
    for (var i = 1; i < $("#shiftCount").val(); i++) {
        var Id = $("#" + i).val();
        var Quantity = $("#" + (i + 1000)).val();
        AddToCart(Id, Quantity);
    }
    ShiftCartOK();
});

$("#NoAddCart").click(function () {
    $('#shiftCart').hide();
    $('.modal-backdrop').hide();
    ShiftCartOK();
});
}


