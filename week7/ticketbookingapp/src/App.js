import React, { useState } from 'react';
import Guest from './components/Guest';
import User from './components/User';


function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => {
    setIsLoggedIn(true);
  }

  const handleLogout = () => {
    setIsLoggedIn(false);
  }

  let content;
  if (isLoggedIn) {
    content = <User />;
  } else {
    content = <Guest />;
  }

  return (
    <div className="App">
      <h1>✈️ Ticket Booking App</h1>

      {/* Conditional Button Display */}
      {isLoggedIn ? (
        <button onClick={handleLogout}>Logout</button>
      ) : (
        <button onClick={handleLogin}>Login</button>
      )}

      {/* Conditional Component Render */}
      {content}
    </div>
  );
}

export default App;
