module.exports = {
  content: ["./**/*.{razor,html,cshtml}", "./node_modules/flowbite/**/*.js"],
  plugins: [
    require("flowbite/plugin")({
      charts: true,
      forms: true,
      tooltips: true
    })
  ],
  darkMode: "class"
};
