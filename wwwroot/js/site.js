window.initializeBootstrap = () => {
    var toggler = document.querySelector('.navbar-toggler');
    var collapseDiv = document.querySelector('#navbarNav');

    toggler.addEventListener('click', function () {
        collapseDiv.classList.toggle('show');
    });
};