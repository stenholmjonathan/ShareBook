import React from "react";
import axios from "axios";
import BlogPost from "../models/BlogPost";

export default class BlogPosts extends React.Component {
  state = {
    blogposts: [] as BlogPost[], // Explicitly initialize with an empty array of Profile type
  };

  componentDidMount() {
    axios
      .get<BlogPost[]>("https://localhost:7179/BlogPost/GetAllBlogPosts")
      .then((res) => {
        const blogposts = res.data;
        this.setState({ blogposts });
      })
      .catch((error) => {
        console.error("Error fetching profiles:", error);
      });
  }

  render() {
    return (
      <ul>
        {this.state.blogposts.map((blogposts) => (
          <li key={blogposts.id}>
            ID: {blogposts.id}, Subject: {blogposts.subject}, Message:
            {blogposts.message}
          </li>
        ))}
      </ul>
    );
  }
}
