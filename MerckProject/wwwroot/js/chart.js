function drawChart2(dataValues, foliName) {

    let selectedDataValues = [];
    dataValues.forEach(function (item, index) {

        var item1Value = item.Item1;
        var item2Value = item.Item2;

        let itemArray = [item1Value, item2Value];

        selectedDataValues.push(itemArray);

    })

    var labels = selectedDataValues.map(function (item) {
        return item[0];
    });

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

            gradient.addColorStop(1, 'rgba(255, 105, 180, 1)');

            //if (endAge <= 30 && endAge !== 0) {
            //    gradient.addColorStop(0, 'rgba(220, 169, 169, 1)');
            //    console.log("menos 30");
            //} else if (endAge <= 40 && endAge !== 0) {
            //    gradient.addColorStop(0, 'rgba(180,160, 160, 1)');
            //    console.log("menos igual 40");
            //} else if (endAge > 40) {
            gradient.addColorStop(0, 'rgba(128, 128, 128, 1)');
            console.log("mas 40");
            /* }*/
        }

        return gradient;
    }


    // Create a datasets array for the chart
    var datasets = [{
        label: foliName,
        data: selectedDataValues.map(function (item) {
            return item[1];
        }),
        borderColor: function (context) {
            const chart = context.chart;
            const { ctx, chartArea } = chart;

            if (!chartArea) {
                return;
            }
            return getGradient(ctx, chartArea);
        },
        borderWidth: 2,
        lineTension: 0,
        backgroundColor: gradient
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
            animation: {
                onComplete: function () {
                }
            }

        }
    });


}