        paypal.Buttons({
            createOrder: function (data, actions) {
                // 此功能設置交易明細，包括金額和行項目明細。
                console.log(data)
                console.log(actions)
                return actions.order.create({
                    purchase_units: [{
                        amount: {
                            value: $("#TotalAmount").val()
                        }
                    }]
                });
            },
            onApprove: function (data, actions) {
                // 此功能從交易中獲取資金。
                return actions.order.capture().then(function (details) {
                    // 此功能向您的買家顯示交易成功消息。
                    alert('您的交易已完成  金額總計：TWD ' + $("#TotalAmount").val())
                    //致電您的服務器以保存交易
                    return fetch('/paypal-transaction-complete', {
                        method: 'post',
                        headers: {
                            'content-type': 'application/json'
                        },
                        body: JSON.stringify({
                            orderID: data.orderID
                        })
                    });
                });
            }
        }).render('#paypaltest');
// 此功能會在您的網頁上顯示智能付款按鈕。





