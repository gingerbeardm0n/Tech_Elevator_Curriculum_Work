import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import About from '../views/About.vue'
import Questions from '../views/Questions.vue'
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
    name: '404',
    component: NotFound
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
