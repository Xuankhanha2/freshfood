<template>
  <div id="app">
    <headerLayout/>
    <bannerLayout/>
    <menuLayout/>
    <contentLayout/>
    <footerLayout/>
  </div>
</template>

<script>
import headerLayout from './components/layout/headerLayout.vue'
import bannerLayout from './components/layout/bannerLayout.vue'
import menuLayout from './components/layout/menuLayout.vue'
import contentLayout from './components/layout/contentLayout.vue'
import footerLayout from './components/layout/footerLayout.vue'
export default {
  name: 'App',
  components: {
    headerLayout,
    bannerLayout,
    menuLayout,
    contentLayout,
    footerLayout
  }
}
</script>

<style>
html{
  padding: 0px; 
  margin: 0px;
}
body{
  margin: 0px;
  padding: 0px;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
}
@import url('./css/bootstrap/bootstrap.css')
</style>
