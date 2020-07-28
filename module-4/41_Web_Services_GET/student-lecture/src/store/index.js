import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  // When strict is set to true, state can ONLY be mutated from the store. This should be true.
  strict: true,

  // State contains the global application state. Think of it as app-wide data
  state: {
    filter: {
      searchText: "",
      difficulty: ""
    },    
    isAddQuestionVisible: false,
    questions: [],
  },

  // Mutations are used to make discrete changes to state from a central place
  mutations: {
    // Search-related mutations
    SET_SEARCH(state, search) {
      state.filter = search;
    },

    // Question List State
    SHOW_ADD_QUESTION(state) {
      state.isAddQuestionVisible = true;
    },
    HIDE_ADD_QUESTION(state) {
      state.isAddQuestionVisible = false;
    },
    
    // Add methods for Grading questions and setting answer visibility
    TOGGLE_ANSWER_VISIBILITY(state, id) {
      const question = state.questions.find(q => q.id === id);
      question.isAnswerVisible = !question.isAnswerVisible;
    },
    GRADE_QUESTION(state, payload) {
      const question = state.questions.find(q => q.id === payload.id);
      question.isCorrect = payload.isCorrect;
      question.isAnswerVisible = true;
    },

    // Add a method to add a question to the list of questions
    ADD_QUESTION(state, payload) {
      state.questions.push(cleanseQuestion(payload));
    },
    QUESTIONS_LOADED(state, payload) {
      state.questions = payload.map(q => cleanseQuestion(q));
    },
    QUESTION_UPDATED(state, payload) {
      const newQuestion = cleanseQuestion(payload);
      const index = state.questions.findIndex(q => q.id === newQuestion.id);

      if (index >= 0) {
        // Replace the old question with the new question
        state.questions.splice(index, 1, newQuestion);
      }
    },

  },

  // The items below are not covered by TE's curriculum, but recommended for larger apps

  // Getters provide encapsulation around application state by providing computed properties
  getters: {
  },
  // Actions typically commit one or more mutation and can be used to coordinate complex operations
  actions: {
  },
  // Modules are used to group together groups of complex state
  modules: {
  }
})

function cleanseQuestion(question) {
  question.isAnswerVisible = false;
  question.isCorrect = null;

  return question;
}