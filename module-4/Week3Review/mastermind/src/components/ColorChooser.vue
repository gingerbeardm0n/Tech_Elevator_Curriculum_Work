<template>
  <select v-model="choice" :id="'slot' + index" @change="onSelected">
    <option v-for="option of options" v-bind:key="option" :value="option">
      {{ option }}
    </option>
  </select>
</template>

<script>
export default {
  props: ['index'],
  data: function() {
    return { choice: "" };
  },
  computed: {
    options() {
      return this.$store.getters.availableOptions;
    }
  },
  methods: {
    onSelected() {
      const choice = {index: this.index, color: this.choice};
      this.$store.dispatch("changeColor", choice);
    }
  },
  created() {
    this.choice = this.$store.getters.guess[this.index];
  }
};
</script>
