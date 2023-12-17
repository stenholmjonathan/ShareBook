import { Grid, GridItem, Show } from "@chakra-ui/react";
import { Route, Routes } from "react-router-dom";
import Home from "./Pages/Home.tsx";
import Login from "./Pages/Login.tsx";
import Profiles from "./components/Profiles.tsx";
import BlogPosts from "./components/BlogPosts.tsx";
import BlogPost_2 from "./components/BlogPost_2.tsx";
import NavBar from "./components/NavBar.tsx";

function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/" element={<Login />} />
      </Routes>
      <Grid
        templateAreas={{
          base: `"nav" "main"`,
          lg: `"nav" "main"`,
        }}
      >
        <GridItem area="nav" bg="lightblue">
          <NavBar />
        </GridItem>
        <GridItem area="main" bg="#3182CE">
          <BlogPost_2 />
        </GridItem>
      </Grid>
    </>
  );
}

export default App;
