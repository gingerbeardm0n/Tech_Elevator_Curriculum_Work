import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Questions from '../views/Questions.vue'
import AskQuestion from '../views/AskQuestion.vue'
import Services from '../views/Services.vue'
import About from '../views/About.vue'
import Contact from '../views/Contact.vue'
import NotFoundMessage from '../views/NotFoundMessage.vue'
import QuestionDetails from '../views/QuestionDetails.vue'


Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  // TODO: Add a route for Questions
  {
    path: '/Questions/Ask',
    name: 'Questions',
    component: Questions
  },
  // TODO: Add a route for AskQuestion
  {
    path: '/AskQuestion',
    name: 'AskQuestion',
    component: AskQuestion
  },
  {
    path: '/Questions/:questionId', // This reads :questionId from the params passed in
    name: 'QuestionDetails',
    component: QuestionDetails,
  },

  // TODO: Add a route for Services
  {
    path: '/Services',
    name: 'Services',
    component: Services
  },
  // TODO: Add a route for About
  {
    path: '/About',
    name: 'About',
    component: About
  },
  // TODO: Add a route for Contact
  {
    path: '/Contact',
    name: 'Contact',
    component: Contact
  },
  // TODO: Talk about case sensitivity on Name / Components

  // TODO: Add a wildcard route for NotFound
{
  path: '*',
  name: 'NotFoundMessage',
  component: NotFoundMessage
},

  // TODO: This will require a new view that displays the NotFoundMessage component

  // TODO: Add a route for question details and question edit
];

const router = new VueRouter({
  // TODO: Talk about Hash vs History
  mode: 'history',
  base: process.env.BASE_URL,
  routes
});

export default router;