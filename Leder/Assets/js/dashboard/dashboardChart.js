var chartTemplate = `
<div>
    <div class="row">
        <div class="col-md-6 col-sm-6 col-xs-12">
            <div class="x_panel">
                <div class="x_title">
                    <h2>每月成本</h2>
                    <div class="clearfix"></div>
                </div>
                <div class="x_content">
                    <canvas ref="costPerMonthChart" id="costPerMonthChart"></canvas>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-sm-6 col-xs-12">
            <div class="x_panel">
                <div class="x_title">
                    <h2>各產品銷售額佔總銷售額百分比</h2>
                    <div class="clearfix"></div>
                </div>
                <div class="x_content">
                    <canvas ref="salesChart" id="salesChart"></canvas>
                </div>
            </div>
        </div>
    </div>
</div>
`

var chartMethods = {
    DisplayChart(chartSource, chartType) {
        switch (chartType) {
            case 'bar':
                var dataSource = this.$data.chartData;
                var chart = new Chart(chartSource, {
                    type: 'bar',
                    data: {
                        labels: dataSource.Label,
                        datasets: [{
                            label: '成本',
                            backgroundColor: "#26B99A",
                            data: dataSource.Data
                        }]
                    },
                    options: {
                        responsive: true,
                        scales: {
                            yAxes: [{
                                ticks: {
                                    beginAtZero: true
                                }
                            }]
                        }
                    }
                });
                break;
            case 'doughnut':
                var dataSource = this.$data.chartData;
                var colors = []
                for (let i = 0; i < dataSource.Label.length; i++) {
                    colors.push(getRandomColor());
                }
                console.log(colors);
                var chartData = {
                    labels: dataSource.Label,
                    datasets: [{
                        data: dataSource.Data,
                        backgroundColor: colors,
                    }]
                };
                var chart = new Chart(chartSource, {
                    type: 'doughnut',
                    data: chartData,
                    options: {
                        legend: {
                            display: false,
                        },
                        responsive: true,
                    }
                });
                break;
        }
    },
}

var chartComponent = {
    template: chartTemplate,
    data() {
        return {
            chartData: undefined
        }
    },
    methods: chartMethods,
    mounted() {
        this.$data.chartData = ajaxFunc("/Dashboard/GetPricePerMonthChartData", "Get");
        this.DisplayChart(this.$refs.costPerMonthChart, 'bar');
        this.$data.chartData = ajaxFunc("/Dashboard/GetSalesChartData", "Get");
        this.DisplayChart(this.$refs.salesChart, 'doughnut');
    }
}

function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}