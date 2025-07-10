export function showAlert(message) {
    alert(message);
}

export function switchTheme() {
    var element = document.getElementById("app");
    if (element == null)
        return false;

    if (element.classList.contains('dark')) {
        element.classList.remove('dark');
        return false;
    } else {
        element.classList.add('dark');
        return true;
    }
}

export function darkTheme() {
    var element = document.getElementById("app");
    if (element.classList.contains('dark')) {
        return true;
    } else {
        element.classList.add('dark');
        return true;
    }
}