import { useState } from "react";
import Guest from "./Guest";
import User from "./User";

function LoginControl(){
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick= () => setIsLoggedIn(true);
  const handleLogoutClick= () => setIsLoggedIn(false);

  return (
    <div>
      {isLoggedIn ? <User /> : <Guest />}
      {isLoggedIn ? (
        <button onClick={handleLogoutClick}>Logout</button>
      ) : (
        <button onClick={handleLoginClick}>Login</button>
      )}
    </div>
  );
}

export default LoginControl;
