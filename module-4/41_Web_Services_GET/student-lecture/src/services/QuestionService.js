import axios from 'axios';

// This is a path to the application we'll be communicating with. It can be any server
// that can handle REST requests.
const myServerUrl = 'https://sallythesquirrelservice.azurewebsites.net';

// If you're curious about what data is on the server, open https://sallythesquirrelservice.azurewebsites.net/questions in your browser

// Create our Axios instance used to communicate with the server
const http = axios.create({
  // Requests are all handled as relative to the base URL. This helps us not need to specify
  // a base path every time we make a request and keeps our code simple
  baseURL: myServerUrl
});

export default {

    /**
     * Gets all questions on the server
     * @returns {Promise} a promise that will complete with a list of questions
     */
    getAllQuestions() {
      return http.get('/questions');
    },
  
    /**
     * Gets a specific question from the server
     * @returns {Promise} a promise that will complete with information on that question
     */
    getQuestion(id) {
      return http.get(`/questions/${id}`);
    },
  
    /**
     * Updates a question on the server with new values
     * @param {Object} question the question to update
     * @returns {Promise} a promise that will complete with information on the updated question
     */
    update(question) {
      return http.put(`/questions/${question.id}`, question);
    },

    /**
     * Creates a new question on the server
     * @param {Object} question the question to create
     * @returns {Promise} a promise that will complete with information on the updated question
     */
    create(question) {
      return http.post('/questions', question);
    },
  
    /**
     * Deletes an existing question on the server
     * @param {Object} question the question to delete
     * @returns {Promise} a promise that will complete with status of the request
     */
    delete(question) {
      return http.delete(`/questions/${question.id}`);
    }

  };