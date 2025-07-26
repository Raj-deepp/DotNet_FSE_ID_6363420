import React from 'react';

const IndianPlayers = () => {
  const T20players = ["Kohli", "Rohit", "Hardik", "Pant"];
  const RanjiPlayers = ["Pujara", "Saha", "Iyer", "Thakur"];

  const allPlayers = [...T20players, ...RanjiPlayers];

  const oddTeam = allPlayers.filter((_, idx) => idx % 2 === 0);
  const evenTeam = allPlayers.filter((_, idx) => idx % 2 !== 0);

  return (
    <div>
      <h2>Merged Players</h2>
      <ul>
        {allPlayers.map((p, i) => <li key={i}>{p}</li>)}
      </ul>

      <h3>Odd Team</h3>
      <ul>{oddTeam.map((p, i) => <li key={i}>{p}</li>)}</ul>

      <h3>Even Team</h3>
      <ul>{evenTeam.map((p, i) => <li key={i}>{p}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;
