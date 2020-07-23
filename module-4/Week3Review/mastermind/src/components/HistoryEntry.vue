<template>
  <div>
    <span
      v-for="(char, index) in move.guess"
      :key="'slot' + index"
      :title="getTitle(char)"
      :class="'color' + char"
    >
      {{ char }}
    </span>
    <span class="grading">
      <span
        v-for="num in move.numCorrect"
        :key="'exact' + num"
        class="correct"
        :title="move.numCorrect + ' exactly correct'"
      >
        &#10003; <!-- This is a character code for a check mark -->
      </span>
      <span
        v-for="num in move.numMisplaced"
        :key="'partial' + num"
        class="partial"
        :title="move.numMisplaced + ' partially correct'"
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
