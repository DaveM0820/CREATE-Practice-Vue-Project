import axios from 'axios';

// Create a base Axios instance for API calls
const apiClient = axios.create({
  baseURL: 'http://localhost:8000', // will replace with backend server URL
  withCredentials: false, 
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json'
  }
});

export default {
  // Method to retrieve data from the backend
  getData() {
    return apiClient.get('/path-to-get-resource'); // will replace with  actual GET API path
  },

  // Method to send data to the backend
  postData(data) {
    return apiClient.post('/path-to-post-resource', data); // will replace with actual POST API path
  },

};
