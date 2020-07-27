<template>
    <div class="pageRoot">
        <main>
            <section id="opening">
                <question-card v-bind:cardData="question" />
            </section>
            <section>
                <p>
                    <router-link :to="{name: 'EditQuestion', params: {id: question.id}}">Edit this Question</router-link>
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
            question: null
        }
    },
    computed: {
    },
    created() {
        this.question = this.$store.state.questions.find(q => q.id === this.$route.params.id);

        if (!this.question) {
            this.$router.push({name: 'NotFound'});
        }
    }
}
</script>