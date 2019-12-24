var chartTemplate = `

`






var chartComponent = {
    template: procurementTableTemplate,
    props: ['propsData'],
    data() {
        return {
            chartData: null,
        };
    },
    methods: procurementTableMethods
}