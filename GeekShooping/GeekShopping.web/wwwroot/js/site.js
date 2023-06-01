// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Obtém todos os links
var links = document.querySelectorAll('.nav-link');

// Adiciona o evento de clique a cada link
links.forEach(function (link) {
    link.addEventListener('click', function () {
        // Verifica se o link clicado não é o link "Home"
        if (this.id !== 'homeLink') {
            // Remove a classe active do link "Home"
            var homeLink = document.getElementById('homeLink');
            homeLink.classList.remove('active');
        }

        // Remove a classe active de todos os links
        links.forEach(function (link) {
            link.classList.remove('active');
        });

        // Adiciona a classe active ao link clicado
        this.classList.add('active');

        // Salva o link clicado no armazenamento local
        localStorage.setItem('activeLink', this.id);
    });
});

// Verifica se existe um link ativo no armazenamento local
var activeLink = localStorage.getItem('activeLink');
if (activeLink) {
    // Adiciona a classe active ao link armazenado
    var linkElement = document.getElementById(activeLink);
    if (linkElement) {
        linkElement.classList.add('active');
    }
}