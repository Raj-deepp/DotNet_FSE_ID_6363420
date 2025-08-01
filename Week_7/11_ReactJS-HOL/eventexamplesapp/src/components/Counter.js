import React, { useState } from 'react';

function Counter(){
  const [count, setCount] = useState(0);

  const increment= () => {
    setCount(count + 1);
    sayHello();
    displayMessage();
  };

  const decrement= () => setCount(count - 1);

  const sayHello= () => console.log("Hello");
  const displayMessage= () => console.log("Counter Updated!");

  return (
    <div className="cnt">
      <h2>Counter: {count}</h2>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>
    </div>
  );
}

export default Counter;