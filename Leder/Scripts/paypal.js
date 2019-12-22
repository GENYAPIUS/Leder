paypal.Button.render({
    env: 'sandbox',
    client: {
        sandbox: 'AUaiHPKubOvW2WEVoToVgaTDf0XU6g8E3cb0pICGF1Y1tbDlzb6WKnenjVcUVPAV0opf7bk6dbXpHM_M'
            },
    style: {
    size: 'medium',
    color: 'black',
    shape: 'pill',
    label: 'paypal',
    tagline: 'false',
    fundingicons: 'true'
},
    commit: true,
    payment: function (data, actions) {
        return actions.payment.create({
            // 此功能設置交易明細，包括金額和行項目明細。
            transactions: [
                {
                    amount: {
                        total: $("#TotalAmount").val(),
                        currency: "TWD"
                    },
                    //description: "测试商品描述",
                    custom: "X00002",
                }
            ],
            redirect_urls: {
                return_url: '/Order/Index',
                cancel_url: 'http://localhost:4478/Cancel.aspx'
            }
        });
    },
    onAuthorize: function (data, actions) {
        return actions.payment.execute()
            .then(function () {
                actions.redirect();
            });
    },
    onCancel: function (data, actions) {
        actions.redirect();
    }
        }, '#paypaltest');
// 此功能會在您的網頁上顯示智能付款按鈕。





