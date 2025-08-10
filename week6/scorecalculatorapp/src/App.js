import React from 'react';
import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore
        Name="Pritha Das"
        School="KIIT University"
        total={450}
        goal={500}
      />
    </div>
  );
}

export default App;
