function SyntheticEvent(){
  const handleClick= (e) => {
    e.preventDefault();
    alert("I was clicked");
  };

  return (
    <button onClick={handleClick}>Click Me</button>
  );
}

export default SyntheticEvent;