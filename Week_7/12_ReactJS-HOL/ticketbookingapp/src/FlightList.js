const flights = [
  {id: 1, airline: 'IndiGo', from: 'Delhi', to: 'Mumbai', price: '₹4500'},
  {id: 2, airline: 'Air India', from: 'Bangalore', to: 'Chennai', price: '₹3800'},
  {id: 3, airline: 'SpiceJet', from: 'Kolkata', to: 'Hyderabad', price: '₹4200'}
];

function FlightList({showBooking}){
  return (
    <div>
        <ul>
            {flights.map((flight) => (
                <li key={flight.id}>
                    {flight.airline} {'->'} {flight.from} to {flight.to} - {flight.price}
                    {showBooking && <button>Book</button>}
                </li>
            ))}
        </ul>
    </div>
  );
}

export default FlightList;
