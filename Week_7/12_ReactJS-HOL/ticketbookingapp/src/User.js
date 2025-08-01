import FlightList from './FlightList';

function User(){
  return (
    <div>
      <h2 >Welcome User!</h2>
      <p>You can now book your flight.</p>
      <FlightList showBooking={true} />
    </div>
  );
}

export default User;
