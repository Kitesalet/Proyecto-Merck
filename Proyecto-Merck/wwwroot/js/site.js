// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var buttons = document.querySelectorAll('.merck-button');

var buttonSpinnerCounter = 0;
buttons.forEach(function (button) {

    console.log(button);

    if (buttonSpinnerCounter == 0) {
        button.addEventListener('click', function () {

            console.log(this);

            let spinnerContainer = this.querySelector('.spinner-container');
            let buttonSpan = this.querySelector('.m-button-span');

            buttonSpan.classList.add('d-none');
            spinnerContainer.classList.add('spinner-grow', 'text-light');

            buttonSpinnerCounter++;
        })
    }



});



