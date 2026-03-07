// REGISTER
document.getElementById("registerForm").addEventListener("submit", function(e) {
    e.preventDefault();

    let username = document.getElementById("regUsername").value;
    let email = document.getElementById("regEmail").value;
    let password = document.getElementById("regPassword").value;
    let confirmPassword = document.getElementById("regConfirmPassword").value;

    // Email validation
    let emailPattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;

    if (!email.match(emailPattern)) {
        alert("Invalid email format!");
        return;
    }

    // Password length check
    if (password.length < 6) {
        alert("Password must be at least 6 characters!");
        return;
    }

    // Password match check
    if (password !== confirmPassword) {
        alert("Passwords do not match!");
        return;
    }

    // Store user in localStorage
    let user = {
        username: username,
        email: email,
        password: password
    };

    localStorage.setItem(email, JSON.stringify(user));

    alert("Registration Successful!");
    document.getElementById("registerForm").reset();
});


// LOGIN
document.getElementById("loginForm").addEventListener("submit", function(e) {
    e.preventDefault();

    let email = document.getElementById("loginEmail").value;
    let password = document.getElementById("loginPassword").value;

    let storedUser = localStorage.getItem(email);

    if (storedUser === null) {
        alert("User not found!");
        return;
    }

    let user = JSON.parse(storedUser);

    if (user.password === password) {
        alert("Login Successful! Welcome " + user.username);
    } else {
        alert("Incorrect password!");
    }

    document.getElementById("loginForm").reset();
});