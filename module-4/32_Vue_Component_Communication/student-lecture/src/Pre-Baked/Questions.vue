<!-- Template defines the way the component renders on the web page -->
<template>
  <main>
    <section id="opening">
      <!-- TODO: Declare a new component and give it a prop or two -->
      <h1>A Friendly Note</h1>
      <p>
        Don't worry if you can't give great answers to all or even most of these. Aim for being able to
        successfully answer around 70% or less of the questions asked of you.
      </p>
      <p>Focus on conveying a good impression as someone responsible, competent, and able to learn and grow.</p>
      <p>Remember that people are looking for someone who is:</p>
      <ul>
        <li>
          <em>Professional</em>,
          <em>Responsible</em>, and
          <em>Reliable</em>
        </li>
        <li>
          Knows how to program enough to work without
          <em>constant</em> help (regular check-ins are normal and
          expected)
        </li>
        <li>Able and willing to continue to learn and grow</li>
      </ul>
    </section>

    <aside>
      <img src="../assets/images/SquirrelStone.jpg" title="A squirrel looking confused in a crowd of people" />
      <cite><span>Photo by Bram Naus on Unsplash</span></cite>
      <blockquote>
        Remember; just try to represent yourself well. You don't have to know everything.
        <cite>- Sally the Squirrel</cite>
      </blockquote>
    </aside>

    <section id="questionList">
      <question-search />
      <question-list />
    </section>

    <section id="closing">
      <h2>Add Question?</h2>
      <p v-if="!isAddQuestionVisible">
        Think we're missing something?
        <a v-on:click="showAddQuestionForm()">Submit a Question</a> and help us out!
      </p>
      <add-question-form v-else />
    </section>
  </main>
</template>

<!-- Script is the core data and logic associated with the component. It is required -->
<script>
import QuestionList from './QuestionList.vue';
import QuestionSearch from './QuestionSearch.vue';
import AddQuestionForm from './AddQuestionForm.vue';

export default {
  // Name is optional, but usually a good idea. This shows up in dev tools
  name: "QuestionsPage",
  // Contains a list of components which must be included in the template
  components: {
    QuestionList,
    QuestionSearch,
    AddQuestionForm
  },
  // Contains properties which are like data, but the value is passed in from another component
  props: [],
  // Methods contain functions which can be invoked from event handlers or other code
  methods: {
    /**
     * Shows the add question form.
     */
    showAddQuestionForm() {
      this.$store.commit('SHOW_ADD_QUESTION');
    },
  },
  // Data contains information specific to our application
  data() {
    return {};
  },
  // Computed contains the Vue.js equivalent of getters that rely on other data to compute results.
  // Think of computed as computed or auto-calculated properties that are bound to from the template.
  computed: {
    isAddQuestionVisible() {
      return this.$store.state.isAddQuestionVisible;
    }
  }
};
</script>

<style>
/* Styling for the list container */

html body {
  grid-template-columns: 1fr;
  grid-template-areas:
    "navBar"
    "mainBody"
    "footer";
}

main {
  display: grid;
  grid-template-areas:
    "aFriendlyNote"
    "yet-another-squirrel"
    "questionsList"
    "notEnough";
}

#opening {
  grid-area: aFriendlyNote;
}

main aside {
  grid-area: yet-another-squirrel;
}

#closing {
  grid-area: notEnough;
}

main aside {
  margin-top: 1rem;
}

/* Responsive Layout Rules */
@media screen and (min-width: 768px) {
  main {
    grid-template-areas:
      "aFriendlyNote yet-another-squirrel"
      "questionsList questionsList"
      "notEnough notEnough";
  }
}
</style>