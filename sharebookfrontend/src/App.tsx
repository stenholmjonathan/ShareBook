// App.tsx
import React, { useState, useEffect } from 'react';
import LoginPage from './pages/LoginPage';
import BlogPosts from './components/BlogPosts.tsx';
import { Grid, GridItem } from '@chakra-ui/react';
import NavBar from './components/NavBar.tsx';

const App: React.FC = () => {
  const [user, setUser] = useState<string | null>(null);

  useEffect(() => {
    // Check if the username is already in localStorage on component mount
    const storedUsername = localStorage.getItem('username');
    if (storedUsername) {
      setUser(storedUsername);
    }
  }, []);

  const handleLogin = (username: string) => {
    localStorage.setItem('username', username);
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