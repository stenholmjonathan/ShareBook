import React from 'react';
import { Container, Text } from '@chakra-ui/react';
import BlogPost from '../models/BlogPost';

interface BlogPostComponentProps {
  blogPost: BlogPost;
}

const BlogPostComponent: React.FC<BlogPostComponentProps> = ({ blogPost }) => {
  return (
    <Container maxW="xl" bg="gray.100" p={6} my={4} borderRadius="md">
      <Text as="h2" fontSize="xl" fontWeight="bold" mt={2}>
        {blogPost.subject}
      </Text>
      <Text mt={2}>{blogPost.message}</Text>
    </Container>
  );
};

export default BlogPostComponent;