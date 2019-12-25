var SalesTableTemplate = `
<div class="container">
<div class="row">
    <table class="table">
        <thead class="col col-3">
            <tr>
                <th>名稱</th>
                <th>總銷售金額</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="sale in propsData">
                <td>{{sale.ProductName}}</td>
                <td>{{sale.TotalPrize}}</td>              
            </tr>
        </tbody>
    </table>
</div>
</div>
`

var SalesTableComponent = {
    template: SalesTableTemplate,
    props: ['propsData'],
}