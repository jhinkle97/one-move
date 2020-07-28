import React, { useContext } from "react";
import { AuthContext } from "../ContextProvider";
import { Button } from "react-bootstrap";

const Login = (props) => {
  const [isAuthenticated, setAuthenticated] = useContext(AuthContext);
  return (
    <>
      <Button
        style={{ height: 100, width: 100 }}
        onClick={() => {
          setAuthenticated(!isAuthenticated);
        }}
      >
        {String(isAuthenticated)}
      </Button>
      <Button
        style={{ height: 100, width: 100 }}
        onClick={() => {
          // setAuthenticated(!isAuthenticated);
          props.history.push("/");
        }}
      >
        {String(isAuthenticated)}
      </Button>
    </>
  );
};
export default Login;
