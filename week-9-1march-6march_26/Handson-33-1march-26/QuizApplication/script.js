const questions = [
    {
        question: "Which language is used for web styling?",
        options: ["HTML", "CSS", "Python", "Java"],
        correct: 1
    },
    {
        question: "Which company developed JavaScript?",
        options: ["Microsoft", "Netscape", "Google", "Oracle"],
        correct: 1
    },
    {
        question: "Which symbol is used for comments in JS?",
        options: ["//", "<!-- -->", "#", "/* */"],
        correct: 0
    }
];

let currentQuestion = 0;
let score = 0;
let timer;
let timeLeft = 10;

const questionEl = document.getElementById("question");
const optionsEl = document.getElementById("options");
const nextBtn = document.getElementById("nextBtn");
const resultEl = document.getElementById("result");
const timerEl = document.getElementById("timer");

function startTimer() {
    timeLeft = 10;
    timerEl.textContent = "Time Left: " + timeLeft + "s";

    timer = setInterval(() => {
        timeLeft--;
        timerEl.textContent = "Time Left: " + timeLeft + "s";

        if (timeLeft === 0) {
            clearInterval(timer);
            nextQuestion();
        }
    }, 1000);
}

function loadQuestion() {
    clearInterval(timer);
    startTimer();

    const q = questions[currentQuestion];
    questionEl.textContent = q.question;
    optionsEl.innerHTML = "";

    q.options.forEach((option, index) => {
        const button = document.createElement("button");
        button.textContent = option;
        button.addEventListener("click", () => checkAnswer(index));
        optionsEl.appendChild(button);
    });
}

function checkAnswer(selectedIndex) {
    clearInterval(timer);
    const correctIndex = questions[currentQuestion].correct;

    const buttons = optionsEl.querySelectorAll("button");

    buttons.forEach((btn, index) => {
        if (index === correctIndex) {
            btn.classList.add("correct");
        } else if (index === selectedIndex) {
            btn.classList.add("wrong");
        }
        btn.disabled = true;
    });

    if (selectedIndex === correctIndex) {
        score++;
    }
}

function nextQuestion() {
    currentQuestion++;

    if (currentQuestion < questions.length) {
        loadQuestion();
    } else {
        showResult();
    }
}

function showResult() {
    questionEl.style.display = "none";
    optionsEl.style.display = "none";
    nextBtn.style.display = "none";
    timerEl.style.display = "none";

    resultEl.innerHTML = "Your Score: " + score + " / " + questions.length;
}

nextBtn.addEventListener("click", nextQuestion);

loadQuestion();