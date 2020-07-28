import React, { createContext, useState } from "react";

export const AuthContext = createContext();
export const AuthProvider = (props) => {
  const [state, updateState] = useState(false);
  return (
    <AuthContext.Provider value={[state, updateState]}>
      {props.children}
    </AuthContext.Provider>
  );
};
