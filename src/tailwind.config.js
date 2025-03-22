const colors = require("tailwindcss/colors");

module.exports = {
    content: ["./**/*.{razor,html,cshtml}", "./node_modules/flowbite/**/*.js"],
    theme: {
        extend: {
            colors: {
                primary: colors.red,
                secondary: colors.blue
            },
            fontFamily: {
                display: "Roboto, ui-serif",
                sans: "Roboto, sans",
                serif: 'Roboto", "serif'
            }
        }
    },
    plugins: [
        require("flowbite/plugin")({
            charts: true,
            forms: true,
            tooltips: true
        })
    ],
    darkMode: "class"
};