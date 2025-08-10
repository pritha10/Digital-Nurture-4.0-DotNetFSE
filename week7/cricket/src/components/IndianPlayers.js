// src/components/IndianPlayers.js
import React from 'react';

const IndianPlayers = () => {
    const players = ["Virat", "Rohit", "Pant", "Dhoni", "Gill", "Shami"];
    const [p1, p2, p3, p4, p5, p6] = players;

    const oddTeam = [p1, p3, p5];
    const evenTeam = [p2, p4, p6];

    const T20Players = ["Hardik", "Surya", "Arshdeep"];
    const RanjiTrophyPlayers = ["Pujara", "Rahane"];

    const allPlayers = [...T20Players, ...RanjiTrophyPlayers]; // Merge using ES6

    return (
        <div>
            <h2>Odd Team:</h2>
            <ul>{oddTeam.map((player, idx) => <li key={idx}>{player}</li>)}</ul>

            <h2>Even Team:</h2>
            <ul>{evenTeam.map((player, idx) => <li key={idx}>{player}</li>)}</ul>

            <h2>Merged Team (T20 + Ranji):</h2>
            <ul>{allPlayers.map((player, idx) => <li key={idx}>{player}</li>)}</ul>
        </div>
    );
};

export default IndianPlayers;
