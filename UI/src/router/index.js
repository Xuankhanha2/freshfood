import { createRouter, createWebHistory } from 'vue-router'
import category from '../components/page/categoryPage.vue'
import home from '../components/page/homePage.vue'
import productDetail from '../components/page/productDetailPage.vue'
import contact from '../components/page/contactPage.vue'
import introduction from '../components/page/introductionPage.vue'
import cart from '../components/page/cart.vue'
import news from '../components/page/newsPage.vue'
import login from '../components/page/loginPage.vue'
import register from '../components/page/registerPage.vue'
const routes = [
  {
    path: '/',
    name: 'home',
    component: home
  },
  { path: '/category', component: category },
  { path: '/home', component: home },
  { path: '/productDetail/:productId', component: productDetail },
  { path: '/contact', component: contact },
  { path: '/introduction', component: introduction },
  { path: '/cart', component: cart },
  { path: '/news', component: news },
  { path: '/login', component: login },
  { path: '/register', component: register },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
