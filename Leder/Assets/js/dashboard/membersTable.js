var membersTableTemplate = `
<div>
    <table class="table">
        <thead>
            <tr>
                <th>會員Email</th>
                <th>生日</th>
                <th>地址</th>
                <th>通訊地址</th>
                <th>會員等級</th>                
            </tr>
        </thead>
        <tbody>
            <tr v-for="member in propsData">                
                <td>{{member.Email}}</td>
                <td>{{member.BirthDay}}</td>
                <td>{{member.Address}}</td>
                <td>{{member.ShipAddress}}</td>
                <td>{{member.MemberRole}}</td>                
            </tr>
        </tbody>
    </table>
</div>
`

var membersTableComponent = {
    template: membersTableTemplate,
    props: ['propsData'],
}