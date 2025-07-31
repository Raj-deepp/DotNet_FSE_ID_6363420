import './App.css';
import Counter from './components/Counter';
import SayWelcome from './components/SayWelcome';
import SyntheticEvent from './components/SyntheticEvent';
import CurrencyConvertor from './components/CurrencyConvertor';

function App(){
  return (
    <div className="App">
      <Counter />
      <SayWelcome />
      <SyntheticEvent />
      <h1>Currency Converter !!!</h1>
      <CurrencyConvertor />
    </div>
  );
}

export default App;