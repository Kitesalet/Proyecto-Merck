function drawChart2(dataValues, foliName) {
    let selectedDataValues = dataValues.map(item => [item.Item1, item.Item2]);
    let labels = selectedDataValues.map(item => item[0]);

    var ctx = document.getElementById('myChart').getContext('2d');

    //Gradient
    let width, height, gradient;

    function getGradient(ctx, chartArea) {
        const chartWidth = chartArea.right - chartArea.left;
        const chartHeight = chartArea.bottom - chartArea.top;

        if (!gradient || width !== chartWidth || height !== chartHeight) {
            width = chartWidth;
            height = chartHeight;
            gradient = ctx.createLinearGradient(0, chartArea.bottom, 0, chartArea.top);
            gradient.addColorStop(1, 'rgba(255, 105, 180, 1)'); // Start color (pinkish)
            gradient.addColorStop(0, 'rgba(128, 128, 128, 1)'); // End color (greyish)
        }

        return gradient;
    }

    // Create a datasets array for the chart
    var datasets = [{
        label: foliName,
        data: selectedDataValues.map(item => item[1]),
        borderColor: function (context) {
            const chart = context.chart;
            const { ctx, chartArea } = chart;
            if (!chartArea) {
                return null;
            }
            return getGradient(ctx, chartArea);
        },
        borderWidth: 3,
        lineTension: 0,
        fill: true, // Fill the area under the line
        pointStyle: 'none'
    }];

    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: datasets
        },
        options: {
            legend: {
                display: true
            },
            plugins: {
                tooltip: {
                    enabled: true, // Enable tooltips
                    mode: 'index',
                    intersect: false,
                    position: 'nearest',
                    callbacks: {
                        show: function (tooltip) {
                            if (tooltip.dataPoints) {
                                if (tooltip.dataPoints[0]) {
                                    tooltip.dataPoints[0].hidden = false; // Show tooltip for first data point
                                }
                            }
                        }
                    }
                }
            },
            hover: {
                mode: 'nearest',
                intersect: true
            },
            animation: {
                duration: 2000, // Duration of the animation in milliseconds
                easing: 'linear' // Animation easing function
            }
        }
    });
}


//function drawChart2(dataValues, foliName) {
//    let selectedDataValues = dataValues.map(item => [item.Item1, item.Item2]);
//    let labels = selectedDataValues.map(item => item[0]);

//    var ctx = document.getElementById('myChart').getContext('2d');

//    //Gradient
//    let width, height, gradient;

//    function getGradient(ctx, chartArea) {
//        const chartWidth = chartArea.right - chartArea.left;
//        const chartHeight = chartArea.bottom - chartArea.top;

//        if (!gradient || width !== chartWidth || height !== chartHeight) {
//            width = chartWidth;
//            height = chartHeight;
//            gradient = ctx.createLinearGradient(0, chartArea.bottom, 0, chartArea.top);
//            gradient.addColorStop(1, 'rgba(255, 105, 180, 1)');
//            gradient.addColorStop(0, 'rgba(128, 128, 128, 1)');
//        }

//        return gradient;
//    }

//    // Create a datasets array for the chart
//    var datasets = [{
//        label: foliName,
//        data: selectedDataValues.map(item => item[1]),
//        borderColor: 'rgba(255, 105, 180, 1)',
//        borderWidth: 2,
//        lineTension: 0,
//        backgroundColor: function (context) {
//            const chart = context.chart;
//            const { ctx, chartArea } = chart;
//            if (!chartArea) {
//                return null;
//            }
//            return getGradient(ctx, chartArea);
//        },
//        fill: 'start' // Fill the area under the line
//    }];

//    var myChart = new Chart(ctx, {
//        type: 'line',
//        data: {
//            labels: labels,
//            datasets: datasets
//        },
//        options: {
//            legend: {
//                display: true
//            },
//            animation: {
//                onComplete: function () { }
//            }
//        }
//    });
//}