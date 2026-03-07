const taskInput = document.getElementById("taskInput");
const addBtn = document.getElementById("addBtn");
const taskList = document.getElementById("taskList");

// Load tasks when page loads
document.addEventListener("DOMContentLoaded", loadTasks);

// Add task button click
addBtn.addEventListener("click", addTask);

function addTask() {
    let taskText = taskInput.value.trim();

    if (taskText === "") {
        alert("Please enter a task!");
        return;
    }

    createTaskElement(taskText);
    saveTask(taskText);

    taskInput.value = "";
}

// Create task element dynamically
function createTaskElement(taskText, isCompleted = false) {
    let li = document.createElement("li");

    let span = document.createElement("span");
    span.textContent = taskText;

    if (isCompleted) {
        span.classList.add("completed");
    }

    // Toggle complete
    span.addEventListener("click", function() {
        span.classList.toggle("completed");
        updateLocalStorage();
    });

    // Delete button
    let deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.classList.add("deleteBtn");

    deleteBtn.addEventListener("click", function() {
        li.remove();
        updateLocalStorage();
    });

    li.appendChild(span);
    li.appendChild(deleteBtn);
    taskList.appendChild(li);
}

// Save task to localStorage
function saveTask(taskText) {
    let tasks = JSON.parse(localStorage.getItem("tasks")) || [];
    tasks.push({ text: taskText, completed: false });
    localStorage.setItem("tasks", JSON.stringify(tasks));
}

// Load tasks from localStorage
function loadTasks() {
    let tasks = JSON.parse(localStorage.getItem("tasks")) || [];
    tasks.forEach(task => {
        createTaskElement(task.text, task.completed);
    });
}

// Update localStorage when tasks change
function updateLocalStorage() {
    let tasks = [];
    document.querySelectorAll("#taskList li").forEach(li => {
        let text = li.querySelector("span").textContent;
        let completed = li.querySelector("span").classList.contains("completed");
        tasks.push({ text: text, completed: completed });
    });

    localStorage.setItem("tasks", JSON.stringify(tasks));
}