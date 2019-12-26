var SalesTableTemplate = `
<div class="container" style="width:30%;float:left">
<div class="row">
    <table class="table col-md-6">
        <thead>
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