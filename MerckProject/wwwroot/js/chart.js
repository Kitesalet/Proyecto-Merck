function drawChart(firstAge, endAge) {
    var array = [['Años', 'Foliculos']];

    var dataValues = [
        //De 18 a 30 fertilidad alta
        [18, 201359.4167], //0
        [19, 186328.0833],//1
        [20, 172180.8333],//2
        [21, 158867.8333],//3
        [22, 146342.8333],//4
        [23, 134561.75],//5...
        [24, 123484.0833],
        [25, 113071.3333],
        [26, 103287.5],
        [27, 94099.33333],
        [28, 85475.83333],
        [29, 77387.91667],
        [30, 69809.16667], // 30 en adelante fertilidad media
        [31, 62715.16667],
        [32, 56083.75],
        [33, 49894.58333],
        [34, 44129.66667],
        [35, 38773.83333],
        [36, 33813.33333],
        [37, 29237.16667],
        [38, 25036.41667],
        [39, 21204.5],
        [40, 17737], // 40 en adelante fertilidad baja
        [41, 14630.16667],
        [42, 11881.5],
        [43, 9486.333333],
        [44, 7438],
        [45, 5723.416667],
        [46, 4322.166667],
        [47, 3206.083333],
        [48, 1641],
        [49, 1684],
        [50, 1198]

    ];


    let selectedDataValues = [];
    let fertilityLevel = "";
    let modifiedFirstAge;
    let realRow;
    let lastAgeMod;

    if (firstAge >= 21) {
        modifiedFirstAge = firstAge - 21;
        realRow = 3;
    } else if (firstAge === 20) {
        modifiedFirstAge = firstAge - 20;
        realRow = 2;
    } else if (firstAge === 19) {
        modifiedFirstAge = firstAge - 19;
        realRow = 1;
    } else {
        modifiedFirstAge = firstAge - 18; 
        realRow = 0;
    }

    if (ovuleCount <= 30) {
        fertilityLevel = "ALTA"
    } else if (ovuleCount <= 40) {
        fertilityLevel = "MEDIA"
    } else {
        fertilityLevel = "BAJA"
    }


    if (endAge === 0) {

        if (firstAge <= 45) {
            lastAgeMod = firstAge - 12;

        }
        if (firstAge === 46) {

            lastAgeMod = firstAge - 13;
        }
        if (firstAge === 47) {

            lastAgeMod = firstAge - 14;
        }
        if (firstAge === 48) {

            lastAgeMod = firstAge - 15;
        }
        if (firstAge === 49) {

            lastAgeMod = firstAge - 16;
        }
        if (firstAge === 50) {

            lastAgeMod = firstAge - 17;
        }

        for (let i = modifiedFirstAge; i < lastAgeMod; i++) {
            selectedDataValues.push(dataValues[i]);
        }

    } else {

        for (let i = modifiedFirstAge; i < endAge - 17; i++) {
            selectedDataValues.push(dataValues[i]);
        }

    }

    array = array.concat(selectedDataValues);

    var data = google.visualization.arrayToDataTable(array);

    var options = {
        title: 'Tasa de Fertilidad Actual: ' + fertilityLevel,
        curveType: 'function',
        legend: { position: 'bottom' },
        crosshair: {
            color: '#2EBDCD',
            trigger: 'selection'
        },
        tooltip: { isHtml: true },
        width: '100%',
        series: {
            0: {
                color: '#FF69B4',
                lineWidth: 2,
                visibleInLegend: false
            },
            1: {
                color: 'rgba(255, 105, 180, 0.8)',
                lineWidth: 2,
                visibleInLegend: false
            },
            2: {
                color: 'rgba(255, 105, 180, 0.6)',
                lineWidth: 2,
                visibleInLegend: false
            },
        }
    };


    var chart = new google.visualization.LineChart(document.getElementById('chart_div'));

    chart.draw(data, options);

    chart.setSelection([
        {
            row: realRow, 
            column: 1
        }
    ]);
}

function drawChart2(firstAge, endAge, foliName) {


    var dataValues = [
        //De 18 a 30 fertilidad alta
        [18, 201359.4167], //0
        [19, 186328.0833],//1
        [20, 172180.8333],//2
        [21, 158867.8333],//3
        [22, 146342.8333],//4
        [23, 134561.75],//5...
        [24, 123484.0833],
        [25, 113071.3333],
        [26, 103287.5],
        [27, 94099.33333],
        [28, 85475.83333],
        [29, 77387.91667],
        [30, 69809.16667], // 30 en adelante fertilidad media
        [31, 62715.16667],
        [32, 56083.75],
        [33, 49894.58333],
        [34, 44129.66667],
        [35, 38773.83333],
        [36, 33813.33333],
        [37, 29237.16667],
        [38, 25036.41667],
        [39, 21204.5],
        [40, 17737], // 40 en adelante fertilidad baja
        [41, 14630.16667],
        [42, 11881.5],
        [43, 9486.333333],
        [44, 7438],
        [45, 5723.416667],
        [46, 4322.166667],
        [47, 3206.083333],
        [48, 1684],
        [49, 1600],
        [50, 1198]

    ];


    let selectedDataValues = [];
    let fertilityLevel = "";
    let modifiedFirstAge;
    let realRow;
    let lastAgeMod;


    //Datos para el escalado del grafico
    if (firstAge >= 21) {
        modifiedFirstAge = firstAge - 21;
        realRow = 3;
    } else if (firstAge === 20) {
        modifiedFirstAge = firstAge - 20;
        realRow = 2;
    } else if (firstAge === 19) {
        modifiedFirstAge = firstAge - 19;
        realRow = 1;
    } else {
        modifiedFirstAge = firstAge - 18;
        realRow = 0;
    }

    if (ovuleCount <= 30) {
        fertilityLevel = "ALTA"
    } else if (ovuleCount <= 40) {
        fertilityLevel = "MEDIA"
    } else {
        fertilityLevel = "BAJA"
    }


    if (endAge === 0) {

        if (firstAge <= 45) {
            lastAgeMod = firstAge - 12;

        }
        if (firstAge === 46) {

            lastAgeMod = firstAge - 13;
        }
        if (firstAge === 47) {

            lastAgeMod = firstAge - 14;
        }
        if (firstAge === 48) {

            lastAgeMod = firstAge - 15;
        }
        if (firstAge === 49) {

            lastAgeMod = firstAge - 16;
        }
        if (firstAge === 50) {

            lastAgeMod = firstAge - 17;
        }

        for (let i = modifiedFirstAge; i < lastAgeMod; i++) {
            selectedDataValues.push(dataValues[i]);
        }

    } else {

        for (let i = modifiedFirstAge; i < endAge - 17; i++) {
            selectedDataValues.push(dataValues[i]);
        }

    }

    //Funcion para seleccionar la edad de la persona en el grafico ( colorada en rojo )
    function highlightSelectedPoint() {
        if (realRow !== undefined && realRow >= 0 && realRow < labels.length) {
            myChart.data.datasets[0].pointBackgroundColor = Array(labels.length).fill('rgba(255,0,0,0)');
            myChart.data.datasets[0].pointBackgroundColor[realRow] = 'rgba(255, 0, 0, 1)';
            myChart.update();
        }
    }

    var labels = selectedDataValues.map(function (item) {
        return item[0];
    });

    

    var ctx = document.getElementById('myChart').getContext('2d');

    //Cambia el gradiente en base a las edades


    /*

    var gradient = ctx.createLinearGradient(0, 0, 0, windowHeight / 2.2);

    gradient.addColorStop(0, 'rgba(255, 105, 180, 1)');

    if (endAge <= 30 && endAge !== 0) {
        gradient.addColorStop(1, 'rgba(220, 169, 169, 1)');
        console.log("menos 30");
    } else if (endAge <= 40 && endAge !== 0) {
        gradient.addColorStop(1, 'rgba(160,160, 160, 1)');
        console.log("menos igual 40");
    } else if (endAge > 40) {
        gradient.addColorStop(1, 'rgba(128, 128, 128, 1)');
        console.log("mas 40");
    }

    */

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

            if (endAge <= 30 && endAge !== 0) {
                gradient.addColorStop(0, 'rgba(220, 169, 169, 1)');
                console.log("menos 30");
            } else if (endAge <= 40 && endAge !== 0) {
                gradient.addColorStop(0, 'rgba(180,160, 160, 1)');
                console.log("menos igual 40");
            } else if (endAge > 40) {
                gradient.addColorStop(0, 'rgba(128, 128, 128, 1)');
                console.log("mas 40");
            }
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
                    highlightSelectedPoint();
                }
            }
        
        }
    });


}