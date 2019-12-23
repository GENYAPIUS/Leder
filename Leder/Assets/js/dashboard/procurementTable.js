var procurementTableTemplate = `
<div>
    <table class="table">
        <thead>
            <tr>
                <th>訂單編號</th>
                <th>名稱</th>
                <th>單價</th>
                <th>數量</th>
                <th>日期</th>
                <th>修改訂單</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="procurement in propsData">
                <td>{{procurement.ProcurementId}}</td>
                <td>{{procurement.ProductName}}</td>
                <td>{{procurement.UnitPrize}}</td>
                <td>{{procurement.Quantity}}</td>
                <td>{{procurement.PurchaseDate}}</td>
                <td>
                    <button type="button" class="btn btn-primary" v-on:click="DisplayModal(procurement)">修改</button>
                    <button type="button" class="btn btn-danger">刪除</button>
                </td>
            </tr>
        </tbody>
    </table>
    <div class="modal fade" ref="procurementModal" id="procurementModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body" v-if="modalData">

                    <label>進貨商品名稱：<br>&nbsp;&nbsp;&nbsp;{{modalData.ProductName}}</label><br>
                    <label for="procurementDate">進貨日期</label>
                    <input name="procurementDate" class="form-control" v-model="modalData.PurchaseDate">
                    <label for="procurementQuantity">數量</label>
                    <input name="procurementQuantity" class="form-control" v-model.number="modalData.Quantity"><br />
                    <label for="procurementUnitPrize">進貨單價</label>
                    <input name="procurementUnitPrize" class="form-control" v-model.number="modalData.UnitPrize"><br />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" v-on:click="DismissModal()">關閉視窗</button>
                    <button type="button" class="btn btn-primary" v-on:click="EditProcurement(modalData)">儲存變更</button>
                </div>
            </div>
        </div>
    </div>
</div>
`
var procurementTableMethods = {
    DisplayModal: function (procurementSource) {
        this.$data.modalData = procurementSource;
        temp = JSON.stringify(sourceData);
        $(this.$refs.procurementModal).modal("toggle");
    },
    DismissModal: function () {
        sourceData = JSON.parse(temp);
        temp = null;
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.procurementModal).modal("toggle");
    },
    EditProcurement: function (procurementSource) {
        console.log(procurementSource);
        var procurementJson = JSON.stringify({
            "procurement": procurementSource
        });
        console.log(procurementJson);
        ajaxFunc("/DashBoard/EditProcurement", "Post", procurementJson)
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.procurementModal).modal("toggle");
    }
}

var procurementTableComponent = {
    template: procurementTableTemplate,
    props: ['propsData'],
    data() {
        return {
            modalData: null,
        };
    },
    methods: procurementTableMethods
}