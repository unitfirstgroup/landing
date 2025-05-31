module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            fontFamily: {
                display: "Roboto, ui-serif",
                sans: "Roboto, sans",
                serif: 'Roboto", "serif'
            },
            colors: {
                // white theme colors
                'white-main': 'oklch(0.985 0.001 106.423)', // stone-50, #fff white
                'white-action': 'oklch(0.586 0.253 17.585)', // rose-600
                // dark theme colors
                'dark-main': 'oklch(0.21 0.034 264.665)', // gray-900
                'dark-action': 'oklch(0.852 0.199 91.936)' // yellow-400
            },
            keyframes: {
                wiggle: {
                    '0%, 100%': { transform: 'rotate(-3deg)' },
                    '50%': { transform: 'rotate(3deg)' },
                }
            },
            animation: {
                wiggle: 'wiggle 1s ease-in-out infinite',
            }
        }
    },
    plugins: [],
    darkMode: "class"
};