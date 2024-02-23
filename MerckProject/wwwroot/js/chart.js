function drawChart(ovuleCount, endAge) {
    var array = [['Años', 'Foliculos']];

    var dataValues = [
        //De 18 a 30 fertilidad alta
        [18, 201359.4167],
        [19, 186328.0833],
        [20, 172180.8333],
        [21, 158867.8333],
        [22, 146342.8333],
        [23, 134561.75],
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

    console.log(ovuleCount);

    let selectedDataValues = [];
    let ageInterval;
    let fertilityLevel = "";

    if (endAge === 0) {

        array = array.concat(dataValues);

    } else {

        ageInterval = endAge - ovuleCount;

        if (endAge >= 40) {

            for (let i = ovuleCount - 18; i <= endAge - 18; i++) {
                selectedDataValues.push(dataValues[i]);
            }
            fertilityLevel = "BAJA";

        }
        else if (endAge >= 30) {
            for (let i = ovuleCount - 18; i <= endAge - 13; i++) {
                selectedDataValues.push(dataValues[i]);
            }
            fertilityLevel = "MEDIA"

        }
        else {
            for (let i = ovuleCount - 18; i <= endAge - 8; i++) {
                selectedDataValues.push(dataValues[i]);
            }

            fertilityLevel = "ALTA"
        }

        array = array.concat(selectedDataValues);

    }

    
    var data = google.visualization.arrayToDataTable(array);

    var options = {
        title: 'Tasa de Fertilidad Al Momento De Iniciar: ' + fertilityLevel,
        curveType: 'function',
        legend: { position: 'bottom' },
        crosshair: {
            color: '#2EBDCD',
            trigger: 'selection'
        },
        tooltip: { isHtml: true }, 
        width: '100%'
    };


    var chart = new google.visualization.LineChart(document.getElementById('chart_div'));

    chart.draw(data, options);

    chart.setSelection([
        {
            row: ovuleCount - ovuleCount, 
            column: 1
        },
        {
            row: ageInterval, // Assuming ageInterval is an index
            column: 1
        }
    ]);
}