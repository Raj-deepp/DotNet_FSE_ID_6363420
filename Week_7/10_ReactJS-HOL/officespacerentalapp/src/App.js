function App() {
  const heading = "Office Space at Affordable Range";

  const officeList = [
    {
      name: 'DBS',
      rent: 50000,
      address: 'Chennai',
      image: 'https://officebanao.com/wp-content/uploads/2024/06/office-with-lot-desks-computers.jpg'
    },
    {
      name: 'EcoOffice',
      rent: 65000,
      address: 'Kolkata',
      image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZPFv3KqBOfVxnr2C_vVoqNMMlLYgM_DUcgA&s'
    },
    {
      name: 'WorkNest',
      rent: 46000,
      address: 'Bangalore',
      image: 'https://media.istockphoto.com/id/1141421616/photo/this-office-space-is-filled-with-productivity.jpg?s=612x612&w=0&k=20&c=ka6rGPcVkhjC2cG-ICEQaE7mzufJ253bngJPahvBlCg='
    }
  ];

  return (
    <div>
      <h1 style={{paddingLeft: '10px'}}>{heading}</h1>
      {officeList.map((office, index) => (
        <div key={index} style={{ border: '1px solid grey', padding: '5px', margin: '10px' }}>
          <img src={office.image} alt={office.name} style={{ width: '300px', height: '150px' }} />
          <h2>{office.name}</h2>
          <p>{office.address}</p>
          <p style={{ color: office.rent < 60000 ? 'red' : 'green' }}>
            Rent: ₹{office.rent}
          </p>
        </div>
      ))}
    </div>
  );
}

export default App;
