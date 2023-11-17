const form = document.getElementById("login-form-logres");
const email = document.getElementById("email-logres")
const password = document.getElementById("password-logres")
const remember = document.getElementById("remember-me-logres")


const emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
const passwordRegex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"


// --------------------------------------ini buat popupnya---------------------------------------- //

const defaultLogin = document.getElementsByClassName("default-container-logres")[0];
const errLogin = document.getElementsByClassName("popup-container-logres")[0];


function LoginErrorPopup() {
    errLogin.style.display = "flex";
    defaultLogin.style.display = "none";
}

function closeLoginErrorPopup() {
    errLogin.style.display = "none";
    defaultLogin.style.display = "flex";
}
// --------------------------------------ini kelar popupnya---------------------------------------- //
