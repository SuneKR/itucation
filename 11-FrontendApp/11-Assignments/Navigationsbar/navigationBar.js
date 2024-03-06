document.addEventListener('DOMContentLoaded', function () {
    var navigationBar = document.getElementById('navigationBar');
    fetch('../navigationsbar/navigationBar.html')
        .then(response => response.text())
        .then(data => { navigationBar.innerHTML = data; })
        .then(function () {
            var dropdownToggleA = document.getElementById('myDropdownToggleA');
            var dropdownA = document.getElementById('myDropdownContainerA');
            var dropdownToggleB = document.getElementById('myDropdownToggleB');
            var dropdownB = document.getElementById('myDropdownContainerB');
            var dropdownToggleM = document.getElementById('myDropdownToggleM');
            var dropdownM = document.getElementById('myDropdownContainerM');

            dropdownToggleA.addEventListener('click', function () {
                dropdownA.classList.toggle('show');
            });

            dropdownToggleB.addEventListener('click', function () {
                dropdownB.classList.toggle('show');
            });

            dropdownToggleM.addEventListener('click', function () {
                dropdownM.classList.toggle('show');
            });

            document.addEventListener('click', function (event) {
                if (!event.target.matches('#myDropdownToggleA')) {
                    dropdownA.classList.remove('show');
                }
                if (!event.target.matches('#myDropdownToggleB')) {
                    dropdownB.classList.remove('show');
                }
                if (!event.target.matches('#myDropdownToggleM')) {
                    dropdownM.classList.remove('show');
                }
            });
        });
});