<template>
    <div class="contentLayout">
        <!-- <homePage/> -->
        <!-- <productDetailPage/> -->
        <contactPage/>
    </div>
</template>

<script>
// import homePage from '../page/homePage.vue'
// import productDetailPage from '../page/productDetailPage.vue'
import contactPage from '../page/contactPage.vue'
export default {
    components:{
        // homePage,
        // productDetailPage,
        contactPage
    }
}
</script>
<style lang="css">
.contentLayout{
    margin: 0px auto;
    padding: 0px;
    width: 1200px;
    margin-top: 10px;
}
</style>