import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import About from '../views/About.vue'
import Questions from '../views/Questions.vue'
import QuestionDetails from '../views/QuestionDetails.vue'
import QuestionEdit from '../views/QuestionEdit.vue'
import NotFound from '../views/NotFound.vue'
import AskQuestion from '../views/AskQuestion.vue'
import Contact from '../views/Contact.vue'
import Services from '../views/Services.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  // TODO: Add more routes

  // TODO: Add a wildcard route for NotFound

  // TODO: Add a route for question details and question edit
];

const router = new VueRouter({
  mode: 'hash', // TODO: Talk about Hash vs History
  base: process.env.BASE_URL,
  routes
});

export default router;











// You'll never see the lines below in the real world, so don't worry about it. 
// I have these lines here to let me import our components before using them in the demo
if (router === false) {
  const shushEsLint = [About, Questions, QuestionDetails, QuestionEdit, NotFound, AskQuestion, Contact, Services]
  console.log(shushEsLint);
}