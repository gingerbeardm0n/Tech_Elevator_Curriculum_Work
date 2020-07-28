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
  {
    path: '/About',
    name: 'About',
    component: About
  },
  {
    path: '/Services',
    name: 'Services',
    component: Services
  },
  {
    path: '/Questions',
    name: 'Questions',
    component: Questions
  },  
  {
    path: '/Questions/:id',
    name: 'QuestionDetails',
    component: QuestionDetails
  },
  {
    path: '/Questions/:id/Edit',
    name: 'EditQuestion',
    component: QuestionEdit
  },
  {
    path: '/AskQuestion',
    name: 'AskQuestion',
    component: AskQuestion
  },
  {
    path: '/Contact',
    name: 'Contact',
    component: Contact
  },
  {
    path: '*',
    name: 'NotFound',
    component: NotFound
  }
]

const router = new VueRouter({
  mode: 'history', // TODO: Talk about Hash vs History
  base: process.env.BASE_URL,
  routes
})

export default router
