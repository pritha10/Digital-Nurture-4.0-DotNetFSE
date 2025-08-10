// src/components/ListofPlayers.js
import React from 'react';

const ListofPlayers = () => {
    const players = [
        { name: "Virat", score: 95 },
        { name: "Rohit", score: 89 },
        { name: "Dhoni", score: 99 },
        { name: "Pant", score: 65 },
        { name: "Kohli", score: 45 },
        { name: "Bumrah", score: 72 },
        { name: "Jadeja", score: 67 },
        { name: "Gill", score: 81 },
        { name: "Rahul", score: 54 },
        { name: "Iyer", score: 75 },
        { name: "Shami", score: 66 },
    ];

    const filtered = players.filter(player => player.score < 70);

    return (
        <div>
            <h2>All Players:</h2>
            <ul>
                {players.map((p, index) => (
                    <li key={index}>{p.name} - {p.score}</li>
                ))}
            </ul>

            <h2>Players with score below 70:</h2>
            <ul>
                {filtered.map((p, index) => (
                    <li key={index}>{p.name} - {p.score}</li>
                ))}
            </ul>
        </div>
    );
};

export default ListofPlayers;
