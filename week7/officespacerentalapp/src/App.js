import React from 'react';
import './App.css';

function App() {
  // Step 1: Create a heading using JSX
  const heading = <h1>Office Space Rental App</h1>;

  // Step 2: Image Attribute
  const imageUrl = "https://via.placeholder.com/400x200";

  // Step 3: Office Object
  const office = {
    name: "WorkHub",
    rent: 55000,
    address: "Andheri East, Mumbai"
  };

  // Step 4: Array of Office Objects
  const officeList = [
    { name: "WeSpace", rent: 75000, address: "Bandra West" },
    { name: "TechNest", rent: 40000, address: "Vikhroli" },
    { name: "InnoSpace", rent: 62000, address: "Powai" },
  ];

  return (
    <div className="App">
      {heading}
      <img src={imageUrl} alt="Office" width="400" height="200" />

      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {office.name}</p>
      <p><strong>Rent:</strong> 
        <span style={{ color: office.rent < 60000 ? 'red' : 'green' }}>
          ₹{office.rent}
        </span>
      </p>
      <p><strong>Address:</strong> {office.address}</p>

      <h2>Available Offices</h2>
      <ul>
        {officeList.map((item, index) => (
          <li key={index}>
            <p><strong>Name:</strong> {item.name}</p>
            <p><strong>Rent:</strong> 
              <span style={{ color: item.rent < 60000 ? 'red' : 'green' }}>
                ₹{item.rent}
              </span>
            </p>
            <p><strong>Address:</strong> {item.address}</p>
            <hr />
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
