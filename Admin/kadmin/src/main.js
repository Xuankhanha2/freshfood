
import App from './App.vue'

import Vue from 'vue'
import VueRouter from 'vue-router'

import productPage from './components/pages/product/product.vue'
import categoryPage from './components/pages/category/category.vue'
import newsPage from './components/pages/news/news.vue'
import customerPage from './components/pages/customer/customer.vue'
Vue.use(VueRouter)

import CKEditor from '@ckeditor/ckeditor5-vue2';

Vue.use( CKEditor );

const routes = [
    { path: '/product', component: productPage },
    { path: '/category', component: categoryPage },
    { path: '/news', component: newsPage },
    { path: '/customer', component: customerPage}
  ]

const router = new VueRouter({
  routes // short for `routes: routes`
})

new Vue({
    router,
    render: h => h(App)
}).$mount('#app')


// createApp(App).use(router).mount('#app')
