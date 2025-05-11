export function showAlert(message) {
    alert(message);
}

export function updateTheme() {
    var element = document.getElementById("app");
    if (element.classList.contains('dark')) {
        element.classList.remove('dark');
    } else {
        element.classList.add('dark');
    }
}