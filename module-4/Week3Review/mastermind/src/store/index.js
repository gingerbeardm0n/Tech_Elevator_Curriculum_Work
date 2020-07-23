import Vue from 'vue';
import Vuex from 'vuex';
import GameService from '../services/GameService.js';

Vue.use(Vuex)

const maxGuesses = 10;
const choices = ['Blue', 'Green', 'Orange', 'Violet', 'Red', 'Yellow'];

export default new Vuex.Store({
  strict: true,
  state: {
    isGameOver: false,
    movesLeft: maxGuesses,
    history: [],
    message: '',
    solution: GameService.generateSolution(4, choices),
    guess: GameService.buildInitialGuess(4, choices),
    choices: choices,
  },
  mutations: {
    /**
     * Handles the user changing a field on a guess, prior to clicking guess
     * @param state the previous application state
     * @param payload the color choice the user made, including the new color and the index
     */
    CHANGE_COLOR(state, payload) {
      state.guess[payload.index] = payload.color
    },     
    /**
     * Resets the game state to a new state. This is run on application start
     * @param state the previous application state
     */
    RESTART_GAME(state) {
      console.log('Resetting game state');
      state.isGameOver = false;
      state.movesLeft = maxGuesses;
      state.solution = GameService.generateSolution(4, choices),
      state.history = [];
      state.message = '';
    },
    /**
     * Guesses the currently selected colors and updates the game accordingly
     * @param state the previous application state
     */    
    GUESS(state) {
      const guess = state.guess.map(g => g[0]).join(''); // Translate for an array of color names to a single string with the first letter of each color
      const move = GameService.evaluateGuess(guess, state.solution);

      // Ensure we record the ID of the move
      move.id = state.history.length + 1;

      state.history.push(move);

      // Check for game won
      if (move.numCorrect === state.solution.length) {
        state.isGameOver = true;
        state.message = 'You win!';
      }
      // Decrement our turn count and check for game over
      else if (--state.movesLeft <= 0) {
        state.isGameOver = true;
        state.message = 'You lost yet again.';
      }      
    },   
  },
  actions: {
  },
  getters: {
  },
  modules: {
  }
})
