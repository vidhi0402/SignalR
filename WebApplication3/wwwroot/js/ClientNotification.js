"use strict"
var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();
connection.start();
connection.on("ReceiveMsg", function (employees) {
    var li = document.createElement("li");
    li.textContent = employees;
    document.getElementById("msglist").appendChild(li);
})
