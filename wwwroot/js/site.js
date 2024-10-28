window.initializeBootstrap = () => {
    var toggler = document.querySelector('.navbar-toggler');
    var collapseDiv = document.querySelector('#navbarNav');

    toggler.addEventListener('click', function () {
        collapseDiv.classList.toggle('show');
    });
};

window.scrollToElement = function (elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        element.scrollIntoView({ behavior: 'auto', block: 'start' });
    }
};
