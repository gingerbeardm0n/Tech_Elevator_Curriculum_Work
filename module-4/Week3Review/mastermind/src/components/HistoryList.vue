<template>
  <div v-show="moves.length">
    <h2>Past Guesses</h2>
    <history-entry
      v-for="(move, index) of moves"
      v-bind:key="index"
      :move="move"
    />
  </div>
</template>

<script>
import HistoryEntry from "./HistoryEntry.vue";

export default {
  components: {
    HistoryEntry
  },
  computed: {
    moves() {
      return this.$store.getters.guesses;
    }
  }
};
</script>
