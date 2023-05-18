//"use strict";

//var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//console.log(connection);
//document.getElementById("sendButton").disabled = true;

//connection.start().then(function () {
//    document.getElementById("sendButton").disabled = false;
//}).catch(function (err) {
//    return console.error(err.toString());
//});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value;
//    var message = document.getElementById("messageInput").value;
//    connection.invoke("SendMessage", user, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});


var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();


connection.on("ReceiveMessage", function (username, message) {
let li = `<li class="list-group-item">
                    <b>${username}</b>
                    <p>${message}</p>
                </li>`;
document.getElementById("messages").innerHTML += li;
});

connection.start().then(function () {
    if (localStorage.getItem("user")) {
        ShowArea();
        let user = JSON.parse(localStorage.getItem("user"));
        connection.invoke("AddGroup",  user.group);
    }
}).catch(function (err) {
    return console.error(err.toString());
});



let enterGroupForm = document.getElementById("enterGroupForm");
let leaveGroupBtn = document.getElementById("leaveGroupBtn");
let sendMessageForm = document.getElementById("sendMessageForm");


enterGroupForm.addEventListener("submit", function (e) {
    e.preventDefault();
    ShowArea();
    let user = {
        username: document.getElementById("username").value,
        group: document.getElementById("group").value,
    }
    connection.invoke("AddGroup", user.group);
    localStorage.setItem("user", JSON.stringify(user));
});

leaveGroupBtn.addEventListener("click", function () {
    let user = JSON.parse(localStorage.getItem("user"));
    connection.invoke("RemoveGroup", user.group);
    localStorage.removeItem("user");
    document.getElementById("messageArea").classList.add("d-none");
    document.getElementById("joinArea").classList.remove("d-none");
});

sendMessageForm.addEventListener("submit", function (e) {
    e.preventDefault();
    let user = JSON.parse(localStorage.getItem("user"));
    let message = document.getElementById("message").value;
    connection.invoke("SendMessage", user.username, user.group, message);
});


function ShowArea() {
    document.getElementById("messageArea").classList.remove("d-none");
    document.getElementById("joinArea").classList.add("d-none");
}


