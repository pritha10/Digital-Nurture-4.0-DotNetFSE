// src/App.js
import React from 'react';
import ListofPlayers from './components/ListofPlayers';
import IndianPlayers from './components/IndianPlayers';

function App() {
    const flag = true; // Toggle between true/false to display components conditionally

    return (
        <div className="App">
            <h1>🏏 Cricket App</h1>
            {flag ? <ListofPlayers /> : <IndianPlayers />}
        </div>
    );
}

export default App;
