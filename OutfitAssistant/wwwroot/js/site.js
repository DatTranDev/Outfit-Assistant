//Function: show the personalization form
//document.addEventListener("DOMContentLoaded", function () {
//    document.querySelector('.dropdown-item-personalization').addEventListener('click', function (event) {
//        event.preventDefault();
//        document.getElementById('personalizationForm').style.display = 'block';
//    });
//});
//nav tab funtion
$(document).ready(function () {

    $("#tile-1 .nav-tabs a").click(function () {

        var position = $(this).parent().position();

        var width = $(this).parent().width();

        $("#tile-1 .slider").css({ "left": + position.left, "width": width });

    });
    var actWidth = $("#tile-1 .nav-tabs").find(".active").parent("li").width();

    var actPosition = $("#tile-1 .nav-tabs .active").position();

    $("#tile-1 .slider").css({ "left": + actPosition.left, "width": actWidth });

});      
//Chatbot region
const chatInput = document.querySelector(".chat-input textarea");
const sendChatBtn = document.querySelector(".chat-input span");
const chatbox = document.querySelector(".chatbox");
const chatbotToggler = document.querySelector(".chatbot-toggler");

let userMessage;
const API_KEY = "";
const inputInitHeight = chatInput.scrollHeight;

const createChatLi = (message, className) => {
    //Create a chat <li> elements with passed messsage and className
    const chatLi = document.createElement("li");
    chatLi.classList.add("chat", className);
    let chatContent = className === "outgoing" ? `<p></p>` : `<span class="material-symbols-outlined">smart_toy</span><p></p>`;
    chatLi.innerHTML = chatContent;
    chatLi.querySelector("p").textContent = message;
    return chatLi;
}

const generateRespone = (incomingChatLi) => {
    const API_URL = "https://api.openai.com/v1/chat/completions";
    const messageElement = incomingChatLi.querySelector("p");

    const requestOptions = {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            "Authorization": `Bearer ${API_KEY}`
        },
        body: JSON.stringify({
            model: "gpt-3.5-turbo",
            messages: [{ role: "user", content: userMessage}]
        })
    }

    //Send POST request to API, get respone
    fetch(API_URL, requestOptions).then(res => res.json()).then(data => {
        messageElement.textContent = data.choices[0].message.content;
    }).catch((error) => {
        messageElement.classList.add("error");
        messageElement.textContent = "Oops! Something went wrong. Please try again.";
    }).finaly(() => chatbox.scrollTo(0, chatbox.scrollHeight));
}

const handleChat = () => {
    userMessage = chatInput.value.trim();
    if (!userMessage) return;
    chatInput.value = "";
    chatInput.style.height = `${inputInitHeight}px`;
    //Append the user's message to the chatbox
    chatbox.appendChild(createChatLi(userMessage, "outgoing"));
    chatbox.scrollTo(0, chatbox.scrollHeight);

    setTimeout(() => {
        //Display "Thinking..." message while waiting for the respone
        const incomingChatLi = createChatLi("Thinking...", "incoming");
        chatbox.appendChild(incomingChatLi);
        generateRespone(incomingChatLi);
    }, 600);
}
chatInput.addEventListener("input", () => {
    chatInput.style.height = `${inputInitHeight}px`;
    chatInput.style.height = `${chatInput.scrollHeight}px`;
});
chatInput.addEventListener("keydown", (e) => {
    if (e.key == "Enter" && !e.shiftKey && window.innerWidth > 600) {
        e.preventDefault();
        handleChat();
    }
});

chatbotToggler.addEventListener("click", () => document.body.classList.toggle("show-chatbot"));
sendChatBtn.addEventListener("click", handleChat);

//Product Region

const productCards = document.querySelectorAll('.product-card');
function handleCardClick(event) {
    const url = event.currentTarget.getAttribute('data-url');

    if (url) {
        window.location.href = url;
    }
}

// Attach click event listeners to each cart icon
productCards.forEach(card => {
    card.addEventListener('click', handleCardClick);
});
