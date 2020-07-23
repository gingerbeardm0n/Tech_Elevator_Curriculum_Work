<template>
  <select v-model="choice" 
          v-on:change="onSelected">
    <option v-for="option of options" v-bind:key="option" 
            v-bind:value="option">
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
      return this.$store.state.choices;
    }
  },
  methods: {
    onSelected() {
      const payload = {index: this.index, color: this.choice};
      this.$store.commit("CHANGE_COLOR", payload);
    }
  },
  created() {
    this.choice = this.$store.state.guess[this.index];
  }
};
</script>
