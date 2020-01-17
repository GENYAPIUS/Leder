var orderTableTemplate = `
<div>
    <table class="table">
        <thead>
            <tr>
                <th>訂單ID</th>
                <th>客戶名稱</th>
                <th>客戶Email</th>
                <th>客戶電話</th>
                <th>送貨地址</th>      
                <th>訂購時間</th>
                <th>郵遞區號</th>
                <th>總金額</th>
                <th>付款方式</th>
                <th>出貨狀態</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="order in propsData">                
                <td>{{order.OrderId}}</td>
                <td>{{order.RecieverName}}</td>
                <td>{{order.Email}}</td>
                <td>{{order.RecieverPhone}}</td>
                <td>{{order.RecieverAddress}}</td>
                <td>{{order.OrderDate}}</td>
                <td>{{order.RecieverZipCode}}</td>
                <td>{{order.TotalAmount}}</td>
                <td>{{order.PayStatus}}</td>
                <td>{{order.OrderStatus}}</td>
            </tr>
        </tbody>
    </table>
</div>
`

var orderTableComponent = {
    template: orderTableTemplate,
    props: ['propsData'],
}