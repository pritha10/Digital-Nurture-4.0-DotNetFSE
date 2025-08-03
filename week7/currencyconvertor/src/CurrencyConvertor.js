// src/CurrencyConvertor.js
import React, { useState } from 'react';

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    const converted = (parseFloat(rupees) / 90).toFixed(2); // Assuming 1 Euro ≈ 90 INR
    setEuro(converted);
  };

  return (
    <div>
      <h2>Currency Convertor</h2>
      <form onSubmit={handleSubmit}>
        <label>Enter amount in INR:</label><br />
        <input
          type="number"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
          required
        />
        <button type="submit">Convert</button>
      </form>
      {euro && <p>{rupees} INR = {euro} EUR</p>}
    </div>
  );
};

export default CurrencyConvertor;
