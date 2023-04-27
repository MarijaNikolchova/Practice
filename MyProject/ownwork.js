let title = document.getElementById('title').value;
let text = document.getElementById('text').value;
let url = "http://127.0.0.1:5500/read.html" + encodeURIComponent(title) + "&text=" + encodeURIComponent(text);
window.location.href = url;

//Form submissions
const loginForm = document.getElementById("login-form");
const registerForm = document.getElementById("register-form");
const forgotForm = document

function submitContent() {
  var title = document.getElementById("title").value;
  var text = document.getElementById("text").value;
  var error = document.getElementById("error");

  if (title === "" && text === "") {
    error.innerHTML = "Error: Title and text are required.";
  } else if (title === "") {
    error.innerHTML = "Error: Title is missing.";
  } else if (text === "") {
    error.innerHTML = "Error: Text is required.";
  } else if (text.length > 100000) {
    error.innerHTML = "Error: Text exceeds character limit of 100,000.";
  } else {
    // Submit the form
    alert("Title: " + title + "\nText: " + text);
    document.getElementById("title").value = "";
    document.getElementById("text").value = "";
    error.innerHTML = "";
  }
}
