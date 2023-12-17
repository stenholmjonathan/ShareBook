import axios from "axios";

// create an axios instance with a custom configuration
export default axios.create({
    baseURL: 'https://localhost:7179'
}) 