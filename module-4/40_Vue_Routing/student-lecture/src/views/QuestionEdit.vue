<template>
    <div>
        <main>
            <section id="opening">
                <h1>Edit Question</h1>
                <question-card v-bind:cardData="question" />
            </section>
            <section id="editForm">
                <form id="editQuestion" v-on:submit.prevent="addQuestion()">
                    <div class="form-group">
                    <label>Question</label>
                    <input type="text" required id="newQuestion" 
                           v-model.trim="question.question">
                    </div>
                    <div class="form-group">
                    <label>Answer</label>
                    <textarea id="newAnswer" 
                            v-model.trim.lazy="question.answer">
                    </textarea>
                    </div>
                    <div class="form-group">
                    <label for="newDifficulty">Difficulty</label>
                    <!-- Ideally this should be a select instead of an input, but this lets us demo modifiers -->
                    <input type="number" min="1" max="3" 
                            id="newDifficulty"
                            v-model.number="question.difficulty">
                    </div>
                </form>   
            </section>
        </main>
    </div>
</template>

<script>
import QuestionCard from '../components/QuestionCard.vue';

export default {
    components: {
        QuestionCard
    },
    data() {
        return {
            question: {
                id: -1,
                question: 'TODO: Look up the question from the store by id',
                answer: 'Use $route to look up the item from the store by its id',
                isCorrect: false,
                isAnswerVisible: true,
            }
        }
    },
    computed: {
    },
    // TODO: Handle created by grabbing the question from questions
    // TODO: Redirect to NotFound if the question ID is not found
}
</script>

<style scoped>
    #editForm {
        margin-top: 2rem;
    }
</style>