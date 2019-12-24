var procurementModalTemplate = 
`<div class="modal fade" ref="procurementModal" id="procurementModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
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
                <button type="button" class="btn btn-primary" v-on:click="EditProcurement(modalData)">儲存變更</button>
                <button type="button" class="btn btn-danger" v-on:click="DismissModal($refs.procurementModal)">關閉視窗</button>
            </div>
        </div>
    </div>
</div>`;

var procurementDeleteModalTemplate = 
`<div class="modal fade" ref="procurementDeleteModal" id="procurementDeleteModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
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
                <label>{{modalData.PurchaseDate}}</label><br />
                <label for="procurementQuantity">數量</label>
                    <label>{{modalData.Quantity}}</label><br />
                <label for="procurementUnitPrize">進貨單價</label>
                <label>{{modalData.UnitPrize}}</label><br />
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-warning" v-on:click="DeleteProcurement(modalData.ProcurementId)">刪除訂單</button>
                <button type="button" class="btn btn-danger" v-on:click="DismissModal($refs.procurementDeleteModal)">關閉視窗</button>              
            </div>
        </div>
    </div>
</div>`;

var procurementCreateModalTemplate = `
<div class="modal fade" ref="procurementCreateModal" id="procurementCreateModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>       
               <div class="modal-body" v-if="modalData">

                    <label>進貨商品名稱:
<select>
  <option value="volvo">Volvo</option>
  <option value="saab">Saab</option>
  <option value="mercedes">Mercedes</option>
  <option value="audi">Audi</option>
</select>
                       </label><br>
                    <label for="procurementDate">進貨日期</label>
                    <input name="procurementDate" class="form-control" v-model="modalData.PurchaseDate">
                    <label for="procurementQuantity">數量</label>
                    <input name="procurementQuantity" class="form-control" v-model.number="modalData.Quantity"><br />
                    <label for="procurementUnitPrize">進貨單價</label>
                    <input name="procurementUnitPrize" class="form-control" v-model.number="modalData.UnitPrize"><br />
                </div>
            <div class="modal-footer">             
                <button type="button" class="btn btn-primary" v-on:click="CreateProcurement(modalData)">新增訂單</button>
                <button type="button" class="btn btn-danger" v-on:click="DismissModal($refs.procurementCreateModal)">關閉視窗</button>
            </div>
        </div>
    </div>
</div>
`

var procurementTableTemplate = `
<div>
    <table class="table">
        <thead>
         <button type="button" class="btn btn-info" v-on:click="DisplayModal(null,$refs.procurementCreateModal)">新增訂單</button>
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
                    <button type="button" class="btn btn-primary" v-on:click="DisplayModal(procurement,$refs.procurementModal)">修改</button>
                    <button type="button" class="btn btn-danger" v-on:click="DisplayModal(procurement,$refs.procurementDeleteModal)">刪除</button>
                </td>
            </tr>
        </tbody>
    </table>
    ${procurementModalTemplate} 
    ${procurementDeleteModalTemplate} 
    ${procurementCreateModalTemplate}
</div>
`

var procurementTableMethods = {
    DisplayModal: function (Source, thisModal) {
        if (Source != null) {
           
            this.$data.modalData = Source;
        }

        temp = JSON.stringify(sourceData);
        $(thisModal).modal("toggle");
    },
    DisplayCreateModal: function () {
    
    },
    DismissModal: function (thisModal) {
        sourceData = JSON.parse(temp);
        temp = null;
        mainAreaVue.$data.sourceData = sourceData;
        $(thisModal).modal("toggle");
    },
    EditProcurement: function (procurementSource) {
        console.log(procurementSource);
        var procurementJson = JSON.stringify({
            "procurement": procurementSource
        });
        ajaxFunc("/DashBoard/EditProcurement", "Post", procurementJson)
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.procurementModal).modal("toggle");
    },
    CreateProcurement: function (procurementSource) {
        var procurementJson = Json.stringify({
            "procurement": procurementSource
        });
        ajaxFunc("/DashBoard/CreateProcurement", "Post", procurementJson)
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.procurementCreateModal).modal("toggle");

    },
    DeleteProcurement: function (currentprocurementId) {
        var procurementJson = JSON.stringify({
            "id": currentprocurementId
        });
        ajaxFunc("/DashBoard/DeleteProcurement", "Post", procurementJson)
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.procurementDeleteModal).modal("toggle")
    }
}

function ProcurementAction(actionName, procurementSource, thisModal) {
    var procurementJson = JSON.stringify({
        "procurement": procurementSource
    });
    switch (actionName) {
        case 'edit':
            ajaxFunc("/DashBoard/EditProcurement", "Post", procurementJson);
            break;
        case 'create':
            ajaxFunc("/DashBoard/CreateProcurement", "Post", procurementJSon);
            break;
        case 'delete':
            ajaxFunc("/DashBoard/DeleteProcurement", "Post", procurementJSon);
            break;
    }
    mainAreaVue.$data.sourceData = sourceData;
    $(thisModal).modal("toggle");
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