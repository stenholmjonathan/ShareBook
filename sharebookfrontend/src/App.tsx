import { Grid, GridItem, Show } from "@chakra-ui/react";
import { Route, Routes } from "react-router-dom";
import BlogPosts from "./components/BlogPosts.tsx";
import NavBar from "./components/NavBar.tsx";

function App() {
  return (
    <>
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
          <BlogPosts />
        </GridItem>
      </Grid>
    </>
  );
}

export default App;
