let titleParam = decodeURIComponent(window.location.search.substring(1).split("&")[0].split("=")[1]);
let textParam = decodeURIComponent(window.location.search.substring(1).split("&")[1].split("=")[1]);
document.getElementById('title').innerHTML = titleParam;
document.getElementById('text').innerHTML = textParam;

