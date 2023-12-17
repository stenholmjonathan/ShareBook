import React, { useEffect, useState } from "react";
import apiClient from "../services/api-client";
import { list } from "@chakra-ui/react";

interface BlogPosts {
  id: number;
  subject: string;
  message: string;
  profileId: number;
}

// interface to create the shape of the response object
interface FetchBlogPostsResponse {
  results: BlogPosts[];
}

const BlogPost_2 = () => {
  const [blogposts, setBlogPosts] = useState<BlogPosts[]>([]); // state variable where saving the objects
  const [error, setError] = useState(""); // variable for error messages

  // effectHook, to send a fetch request to the backend
  const fetchData = async () => {
    try {
      const response = await apiClient.get<FetchBlogPostsResponse>(
        "/BlogPost/GetAllBlogPosts"
      );
      setBlogPosts(response.data.results);
    } catch (error) {
      setError("error.message");
    }
  };

  useEffect(() => {
    fetchData();
  }, []); // <-- empty dependency array

  return (
    <ul>
      {blogposts.map((blogpost) => (
        <li key={blogpost.id}>{blogpost.subject}</li>
      ))}
    </ul>
  );
};

export default BlogPost_2;
