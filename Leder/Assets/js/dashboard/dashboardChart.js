var chartTemplate = `
<div>
    <div class="row">
        <div class="col-md-6 col-sm-6 col-xs-12">
            <div class="x_panel">
                <div class="x_title">
                    <h2>每月成本</h2>
                    <ul class="nav navbar-right panel_toolbox">
                        <li><a class="close-link"><i class="fa fa-close"></i></a>
                        </li>
                    </ul>
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
                    <ul class="nav navbar-right panel_toolbox">
                        <li><a class="close-link"><i class="fa fa-close"></i></a>
                        </li>
                    </ul>
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
                    color.push(getRandomColor());
                }
                var chartData = {
                    labels: dataSource.Label,
                    datasets: [{
                        data: dataSource.Data,
                        backgroundColor: colors,
                    }]
                };
                var chart = new Chart(ctx, {
                    type: 'doughnut',
                    data: chartData
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
        ajaxFunc("/Dashboard/GetPricePerMonthChartData", "Get");
        this.$data.chartData = sourceData
        this.DisplayChart(this.$refs.costPerMonthChart, 'bar');
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