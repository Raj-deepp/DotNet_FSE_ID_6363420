function SayWelcome(){
  const greet = (message) =>{
    alert(message);
  };

  return (
    <button onClick={() => greet("Welcome")}>Say Welcome</button>
  );
}

export default SayWelcome;
