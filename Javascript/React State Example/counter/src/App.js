import React, { useState } from 'react';

function Counter() {
  // Define a piece of state using the 'useState' hook
  const [count, setCount] = useState(0);

  // Define a function to handle incrementing the count
  const increment = () => {
    setCount(count + 1);
  };

  // Define a function to handle decrementing the count
  const decrement = () => {
    setCount(count - 1);
  };

  return (
    <main>
      <div class="counter">
        <div class="number">
          <h1>Count: {count}</h1>
        </div>
        <div class="buttons">
          <button onClick={decrement}>-</button>
          <button onClick={increment}>+</button>
        </div>
      </div>
    </main>
  );
}

export default Counter;
