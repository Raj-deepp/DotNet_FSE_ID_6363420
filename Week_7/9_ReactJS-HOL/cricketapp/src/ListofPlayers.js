import React from 'react';

const players = [
  { name: 'Virat', score: 85 },
  { name: 'Rohit', score: 95 },
  { name: 'Rahul', score: 65 },
  { name: 'Shreyas', score: 70 },
  { name: 'Rishabh', score: 50 },
  { name: 'Hardik', score: 87 },
  { name: 'Bumrah', score: 35 },
  { name: 'Jadeja', score: 78 },
  { name: 'Bhuvneshwar', score: 45 },
  { name: 'Shami', score: 82 },
  { name: 'Chahal', score: 58 },
];

const ListofPlayers = () => {
  const below70 = players.filter(p => p.score < 70);

  return (
    <div>
      <h2>Players List</h2>
      <ul>
        {players.map((p, i) => (
          <li key={i}>{p.name} - {p.score}</li>
        ))}
      </ul>

      <h3>Players with Score below 70</h3>
      <ul>
        {below70.map((p, i) => (
          <li key={i}>{p.name} - {p.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;