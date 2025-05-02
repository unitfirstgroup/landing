const colors = require("tailwindcss/colors");

module.exports = {
    content: ["./**/*.{razor,html,cshtml}", "./node_modules/flowbite/**/*.js"],
    theme: {
        colors: {
            zela: {
                100: '#ff0000',
                300: '#00ff00',
                900: '#0000ff',
            },
        },
        extend: {
            fontFamily: {
                display: "Roboto, ui-serif",
                sans: "Roboto, sans",
                serif: 'Roboto", "serif'
            },
            colors: {
                'primary-white': '#1fb6ff',
                'primary-dark': '#7e5bef',
                'primary-accent-white': '#ff49db',
                'primary-accent-dark': '#ff7849',
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