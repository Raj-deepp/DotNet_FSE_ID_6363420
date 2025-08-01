import {Link} from "react-router-dom";

function TrainerList({ trainers }){
  return (
    <div>
      <h2>Trainers List</h2>
      <ul>
        {trainers.map(t =>(
          <li key={t.trainerId}>
            <Link to={`/trainers/${t.trainerId}`}>{t.name}</Link>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default TrainerList;