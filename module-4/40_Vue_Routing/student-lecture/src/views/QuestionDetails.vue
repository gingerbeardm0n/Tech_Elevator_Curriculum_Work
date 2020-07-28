<template>
    <div>
        <main>
            <section id="opening">
                <question-card v-bind:cardData="question" />
            </section>            
            <section id="editSection" v-if="showEdit">
                <p>
                    <router-link :to="{name: 'EditQuestion', params: {id: question.id}}">
                        Edit this Question
                    </router-link>
                </p>
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
            showEdit: true,
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

    created() {
        console.log('Component created!');

        console.log('Parameters to this component are:', this.$route.prams);
        
        const id = this.$route.params.questions;
        console.log('You requested ID: ' + id)
    }
    // TODO: Redirect to NotFound if the question ID is not found
}
</script>