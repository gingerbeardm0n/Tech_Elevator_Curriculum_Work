<template>
  <div>
    <main>
      <section id="opening">
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
        <img
          src="../assets/images/SquirrelStone.jpg"
          title="A squirrel looking confused in a crowd of people"
        />
        <cite>
          <span>
            Photo by
            <a
              href="https://unsplash.com/@bramnaus?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
            >
              Bram
              Naus
            </a> on
            <a
              href="/s/photos/squirrel?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
            >Unsplash</a>
          </span>
        </cite>
        <blockquote>
          Remember; just try to represent yourself well. You don't have to know everything.
          <cite>
            - Sally
            the Squirrel
          </cite>
        </blockquote>
      </aside>

      <section id="questionList">
        <h2>Questions</h2>

        <p>Use the form below to search questions. Hover over a question to reveal the answer.</p>
        <div class="form-group form-inline">
          <div>
            <label for="search">Search</label>
            <input type="search" id="search" placeholder="Search questions or tags" />
            <input type="button" value="Search" id="btnSearch" title="Filter the list of questions" />
          </div>
        </div>

        <div class="questionContainer" id="divQuestions"></div>
      </section>
      <section id="closing">
        <h2>Not Enough?</h2>
        <p>
          Think we're missing something?
          <a href="askaquestion.html">Submit a Question</a> and help us out!
        </p>
        <p>
          Don't like something you see?
          <a href="contact.html">Contact us</a> and let us know!
        </p>
      </section>
    </main>

    <!--
    <template id="cardTemplate">
        <article class="blur">
            <div class="question">Some Title</div>
            <div class="answer">Some Answer Goes Here</div>
            <div class="questionFooter">
                <div>
                    <a class="showAnswer" title="Show Answer">
                        <i class="fas fa-eye fa-2x"></i>
                    </a>
                    <a class="hideAnswer" title="Hide Answer">
                        <i class="fas fa-eye-slash fa-2x"></i>
                    </a>
                    <a class="editAnswer" title="Edit Question">
                        <i class="fas fa-edit fa-2x"></i>
                    </a>
                </div>
                <div>
                    <a class="markCorrect" title="Mark Correct">
                        <i class="fas fa-thumbs-up fa-2x"></i>
                    </a>
                    <a class="markIncorrect" title="Mark Incorrect">
                        <i class="fas fa-thumbs-down fa-2x"></i>
                    </a>
                </div>
            </div>
        </article>
    </template> 
    -->
  </div>
</template>

<script>
export default {
  data() {
    return {};
  },
  computed: {
    favoriteNumber() {
      return 42;
    }
  }
};
</script>

<style scoped>
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

aside {
  grid-area: yet-another-squirrel;
}

#questionList {
  grid-area: questionsList;
}

#closing {
  grid-area: notEnough;
}

.questionContainer {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
}

.question-header {
  color: #f6931d;
}

/* List item styling */

article {
  border: #3b3e42 solid 1px;
  border-radius: 0.5rem;
  background-color: #ffcb48;
  overflow: none;
  color: #ffffff;
  text-shadow: 2px 2px #999999;
  padding: 0;
  margin: 0.5rem;
  box-shadow: 0.25rem 0.25rem #999999;
}

article:hover {
  background-color: #f6931d;
}

/* Styling areas of the list items */

.answer {
  padding: 0.5rem;
  background-color: #3b3e42;
  text-shadow: none;
  height: 8rem;
  overflow: auto;
  font-size: small;
}

.question {
  height: 2rem;
  padding: 0.5rem;
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande",
    "Lucida Sans", Arial, sans-serif;
  font-weight: bold;
  min-height: 37px;
}

/* Question Card Footer Styling */
.questionFooter {
  display: flex;
  padding: 0.5rem;
  align-content: center;
  justify-content: space-between;
}

.questionFooter > div {
  display: inline-block;
}

.questionFooter a {
  color: #ffffff;
}

.questionFooter a:hover {
  color: #ffcb48;
}

.questionFooter a.markCorrect:hover {
  color: #8cc63f;
}

.questionFooter a.markIncorrect:hover {
  color: #c63f3f;
}

article.blur {
  background-color: #00adee;
}

article.blur:hover {
  background-color: #f6931d;
}

/* Disabling this now that we'll have button handling code
article.blur:hover .answer {
    color: #ffffff;
    text-shadow: none;
}
*/

/* Blur the answer text by default */
article.blur .answer {
  color: transparent;
  text-shadow: 0 0 5px #ffffff;
}

/* Hide buttons that shouldn't be present */
article.blur .hideAnswer {
  display: none;
}
article:not(.blur) .showAnswer {
  display: none;
}
article .editAnswer {
  /* For now, edit is never available */
  display: none;
}
article.correct .markCorrect {
  display: none;
}
article.incorrect .markIncorrect {
  display: none;
}

/* Correct / Incorrect Styling */
article.correct {
  background-color: #8cc63f;
}

article.incorrect {
  background-color: #c63f3f;
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