import React from "react";
import axios from "axios";

export default class BlogPosts extends React.Component {
  state = {
    blogposts: [],
  };

  componentDidMount() {
    axios.get(`https://localhost:7179/BlogPost/GetAllBlogPosts`).then((res) => {
      const blogposts = res.data;
      this.setState({ blogposts });
    });
  }

  render() {
    return (
      <ul>
        {this.state.blogposts.map((blogposts) => (
          <li key={blogposts["id"]}>{blogposts["subject"]}</li>
        ))}
      </ul>
    );
  }
}
