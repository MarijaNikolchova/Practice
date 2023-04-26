const form = document.getElementById('registration-form');
const passwordInput = document.getElementById('password');
const confirmPasswordInput = document.getElementById('confirm-password');

form.addEventListener('submit', (event) => {
  event.preventDefault();
  const username = form.elements['username'].value;
  const email = form.elements['email'].value;
  const password = passwordInput.value;
  const confirmPassword = confirmPasswordInput.value;

  if (!validatePassword(password)) {
    displayErrorMessage('Password must be at least 8 characters and contain at least 1 number');
    return;
  }

  if (password !== confirmPassword) {
    displayErrorMessage('Passwords do not match');
    return;
  }

  // Sending registration data to server 

  console.log(`Username: ${username}, Email: ${email}, Password: ${password}`);
});

function validatePassword(password) {
  const passwordRegex = /^(?=.*\d).{8,}$/;
  return passwordRegex.test(password);
}

function displayErrorMessage(message) {
  const errorMessageElement = document.createElement('div');
  errorMessageElement.classList.add('error-message');
  errorMessageElement.textContent = message;
  form.appendChild(errorMessageElement);
}

// Show the Login tab by default
document.getElementById("Login").style.display = "block";


// Handle form submissions
const loginForm = document.getElementById("login-form");
const registerForm = document.getElementById("register-form");
const forgotForm = document
