<template>
  <div>
    <form @submit.prevent="submitGuess">
      <p class="prompt">What is your guess?</p>

      <color-chooser
        class="colorChooser"
        v-for="(slot, index) in slots"
        v-bind:key="index"
        :index="index" />

      <button type="submit" :disabled="isGameOver">Guess</button>
    </form>
    <p>{{ movesLeft }}</p>
  </div>
</template>

<script>
import ColorChooser from "./ColorChooser.vue";

export default {
  methods: {
    submitGuess() {
      this.$store.dispatch("guess");
    }
  },
  components: {
    ColorChooser
  },
  computed: {
    guessLength() {
      return this.$store.getters.solutionLength;
    },
    isGameOver() {
      return this.$store.getters.isGameOver;
    },
    movesLeft() {
      return this.$store.getters.remainingGuesses;
    },
    slots() {
      return this.$store.getters.guess;
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
