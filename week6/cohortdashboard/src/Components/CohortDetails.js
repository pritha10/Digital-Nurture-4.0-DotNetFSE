import React from 'react';
import styles from './CohortDetails.module.css';


function CohortDetails(props) {
  const { cohortName, mentor, status, startDate, endDate } = props;

  const headingStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{cohortName}</h3>
      <dl>
        <dt>Mentor:</dt>
        <dd>{mentor}</dd>
        <dt>Status:</dt>
        <dd>{status}</dd>
        <dt>Start Date:</dt>
        <dd>{startDate}</dd>
        <dt>End Date:</dt>
        <dd>{endDate}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
