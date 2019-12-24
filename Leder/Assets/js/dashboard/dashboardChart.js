var chartTemplate = `

`






var chartComponent = {
    template: procurementTableTemplate,
    props: ['propsData'],
    data() {
        return {
            modalData: null,
        };
    },
    methods: procurementTableMethods
}