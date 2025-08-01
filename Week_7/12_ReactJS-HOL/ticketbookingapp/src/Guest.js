import FlightList from './FlightList';

function Guest(){
  return (
    <div>
      <h2>Welcome Guest!</h2>
      <p>Please login to book your flight.</p>
      <FlightList showBooking={false} />
    </div>
  );
}

export default Guest;