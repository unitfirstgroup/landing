const colors = require("tailwindcss/colors");

module.exports = {
    content: ["./**/*.{razor,html,cshtml}", "./node_modules/flowbite/**/*.js"],
    theme: {
        extend: {
            fontFamily: {
                display: "Roboto, ui-serif",
                sans: "Roboto, sans",
                serif: 'Roboto", "serif'
            },
            colors: {
                'white-main': '#fff', // white
                'dark-main': 'oklch(0.208 0.042 265.755)', // gray-900
                'white-action': 'oklch(0.586 0.253 17.585)', // rose-600
                'dark-action': 'oklch(0.852 0.199 91.936)' // yellow-400
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