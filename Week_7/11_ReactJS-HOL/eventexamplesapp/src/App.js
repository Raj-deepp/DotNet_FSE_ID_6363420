import Counter from './components/Counter';
import SayWelcome from './components/SayWelcome';
import SyntheticEvent from './components/SyntheticEvent';

function App(){
  return (
    <div className="App">
      <Counter />
      <SayWelcome />
      <SyntheticEvent />
    </div>
  );
}

export default App;