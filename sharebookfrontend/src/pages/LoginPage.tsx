// LoginPage.tsx
import React, { useState } from 'react';
import { Button, FormControl, FormLabel, Input, VStack, Container } from '@chakra-ui/react';

interface LoginPageProps {
  onLogin: (username: string) => void;
}

const LoginPage: React.FC<LoginPageProps> = ({ onLogin }) => {
  const [username, setUsername] = useState<string>('');
  const [password, setPassword] = useState<string>('');

  const handleLogin = () => {
    // Perform authentication logic (e.g., check username and password)
    // For simplicity, let's assume the user is always authenticated
    onLogin(username);
  };

  return (
    <Container centerContent>
        <VStack spacing={4} align="center" justify="center" minHeight="100vh">
        <FormControl>
            <FormLabel>Username</FormLabel>
            <Input
            type="text"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
            placeholder="Enter your username"
            />
        </FormControl>
        <FormControl>
            <FormLabel>Password</FormLabel>
            <Input
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            placeholder="Enter your password"
            />
        </FormControl>
        <Button colorScheme="teal" onClick={handleLogin}>
            Login
        </Button>
        </VStack>
    </Container>
  );
};

export default LoginPage;