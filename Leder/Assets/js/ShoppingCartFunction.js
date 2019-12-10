﻿<script>
    //加入編號為productId的商品進購物車

    function RemoveFromCart(productId) {
        $.ajax({
            type: 'POST',
            url: '@Url.Action("RemoveFromCart","ShoppingCart")',
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
            url: '@Url.Action("AddToCart","ShoppingCart")',
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
            url: '@Url.Action("ClearCart","ShoppingCart")',
            data: {}
        })
            .done(function (msg) {
                //將回傳的購物車頁面填入 CartLayout#Cart
                $('#CartLayout').html(msg);
            });
    }
</script>

