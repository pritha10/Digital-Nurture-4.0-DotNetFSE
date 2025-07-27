import React from 'react';
import CohortDetails from './Components/CohortDetails';

function App() {
  const cohortData = [
    {
      cohortName: 'React Basics',
      mentor: 'John Doe',
      status: 'ongoing',
      startDate: '2025-07-01',
      endDate: '2025-08-01'
    },
    {
      cohortName: 'Advanced Java',
      mentor: 'Jane Smith',
      status: 'completed',
      startDate: '2025-05-01',
      endDate: '2025-06-15'
    }
  ];

  return (
    <div style={{ padding: '20px' }}>
      <h2>My Academy Cohorts</h2>
      {cohortData.map((cohort, index) => (
        <CohortDetails
          key={index}
          cohortName={cohort.cohortName}
          mentor={cohort.mentor}
          status={cohort.status}
          startDate={cohort.startDate}
          endDate={cohort.endDate}
        />
      ))}
    </div>
  );
}

export default App;
