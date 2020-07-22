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
    questions: [
      {
        id: 1,
        question: "What is the Sealed Keyword?",
        answer: "The sealed keyword prevents a class from being inherited.",
        difficulty: 2
      },
      {
        id: 2,
        question: "What is the Virtual Keyword?",
        answer: "The virtual keyword allows a method to be overridden in an inheriting class.",
        difficulty: 1
      },
      {
        id: 3,
        question: "What do you need to do to override a method in C#?",
        answer: "Mark the method as virtual, inherit from the class, and use the overrides keyword to override it in the inheriting class.",
        difficulty: 2
      },
      {
        id: 4,
        question: "What are the major unit test frameworks for .NET?",
        answer: "MSTest, XUnit, and NUnit",
        difficulty: 2
      },
      {
        id: 5,
        question: "How does a Unit Test Work?",
        answer: "The test runner discovers and calls each test method. If an exception occurs and is unhandled, the test fails. Asserts throw exceptions when they fail.",
        difficulty: 3
      },
      {
        id: 6,
        question: "What is the purpose of semantic HTML?",
        answer: "Semantic HTML helps tools understand the structure of a web page",
        difficulty: 1
      }
    ],
  },
  // Mutations are used to make discrete changes to state from a central place
  mutations: {
    ADD_QUESTION(state, question) {
      state.questions.push(question);
      state.isAddQuestionVisible = false;
    },
    SHOW_ADD_QUESTION(state) {
      state.isAddQuestionVisible = true;
    },
    HIDE_ADD_QUESTION(state) {
      state.isAddQuestionVisible = false;
    },
    SET_SEARCH(state, search) {
      state.filter = search;
    }
  },
  // Getters provide encapsulation around application state by providing computed properties
  getters: {
  },

  // The two items below are not covered by TE's curriculum, but recommended for larger apps

  // Actions typically commit one or more mutation and can be used to coordinate complex operations
  actions: {
  },
  // Modules are used to group together groups of complex code
  modules: {
  }
})
