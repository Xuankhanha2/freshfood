
import App from './App.vue'

import Vue from 'vue'
import VueRouter from 'vue-router'

import productPage from './components/pages/product/product.vue'
import categoryPage from './components/pages/category/category.vue'

Vue.use(VueRouter)


const routes = [
    { path: '/productPage', component: productPage },
    { path: '/categoryPage', component: categoryPage }
  ]

const router = new VueRouter({
  routes // short for `routes: routes`
})

new Vue({
    router,
    render: h => h(App)
}).$mount('#app')


// createApp(App).use(router).mount('#app')
