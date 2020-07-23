<template>
  <div>
    <span
      v-for="char in move.guess"
      v-bind:key="char"
      v-bind:title="getTitle(char)"
      v-bind:class="'color' + char">
      {{ char }}
    </span>
    <span class="grading">
      <span
        v-for="num in move.numCorrect"
        v-bind:key="num"
        class="correct"
        v-bind:title="move.numCorrect + ' exactly correct'"
      >
        &#10003; <!-- This is a character code for a check mark -->
      </span>
      <span
        v-for="num in move.numMisplaced"
        v-bind:key="'partial' + num"
        class="partial"
        v-bind:title="move.numMisplaced + ' partially correct'"
      >
        &#9675; <!-- This is a character code for a light circle -->
      </span>
    </span>
  </div>
</template>

<script>
export default {
  props: ['move'],
  methods: {
    getTitle(char) {
      switch (char) {
        case "R":
          return "Red";
        case "O":
          return "Orange";
        case "G":
          return "Green";
        case "B":
          return "Blue";
        case "V":
          return "Violet";
        case "Y":
          return "Yellow";
        default:
          return char;
      }
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
span {
    font-size: larger;
}

.grading {
  margin-left: 3rem;
  color: green;
}

span {
  font-weight: bold;
}

.colorR {
  color: red;
}
.colorG {
  color: green;
}
.colorB {
  color: blue;
}
.colorV {
  color: purple;
}
.colorY {
  color: goldenrod;
}
.colorO {
  color: orange;
}
</style>
