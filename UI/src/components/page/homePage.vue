<template>
    <div class="homeContent">
        <!-- slie show & danh muc -->
        <div class="slideNcategory row">
            <!-- category -->
            <sideCategoryBar class="col-xl-3"/>
            <!-- end category -->

            <!--  -->
            <div class="slide col-xl-9">
                <div class="slideItem imageOnTop"><img src="../../assets/images/flower-banner1.jpg" alt=""></div>
                <div class="slideItem "><img src="../../assets/images/flower-banner2.jpg" alt=""></div>
                <div class="slideItem "><img src="../../assets/images/flower-banner3.jpg" alt=""></div>
            </div>
            
        </div>
        <!-- end slie show & danh muc -->

        <!-- product -->
        <div class="productRow">
            <div class="categoryName">HOA PHỔ BIẾN NHẤT</div>
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
                        <!-- <div class="wishlist"><i class="far fa-heart"></i></div> -->

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
            <div class="categoryName">HOA ĐƯỢC ĐỀ XUẤT</div>
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
                <img src="../../assets/images/policy_left.jpg">
                <div class="policy">
                    Chính sách vận chuyển<br>
                    <span>Miễn phí trong nội thành</span>
                </div>
            </div>
            <div class="serviceContent">
                <img src="../../assets/images/policy_right.jpg">
                <div class="policy">
                    Chính sách thanh toán<br>
                    <span>Thanh toán online được giảm 2%</span>
                </div>
            </div>
        </div>
        <!-- Tin tức -->
        <div class="serviceTitle">
            <p>TIN TỨC</p>
            <hr>
        </div>
        <div class="newsContent">
            <div class="newsList col-xl-12">
                <div class="newsCell"
                    v-for="news in newsList"
                    :key="news.newsId"
                >
                    <img :src="news.newsImage" alt="">
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
import path from '../../path'
export default {
    props:['products'],
    data() {
        return {
            //Biến tạm thời dùng để lưu thông tin giỏ hàng
            cart: {
                createdDate: "",
                createdBy: "",
                modifiedDate: "",
                cartId: "",
                productId: [],
                customerId: "",
                quantity: 0,
                total: 0
            },
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
            if(localStorage.getItem('customer'))
            {
                if(productId && String(productId).trim !== ""){
                    //Nhấn nút thêm -> mặc định số lượng thêm là 1 sp
                    this.cart.quantity = 1;
                    //Lấy mã khách hàng đã đăng nhập được lưu trong localStorage
                    this.cart.customerId = localStorage.getItem('userId');
                    this.cart.productId = productId;
                    //Check tồn tại product trong cart chưa
                    this.checkExistsProductInCart(productId);
                    await axios.post(path.cart, this.cart).then((result)=>{
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
            if(productId && id.trim() !== "")
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
        },

        /**
         * created date: 3/5/2022
         * created by: khanhvx
         * 
         */
        async getCustomerCart(customerId){
            if(customerId && String(customerId).trim() !== "")
                await axios.get('https://localhost:44368/api/v1.0/Carts?customerId='+customerId).then((result)=>{
                    console.log(result.data);
                    return result.data;
                }).catch(()=>{
                    return [];
                });
            else
                return [];
        },

         /**
         * created date: 3/5/2022
         * created by: khanhvx
         * Hàm kiếm tra xem sản phẩm đã tồn tại trong cart chưa
         */
        async checkExistsProductInCart(){

        }
    },
    async mounted() {
        
    },
    async created() {
        //Khởi tạo dữ liệu
        this.firstProducts = new Array;
        this.secondProducts = new Array;
        this.newsList = new Array;
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

        // Kiểm tra nếu đã có thông tin khách hàng thì
    },
}
</script>
<style lang="css">
    @import url('../../css/page/homePage.css');
</style>