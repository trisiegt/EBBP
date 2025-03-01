document.getElementById('searchButton').addEventListener('click', function () {
    performSearch();
});

document.getElementById('searchInput').addEventListener('keypress', function (event) {
    if (event.key === 'Enter') {
        performSearch();
    }
});

function performSearch() {
    const searchEngine = document.getElementById('searchEngine').value;
    const searchTerm = document.getElementById('searchInput').value;
    let searchUrl;

    switch (searchEngine) {
        case 'google':
            searchUrl = `https://www.google.com/search?q=${encodeURIComponent(searchTerm)}`;
            break;
        case 'bing':
            searchUrl = `https://www.bing.com/search?q=${encodeURIComponent(searchTerm)}`;
            break;
        case 'ecosia':
            searchUrl = `https://www.ecosia.org/search?q=${encodeURIComponent(searchTerm)}`;
            break;
        case 'duckduckgo':
            searchUrl = `https://duckduckgo.com/?q=${encodeURIComponent(searchTerm)}`;
            break;
        case 'yandex':
            searchUrl = `https://yandex.com/search/?text=${encodeURIComponent(searchTerm)}`;
            break;
        default:
            searchUrl = `https://www.google.com/search?q=${encodeURIComponent(searchTerm)}`;
    }

    window.location.href = searchUrl;
}

const themeToggle = document.getElementById('themeToggle');
const welcomeImage = document.getElementById('welcomeImage'); // Get the image element

themeToggle.addEventListener('click', function () {
    document.body.classList.toggle('dark-mode');

    // Switch image based on theme
    if (document.body.classList.contains('dark-mode')) {
        welcomeImage.src = 'EBBP_DarkThemeBackground.png';
    } else {
        welcomeImage.src = 'EBBP_LightThemeBackground.png';
    }

})