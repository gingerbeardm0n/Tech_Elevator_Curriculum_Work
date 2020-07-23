<template>
  <div>
    <form v-on:submit.prevent="submitGuess">
      <p class="prompt">What is your guess?</p>

      <color-chooser
        class="colorChooser"
        v-for="index in numColors"
        v-bind:key="index"
        v-bind:index="index - 1" />

      <button type="submit" 
              v-bind:disabled="isGameOver">
              Guess
      </button>
    </form>
    <p>{{ movesLeft }}</p>
  </div>
</template>

<script>
import ColorChooser from "./ColorChooser.vue";

export default {
  methods: {
    submitGuess() {
      this.$store.commit("GUESS");
    }
  },
  components: {
    ColorChooser
  },
  computed: {
    numColors() {
      return this.$store.state.solution.length;
    },
    isGameOver() {
      return this.$store.state.isGameOver;
    },
    movesLeft() {
      return this.$store.state.movesLeft;
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
button {
  margin-right: 0.5rem;
}
.colorChooser {
  margin-right: 1rem;
}
</style>
