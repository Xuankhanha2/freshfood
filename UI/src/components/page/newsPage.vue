<template>
    <div class="newsPage">
        <div class="listTitle">
            Danh sách tin tức
        </div>
        <div class="listNews">
            <ul class="row col-xl-12">
                <li class="col-xl-6" 
                    v-for="item in news"
                    :key="item.newsId"
                >
                    <img :src="item.newsImage" class="News-img">
                    <div class="newsRow">
                        <a href="/News/Detail">
                            <h3 class="">{{item.newsTitle}}</h3>
                        </a>
                        <a href="/News/Detail">
                            <p class="description">
                                {{item.newsContent}}
                            </p>
                        </a>
                        <a href="/News/Detail/@item.id"><div class="btnDetail btn-success">Chi tiết</div></a>
                    </div>
                </li>
            </ul>
        </div>
        <!-- New  -->
        <!-- Dịch vụ  -->
        <div class="serviceTitle">
            <p>CHÍNH SÁCH</p>
            <hr>
        </div>
        <div class="service">
            <div class="serviceContent">
                <img src="../../assets/images/service1.jpg">
                <div class="policy">
                    Chính sách vận chuyển<br>
                    <span>Miễn phí trong nội thành</span>
                </div>
            </div>
            <div class="serviceContent">
                <img src="../../assets/images/service2.jpg">
                <div class="policy">
                    Chính sách thanh toán<br>
                    <span>Thanh toán online được giảm 2%</span>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios'
export default {
    data() {
        return {
            news: [],
        }
    },
    async created() {
        await axios.get('https://localhost:44368/api/News').then((result)=>{
            this.news = result.data;
        })

    },
}
</script>

<style lang="css">
    @import url('../../css/page/newsPage.css');
</style>
