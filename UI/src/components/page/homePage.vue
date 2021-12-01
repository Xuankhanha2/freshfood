<template>
    <div class="homeContent">
        <!-- slie show & danh muc -->
        <div class="slideNcategory row">
            <!-- category -->
            <sideCategoryBar class="col-xl-3"/>
            <!-- end category -->

            <!--  -->
            <div class="slide col-xl-9">
                <div class="slideItem "><img src="../../assets/images/slide1.jpg" alt=""></div>
                <div class="slideItem imageOnTop"><img src="../../assets/images/slide2.jpg" alt=""></div>
                <div class="slideItem "><img src="../../assets/images/slide3.jpg" alt=""></div>
                <div class="slideItem "><img src="../../assets/images/slide4.jpg" alt=""></div>
                <div class="slideItem "><img src="../../assets/images/slide5.jpg" alt=""></div>
            </div>
            
        </div>
        <!-- end slie show & danh muc -->

        <!-- product -->
        <div class="productRow">
            <div class="categoryName">TRÁI CÂY MỖI NGÀY</div>
            <!-- Danh sách sản phẩm -->
            <div class="productList row">
                <!-- Ô sản phẩm -->
                <div class="marginProductCell col-xl-3" 
                    v-for="product in firstProducts" 
                    :key="product.productId"
                >
                    <div class="productCell">
                        <img :src="product.image"
                            class="productImage"
                            @click="pushToDetail(product.productId)"
                        >
                        <h1 class="productName"
                            @click="pushToDetail(product.productId)"
                        >{{product.productName}}</h1>
                        <!-- ratingStar -->
                        <div class="ratingStars">
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                        </div>
                        <!-- end rating Star -->

                        <!--Real price -->
                        <h2>100.000 đ</h2>

                        <!-- price after discount -->
                        <p>{{formatMoney(product.price)}} ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-{{product.discount}}%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary" id="btnAddCart"
                            @click="addCart(product.productId)"
                        >Thêm vào giỏ</div>
                    </div>
                </div>
                <!-- /Ô sản phẩm -->
            </div>
            <!-- /Danh sách sản phẩm -->

            <!-- pagination -->
            <nav class="newsPageList">
                <ul class="pagination alignRight">
                    <li class="page-item"><span class="page-link" @click="goToPage(1)">Prev</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPage(1)">1</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPage(2)">2</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPage(3)">3</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPage(1)">Next</span></li>
                </ul>
            </nav>
            <!-- / -->
        </div>
        <!-- /end product  -->

        <!--Banner middle-->
        <div class="bannerMiddle">
            <img src="../../assets/images/slide1.jpg" />
        </div>
        <!--end Banner-->

        <!-- product -->
        <div class="productRow">
            <div class="categoryName">TRÁI CÂY MỖI NGÀY</div>
            <!-- Danh sách sản phẩm -->
            <div class="productList row">
                <!-- Ô sản phẩm -->
                <div class="marginProductCell col-xl-3" 
                    v-for="product in secondProducts" 
                    :key="product.productId"
                >
                    <div class="productCell">
                        <img :src="product.image"
                            @click="pushToDetail(product.productId)"
                        >
                        <h1
                            @click="pushToDetail(product.productId)"
                        >{{product.productName}}</h1>
                        <!-- ratingStar -->
                        <div class="ratingStars">
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                            <i class="fas fa-star"></i>
                        </div>
                        <!-- end rating Star -->

                        <!--Real price -->
                        <h2>100.000 đ</h2>

                        <!-- price after discount -->
                        <p>{{formatMoney(product.price)}} ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-{{product.discount}}%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary" id="btnAddCart"
                            @click="addCart(product.productId)"
                        >Thêm vào giỏ</div>
                    </div>
                </div>
                <!-- /Ô sản phẩm -->
            </div>
            <!-- /Danh sách sản phẩm -->
        </div>
        <!-- /end product  -->
        
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
        <!-- Tin tức -->
        <div class="serviceTitle">
            <p>TIN TỨC VỀ THỰC PHẨM</p>
            <hr>
        </div>
        <div class="newsContent">
            <div class="newsList col-xl-12">
                <div class="newsCell"
                    v-for="news in newsList"
                    :key="news.newsId"
                >
                    <img src="../../assets/images/tintuc-image1.jpg" alt="">
                    <h1><a href="#">{{news.newsTitle}}</a></h1>
                    <p>{{news.newsContent}}</p>
                    <a href="#"><div class="detailNewsBtn">Chi tiết</div></a>
                </div>
            </div>

            <nav class="newsPageList">
                <ul class="pagination alignRight">
                    <li class="page-item"><span class="page-link" @click="goToPageForNews(1)">Prev</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPageForNews(1)">1</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPageForNews(2)">2</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPageForNews(3)">3</span></li>
                    <li class="page-item"><span class="page-link" @click="goToPageForNews(1)">Next</span></li>
                </ul>
            </nav>
        </div>
        <!-- /Tin tuc -->
    </div>
</template>

<script>
import axios from 'axios'
import sideCategoryBar from '../shared/sideCategoryBar.vue'
export default {
    props:['products'],
    data() {
        return {
            //Biến tạm thời dùng để lưu thông tin giỏ hàng
            cart: {},
            //Biến lưu danh sách sản phẩm thứ 1
            firstProducts:[],
            //Biến lưu danh sách sản phẩm thứ 2
            secondProducts:[],
            //Danh sách danh mục hiển thị trên trang chủ
            categories:[],
            //Danh sách menu item
            menuItems:[],
            //Biến lưu danh sách tin tức
            newsList:[],
        }
    },
    components:{
        sideCategoryBar
    },
    methods: {
        /**Hàm format giá tiền sản phẩm
         * created by: VXKHANH
         * created date: 30/10/21
         */
        formatMoney(money){
            //chuyển đổi tiền
            var formatedMoney = String(money).replace(/(\d)(?=(?:\d{3})+$)/g, '$1.');
            return formatedMoney;
        },
        /**
         * created date: 09/11/2021
         * created by: vxkhanh
         * Hàm thêm sản phẩm vào giỏ hàng
         */
        async addCart(productId){
            if(localStorage.getItem('userId'))
            {
                if(productId != null && productId != ""){
                    this.cart.productId = productId;
                    //Nhấn nút thêm -> mặc định số lượng thêm là 1 sp
                    this.cart.quantity = 1;
                    //Lấy mã khách hàng đã đăng nhập được lưu trong localStorage
                    this.cart.customerId = localStorage.getItem('userId');
                    await axios.post('https://localhost:44368/api/v1.0/Carts', this.cart).then((result)=>{
                        console.log(result.data);
                        alert("Đã thêm sản phẩm vào giỏ hàng.");
                    }).catch(()=>{
                        console.log("Đã có lỗi hệ thống xảy ra.");
                    })
                }
            }
            else{
                this.$router.push('/login');
            }
        },

        /**
         * created by: vxkhanh
         * created date: 11/11/2021
         * Hàm chuyển đến trang chi tiết sản phẩm
         */
        pushToDetail(productId){
            var id = String(productId);
            this.$router.push({
                name: 'productDetail', 
                path: '/productDetail', 
                params: { productId: id}
            });
        },
        /**
         * created date: 19/11/2021
         * created by: vxkhanh
         * Hàm xủ lý sư kiện chuyển số trang sang trang tiếp theo cho phần sản phẩm
         */
        async goToPage(page){
            page = parseInt(page);
            await axios.get('https://localhost:44368/api/v1.0/Products?pageNumber='+page+'&items=12').then((result)=>{
                this.firstProducts = result.data;
            }).catch(()=>{
                console.log("Đã xảy ra lỗi.");
            })
        },

        /**
         * created date: 19/11/2021
         * created by: vxkhanh
         * Hàm xủ lý sư kiện chuyển số trang sang trang tiếp theo cho phần tin tức
         */
        async goToPageForNews(page){
            page = parseInt(page);
            await axios.get('https://localhost:44368/api/v1.0/news?pageNumber='+page+'&items=3').then((result)=>{
                this.newsList = result.data;
            }).catch(()=>{
                console.log("Đã có lỗi xảy ra.")
            })
        }
    },
    async mounted() {
        
    },
    async created() {
        //Khởi tạo dữ liệu
        this.firstProducts = new Array;
        this.secondProducts = new Array;
        this.newsList = new Array;
        //Tạo giá trị ban đầu cho biến cart
        this.cart = {
            cartId: "00000000-0000-0000-0000-000000000000",
            productId: "00000000-0000-0000-0000-000000000000",
            customerId: "00000000-0000-0000-0000-000000000000",
            quantity: 1,
            total: 0
        }
        //Lấy danh sách sản phẩm ở trang đầu tiên
        await axios.get('https://localhost:44368/api/v1.0/Products?pageNumber=1&items=12').then((result)=>{
            this.firstProducts = result.data;
        }).catch(()=>{
            console.log("Đã có lỗi xảy ra.")
        })
        
        //Lấy danh sách tin tức
        await axios.get('https://localhost:44368/api/v1.0/News?pageNumber=1&items=3').then((result)=>{
            this.newsList = result.data;
        }).catch(()=>{
            console.log("Đã có lỗi xảy ra.")
        })
    },
}
</script>
<style lang="css">
    @import url('../../css/page/homePage.css');
</style>