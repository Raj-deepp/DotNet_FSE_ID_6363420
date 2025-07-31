import { useState } from 'react';

function CurrencyConvertor(){
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState('');

  const handleSubmit= () => {
    const euroValue= (parseFloat(rupees) / 100.079).toFixed(4);
    setEuros(euroValue);
    EuroAmt(`Converted value to Euro is: ${euroValue}`)
  };

  const EuroAmt= (amt) => {
    alert(amt);
  };

  return (
    <div>
      <input
        type="number"
        placeholder="Enter amount in Rs."
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
      />
      <button onClick={handleSubmit}>Convert</button>
      <h3>Converted Amount: € {euros}</h3>
    </div>
  );
}

export default CurrencyConvertor;