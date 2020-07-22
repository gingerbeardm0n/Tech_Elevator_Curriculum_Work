import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  // When strict is set to true, state can ONLY be mutated from the store. This should be true.
  strict: false,
  
  // State contains the global application state. Think of it as app-wide data
  state: {
  },
  // Mutations are used to make discrete changes to state from a central place
  mutations: {
  },

  // The two items below are not covered by TE's curriculum, but recommended for larger apps

  // Getters provide encapsulation around application state by providing computed properties
  getters: {
  },
  // Actions typically commit one or more mutation and can be used to coordinate complex operations
  actions: {
  },

  // Modules are not covered by TE's curriculum, but are recommended for very large apps

  // Modules are used to group together groups of complex code
  modules: {
  }
})
