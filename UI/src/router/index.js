import { createRouter, createWebHistory } from 'vue-router'
import category from '../components/page/categoryPage.vue'
import home from '../components/page/homePage.vue'
import productDetail from '../components/page/productDetailPage.vue'
import contact from '../components/page/contactPage.vue'
import introduction from '../components/page/introductionPage.vue'


const routes = [
  {
    path: '/',
    name: 'home',
    component: home
  },
  { path: '/category', component: category },
  { path: '/home', component: home },
  { path: '/productDetail', component: productDetail },
  { path: '/contact', component: contact },
  { path: '/introduction', component: introduction }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
