import React, { useState } from 'react';

const EventExamples = () => {
  const [count, setCount] = useState(0);

  // Multiple methods for increment
  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const sayHello = () => {
    console.log("Hello! You clicked Increase.");
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayWelcome = (message) => {
    alert(`Message: ${message}`);
  };

  const handleClick = (e) => {
    console.log("Synthetic Event Triggered:", e);
    alert("I was clicked");
  };

  return (
    <div>
      <h2>React Event Handling</h2>
      <p>Counter: {count}</p>
      <button onClick={increment}>Increase</button>
      <button onClick={decrement}>Decrease</button>

      <br /><br />
      <button onClick={() => sayWelcome("Welcome to React!")}>Say Welcome</button>

      <br /><br />
      <button onClick={handleClick}>Synthetic Event Button</button>
    </div>
  );
};

export default EventExamples;
