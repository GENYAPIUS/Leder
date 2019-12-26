

function AddToWishlist(id) {
    $.ajax({
        type: 'POST',
        url: '/Wishlist/AddToWishlist',
        data: { productId: id }

    });

}

function RemoveWishlist(productId) {
    $.ajax({
        type: 'POST',
        url: '/Wishlist/RemoveWishlist',
        data: { id: productId }
    });

}




