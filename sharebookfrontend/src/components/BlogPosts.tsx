import React from "react";
import axios from "axios";
import BlogPost from "../models/BlogPost";
import { Center } from "@chakra-ui/react";

export default class BlogPosts extends React.Component {
  state = {
    blogposts: [] as BlogPost[], // Explicitly initialize with an empty array of Profile type
  };

  componentDidMount() {
    axios
      .get<BlogPost[]>(
        "https://localhost:7179/BlogPost/GetBlogPostById?profileId=1"
      )
      .then((res) => {
        const blogposts = res.data;
        this.setState({ blogposts });
      })
      .catch((error) => {
        console.error("Error fetching profiles:", error);
      });
  }
  // gör en egen component, rendera arrayen med componenten
  render() {
    return (
      <ul>
        {this.state.blogposts.map((blogposts) => (
          <li key={blogposts.id}>
            <article>
              Profile ID: {blogposts.profileId}, Subject: {blogposts.subject},
              Message: {blogposts.message}
            </article>
          </li>
        ))}
      </ul>
    );
  }
}
