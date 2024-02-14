// App.tsx
import React, { useState, useEffect } from 'react';
import LoginPage from './components/Login.tsx';
import BlogPosts from './components/BlogPosts.tsx';
import { Grid, GridItem } from '@chakra-ui/react';
import NavBar from './components/NavBar.tsx';

const App: React.FC = () => {
  const [user, setUser] = useState<string | null>(null);

  useEffect(() => {
    // Check if the username is already in localStorage on component mount
    const storedUsername = localStorage.getItem('username');
    console.log("App.tsx - useEffect: User name är inte satt: " + storedUsername)
    if (storedUsername) {
      console.log("App.tsx - useEffect: User name är satt: " + storedUsername)
      setUser(storedUsername);
    }
  }, []);

  const handleLogin = (username: string) => {
    localStorage.setItem('username', username);
    console.log("App.tsx - HandleLogin: Här sparas username i localstorage")
    setUser(username);
  };

  return (
    <Grid
      templateAreas={{
        base: `"nav" "main"`,
        lg: `"nav" "main"`,
      }}
    >
      <GridItem area="nav" bg="lightblue">
        <NavBar />
      </GridItem>
      <GridItem>
        {user ? <BlogPosts /> : <LoginPage onLogin={handleLogin} />}
      </GridItem>
    </Grid>
  );
};

export default App;