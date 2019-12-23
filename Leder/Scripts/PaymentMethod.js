
$('#paycheck').click(function () {

    if (document.getElementById("NameForm").value == "" || document.getElementById("TelForm").value == "" || document.getElementById("ZipForm").value == ""){
        return;
    }
    else {
    if (document.getElementById("paypal").checked) {
        PaymentMethod("尚未付款");
        document.getElementById("RecieveForm").action = '/ShoppingCart/Order';
        document.getElementById("RecieveForm").submit();
    }
    else if (document.getElementById("cashdelivery").checked) {
        PaymentMethod("貨到付款");
        document.getElementById("RecieveForm").action = '/ShoppingCart/CashOrder';
        document.getElementById("RecieveForm").submit();
    }
}
});

function PaymentMethod(paycheck) {
    $.ajax({
        url: "/ShoppingCart/OrderData",
        type: "post",
        contentType: 'application/json',
        data: JSON.stringify({
            'Email': $('#EmailForm').val(),
            'RecieverName': $('#NameForm').val(),
            'RecieverPhone': $('#TelForm').val(),
            'RecieverAddress': $('#AddressForm').val(),
            'RecieverZipCode': $('#ZipForm').val(),
            'PayStatus': paycheck,
        })
    });
}

