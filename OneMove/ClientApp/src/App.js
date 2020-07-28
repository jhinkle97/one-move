import React, { useContext } from "react";
import { Route, Redirect, Switch } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import { FetchData } from "./components/FetchData";
import { Counter } from "./components/Counter";
import Login from "./components/Login";
import "./custom.css";

const App = () => {
  return (
    <>
      <Redirect from="/" to="/login" />
      <Switch>
        <Route path="/login" component={Login} />
        <Layout>
          <Route exact path="/" component={Home} />
          <Route path="/counter" component={Counter} />
          <Route path="/fetch-data" component={FetchData} />
        </Layout>
      </Switch>
    </>
  );
};
export default App;
