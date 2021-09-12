<template>
  <div id="app">
    <!-- <login/> -->
    <menuLayout v-show="true"/>
    <div  class="right-box" v-show="true">
      <headerLayout/>
      <contentLayout/>
    </div>
  </div>
</template>
<script>
import menuLayout from './components/layout/menu.vue'
import headerLayout from './components/layout/header.vue'
import contentLayout from './components/layout/content.vue'
// import login from './components/pages/login.vue'
export default {
  name: 'App',
  components: {
    menuLayout,
    headerLayout,
    contentLayout,
    // login,
  }
}
</script>
<style>
body{
  width: 100%;
  height: 100vh;
  margin: 0px;
  background-color: #EAECEF;
}
@font-face{
  font-family: OpenSan-Regular;
  src: url('./assets/Fonts/OpenSans-Regular.ttf');
}
@font-face {
  font-family: OpenSan-Bold;
  src: url('./assets/Fonts/OpenSans-Bold.ttf');
}
@font-face {
  font-family: OpenSan-Semibold;
  src: url('./assets/Fonts/OpenSans-Semibold.ttf');
}
@font-face {
  font-family: OpenSan-Italic;
  src: url('./assets/Fonts/OpenSans-Italic.ttf');
}
#app {
  font-family: OpenSan-Regular;
  margin: 0px;
  width: 100%;
  display: flex;
}
.right-box{
  width: calc(100% - 220px);
}
select, input{
  font-family: OpenSan-Regular;
}
</style>
