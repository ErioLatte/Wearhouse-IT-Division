const regist_form = document.getElementById("register-form");
const regist_username = document.getElementById("username-register")
const regist_email = document.getElementById("email-register")
const regist_password = document.getElementById("password-register")
const regist_confirm_password = document.getElementById("confirm-password-register")


const regist_emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
const regist_passwordRegex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"

function registValidate(){
    if(!regist_email.value.match(regist_emailRegex)){
        regist_username.style.borderColor = "red"
    }
    console.log(regist_email.value)
}