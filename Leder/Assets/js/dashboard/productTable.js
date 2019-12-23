var productTableTemplate = `
<div>
    <table class="table">
        <thead>
            <tr>
                <th>商品照片</th>
                <th>ID</th>
                <th>名稱</th>
                <th>價格</th>
                <th>分類</th>
                <th>敘述</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="product in propsData">
                <td><img v-bind:src="product.Photos" width="100px"></td>
                <td>{{product.Id}}</td>
                <td>{{product.Name}}</td>
                <td>{{product.Price}}</td>
                <td>{{product.Category}}</td>
                <td>{{product.Description}}</td>                
            </tr>
        </tbody>
    </table>
</div>
`

var productTableComponent = {
    template: productTableTemplate,
    props: ['propsData'],
}