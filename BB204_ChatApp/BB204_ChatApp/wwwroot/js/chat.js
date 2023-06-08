"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (message,senderId,date) {
    var me = `<div class="message text-only" style="display:flex; flex-direction: column; position:relative;">
                        <div class="response">
                            <p class="text"> ${message}</p>
                        </div>
                    <p class="response-time time" style="position:absolute; top:60px;right:-1px; "> ${date}</p>
                    </div>`;
    var other = `<div class="message">
                        <div class="photo" style="background-image: url(https://images.unsplash.com/photo-1438761681033-6461ffad8d80?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80);">
                            <div class="online"></div>
                        </div>
                        <p class="text"> ${message} </p>
                    </div>`;
    var id = document.getElementById("username").innerText;

    document.getElementById("messages").innerHTML += (senderId === id) ? me : other;
});

connection.on("Connected", function (username) {
    let id = "#" + username;
    $(id).addClass("online")
    $(id).removeClass("offline")
});


connection.on("Disconnected", function (username) {
    let id = "#" + username;
    $(id).addClass("offline")
    $(id).removeClass("online")
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

