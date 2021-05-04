import React, { useEffect, useState } from 'react';

export default function App() {
  const [messages, setMessages] = useState([]);
  const [users, setUsers] = useState([]);

  useEffect(() => {
    fetch("messages")
      .then(data => data.json())
      .then(res => setMessages(res))
  }, []);

  useEffect(() => {
    fetch("users")
      .then(data => data.json())
      .then(res => setUsers(res))
  }, []);

  return (<>
    <h1>Users</h1>
    <ul>{users.map(user => {
      return (
        <p>{user.name}</p>
      )
    })

    }</ul>
    <h1>Messages</h1>
    <ul>{messages.map(msg => {
      return (<>
        <p>{msg.text}</p>
      </>)
    })}</ul>
    <input type="text" />
    <button>Send message</button>
  </>);

}
