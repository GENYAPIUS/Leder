var membersTableTemplate = `
<div>
<button type="button" class="btn btn-info" v-on:click="DisplayModal($data.modalData,$refs.membersCreateModal)">新增會員</button>
    <table class="table">
        <thead>
            <tr>
                <th>會員Email</th>
                <th>生日</th>
                <th>地址</th>
                <th>通訊地址</th>
                <th>會員等級</th>
                <th>修改會員等級</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="member in propsData">                
                <td>{{member.Email}}</td>
                <td>{{member.BirthDay}}</td>
                <td>{{member.Address}}</td>
                <td>{{member.ShipAddress}}</td>
                <td>{{member.MemberRole}}</td>
                <td>
                    <button type="button" class="btn btn-primary" v-on:click="">修改</button>                    
                </td>
            </tr>
        </tbody>
    </table>
</div>
`


var membersCreateModalTemplate = `
<div class="modal fade" ref="membersCreateModal" id="membersCreateModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">新增會員</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>       
               <div class="modal-body" v-if="modalData">
                    <label for="productName">進貨商品名稱</label>
                       <select v-model="modalData.ProductId">
                            <option v-bind:value=product.Id v-for="product in propsList">{{product.Name}}</option>
                       </select><br />
                    <label for="procurementDate">進貨日期</label><br />
                    <input name="procurementDate" class="form-control" v-model="modalData.PurchaseDate">
                    <label for="procurementQuantity" >數量</label>
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






const memberData = {
    Email: "",
    Password: "",
    ConfirmPassword: "",
    CellPhone: "",
    Address: "",
    ShipAddress: "",
    BirthDate: "",
    IdentityCard: ""
}

var membersTableMethods = {
    DisplayModal: function (Source, thisModal) {
        if (Source != null) {
            this.$data.modalData = Source;
        }
        if (thisModal == this.$refs.membersCreateModal) {
            this.$data.modalData = memberData;
        }

        temp = JSON.stringify(mainAreaVue.$data.sourceData);
        $(thisModal).modal("toggle");
    },
    DismissModal: function (thisModal) {
        sourceData = JSON.parse(temp);
        temp = null;
        this.$data.modalData = null
        mainAreaVue.$data.sourceData = sourceData;
        $(thisModal).modal("toggle");
    },    
    AddMember: function (membersSource) {
        var membersJson = JSON.stringify({
            "members": membersSource
        });
        ajaxFunc("/DashBoard/AddMember", "Post", membersJson)
        mainAreaVue.$data.sourceData = sourceData;
        $(this.$refs.membersCreateModal).modal("toggle");

    }    
}

var membersTableComponent = {
    template: membersTableTemplate,
    props: ['propsData'],
    data() {
        return {
            modalData: null,
        };
    },
    methods: membersTableMethods,
    mounted() {
        $(this.$refs.membersTable).DataTable({

        });
    }
}
