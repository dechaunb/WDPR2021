"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

// connection.on("ReceiveMessage", function (user, message) {
//     var li = document.createElement("li");
//     // document.getElementById("messagesList").appendChild(li);
//     // We can assign user-supplied strings to an element's textContent because it
//     // is not interpreted as markup. If you're assigning in any other way, you 
//     // should be aware of possible script injection concerns.
//     // li.textContent = `${user} says ${message}`;

//     var element = document.getElementById("messagesList");
//     element.scrollTop = element.scrollHeight;

// });

connection.start().then(function () {
    connection.invoke("GetConnectionId").then(function(id){
        document.getElementById("connectionId").innerText=id;
    })
    // connection.invoke("OnConnectedAsync");
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {

    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var receiver = document.getElementById("targetInput").value;
    connection.invoke("SendPrivateMessage", user, receiver ,message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
    const url ="/Message/PersonalMessageCreate?contentstring="+message+"&receiver="+receiver+"&sender="+user
    console.log(url)
    fetch(url).then(r => {
        if(r.status != 201)
            throw "Status: " + r.status;
        else console.log(r)
    }).catch(err=>console.log(err))
});
