import { Grid, GridItem, Show } from "@chakra-ui/react";
import Profiles from "./components/Profiles.tsx";
import BlogPosts from "./components/BlogPosts.tsx";
import NavBar from "./components/NavBar.tsx";

function App() {
  return (
    <Grid
      templateAreas={{
        base: `"nav main"`,
        lg: `"nav nav" "aside main"`,
      }}
    >
      <GridItem area="nav" bg="lightblue">
        <NavBar />
      </GridItem>
      <Show above="lg">
        <GridItem area="aside" bg="pink">
          Aside
        </GridItem>
      </Show>
      <GridItem area="main" bg="#3182CE">
        Main
      </GridItem>
      <Profiles />
      <BlogPosts />
    </Grid>
  );
}

export default App;
