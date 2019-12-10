
    //加入編號為productId的商品進購物車

    function RemoveFromCart(productId) {
        $.ajax({
            type: 'POST',
            url: '../ShoppingCart/RemoveFromCart',
            data: { id: productId }
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
            });
}

    function AddToCart(productId,inQuantity) {
        $.ajax({
            type: 'POST',
            url: '../ShoppingCart/AddToCart',
            data: { id: productId, inQuantity }
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
            });
}

        function ClearCart() {
        $.ajax({
            type: 'POST',
            url: '../ShoppingCart/ClearCart',
            data: {}
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
            });
    }


