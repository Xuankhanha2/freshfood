<template>
    <div class="productDetailPage">
        <!-- History -->
        <div class="history">
            <ul>
                <li><a href="/Home/Index">TRANG CHỦ /</a></li>
                <li><a href="/Product/Index">&nbsp;DANH MỤC /</a></li>
                <li><a href="#"><span>&nbsp;SẢN PHẨM</span></a></li>
            </ul>
        </div>
        <!-- history -->

        <!-- Mục hai -->
        <!-- chi tiet san pham -->
        <div class="productDetail">
            <!-- khoi trai -->
            <div class="blockLeft col-xl-4">
                <div class="productImage">
                    <div class="mainImage">
                        <img src="../../assets/images/tcmn-image12.jpg" id="anh-chinh" alt="">
                    </div>
                    <div class="otherImage">
                        <ul class="row">
                            <li class="col-xl-2"><img id="img" src="../../assets/images/tcmn-image1.jpg" alt="" class="active"></li>
                            <li class="col-xl-2"><img id="img" src="../../assets/images/tcmn-image1.jpg" alt=""></li>
                            <li class="col-xl-2"><img id="img" src="../../assets/images/tcmn-image1.jpg" alt=""></li>
                            <li class="col-xl-2"><img id="img" src="../../assets/images/tcmn-image1.jpg" alt=""></li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /Khoi trai -->
            <!-- Khoi phai -->
            <div class="blockRight col-xl-4">
                <div class="productInfor">
                    <h1>Hồng xanh</h1>
                    <div class="stars">
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                    </div>
                    <h2>80.000<sup>₫</sup></h2>
                    <div class="detail" style="min-height: 70px">
                        Là sản phẩm tươi ngon được nhập khẩu từ Úc
                    </div>
                    <div>
                        <a href="#" style="text-decoration: none !important;"><i class="far fa-heart"></i> Add Wishlist</a>
                    </div>
                    <div class="productStatus">
                        Tình trạng:
                            <span>còn hàng <i class="far fa-check-circle"></i></span>
                            <!-- <span style="color: red !important;">Hết hàng <i class="far fa-times-circle"></i></span> -->
                    </div>
                    <div class="quantity">
                        <input type="button" id="decreaseBtn" value="-">
                        <input type="text" name="number" id="soluong" v-model="number" size="1">
                        <input type="button" id="increaseBtn" value="+"
                            @click="inscreaNumber()"
                        >
                    </div>
                    <input type="submit" class="btn btn-block btn-success" style="font-size: 20px; margin-bottom: 12px;" onclick="UpdateCart(@Model.id)" value="Mua hàng">
                </div>
                <div class="extendInfor">
                    <div class="keyword">từ khóa: <a href="#">hoa quả</a></div>
                    <div class="page">
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="far fa-envelope"></i></a>
                        <a href="#"><i class="fab fa-pinterest"></i></a>
                        <a href="#"><i class="fab fa-invision"></i></a>
                    </div>
                </div>
            </div>
            <!-- /khoi phai -->
            <!-- Phan mo rong -->
            <div class="moreChoice col-xl-3 offset-xl-1">
                <!-- catogory -->
                <div class="catogory">
                    <div class="catogoryTitle">
                        <i class="fas fa-carrot"></i> DANH MỤC SẢN PHẨM
                    </div>
                    <div class="catogoryContent">
                        <ul>
                            <li><a href="#"><i class="fab fa-envira"></i>Danh mục 1</a></li>   
                            <li><a href="#"><i class="fab fa-envira"></i>Danh mục 1</a></li>
                            <li><a href="#"><i class="fab fa-envira"></i>Danh mục 1</a></li>
                            
                        </ul>
                    </div>
                </div>
                <!-- /catogory -->
                <!-- quang cao -->
                <!-- /quang cao -->
            </div>
            <!-- /Phan mo rong -->
        </div>
        <!-- end noi dung chi tiet san pham -->

        <!-- Mo ta - danh gia san pham -->
        <div class="otherDetailContent">
            <div class="descriptionAndRating col-xl-8">
                <!-- description -->
                <div class="">
                    <div class="descriptionTitle">Mô tả</div>
                    <div class="descriptionContent">
                        Giá trị dinh dưỡng:   Nho tươi cung cấp các chất dinh dưỡng,
                        làm giảm mệt nhọc ngay lập tức. Các nghiên cứu cho thấy Nho tươi
                        có chứa vitamin A, C, Calcium và sắt giúp duy trì sức khỏe,
                        tốt cho tim mạch, ngăn ngừa tiến trình bệnh tiểu đường.
                        Cũng như Táo, Nho của Mỹ, Úc… đều được bảo quản trong môi
                        trường lạnh đặc biệt từ khi hái, không chất bảo quản và các
                        chất gây hại cho sức khỏe.
                    </div>
                </div>
                <!-- end description -->

                <!-- Rating -->
                <div class="descriptionTitle">Đánh giá</div>
                    <div class="rating">
                        <div class="ratingTitle">Đánh giá cho Name product</div>
                        <div class="ratingContent">
                            <div class="curentScore">
                                <span>0.00 </span>
                                <i class="fas fa-star starColor"></i>
                                <i class="fas fa-star starColor"></i>
                                <i class="fas fa-star starColor"></i>
                                <i class="fas fa-star starColor"></i>
                                <i class="fas fa-star starColor"></i>
                            </div>
                            <ul>
                                <li>
                                    <span>5</span><i class="fas fa-star"></i><div class="ratingPercentBar"><div class="ratingPercent"> </div></div>
                                    <label for="">0% | 0 Đánh giá</label>
                                </li>
                                <li>
                                    <span>4</span><i class="fas fa-star"></i><div class="ratingPercentBar"><div class="ratingPercent"> </div></div>
                                    <label for="">0% | 0 Đánh giá</label>
                                </li>
                                <li>
                                    <span>3</span><i class="fas fa-star"></i><div class="ratingPercentBar"><div class="ratingPercent"> </div></div>
                                    <label for="">0% | 0 Đánh giá</label>
                                </li>
                                <li>
                                    <span>2</span><i class="fas fa-star"></i><div class="ratingPercentBar"><div class="ratingPercent"> </div></div>
                                    <label for="">0% | 0 Đánh giá</label>
                                </li>
                                <li>
                                    <span>1</span><i class="fas fa-star"></i><div class="ratingPercentBar"><div class="ratingPercent"> </div></div>
                                    <label for="">0% | 0 Đánh giá</label>
                                </li>
                            </ul>
                            <div class="ratingBtn bg-primary" @click="ratingRow()">Đánh giá ngay</div>
                        </div>

                        <div class="ratingForm">
                            <form action="#" method="post">
                                <!-- <input type="textarea" row id="txtbox" placeholder="viết đánh giá..."> -->
                                <div class="ratingStars">
                                    <h2>Bạn đánh giá sản phẩm này bao nhiêu sao?</h2>
                                    <p id="move-rating">
                                        <i class="fas fa-star" id="star1"></i>
                                        <i class="fas fa-star" id="star2"></i>
                                        <i class="fas fa-star" id="star3"></i>
                                        <i class="fas fa-star" id="star4"></i>
                                        <i class="fas fa-star" id="star5"></i>
                                    </p>
                                </div>
                                <textarea name="ratingComment" ref="txt" id="txtbox" placeholder="viết đánh giá..."></textarea>
                                <button class="btnSend">Gửi đánh giá</button>
                            </form>
                        </div>

                        <div class="ratingTitle" style="margin-top: 30px; margin-bottom: 5px;">Một số đánh giá của khách hàng</div>
                        <div class="productRatingList">
                            <div class="ratingLine">
                                <div class="userInfor">
                                    <div class="userAvatar"><img src="../../assets/images/avatar-placeholder.png" alt=""></div>
                                    <div class="userRatingContent">
                                        <h3>Vu Xuan Khanh</h3>
                                        <!-- <div class="timeRating">
                                            <span class="hour">11</span>:<span class="minute">20</span>
                                        </div> -->
                                        <h4>
                                            <i class="fas fa-star starColor" ></i>
                                            <i class="fas fa-star starColor" ></i>
                                            <i class="fas fa-star starColor" ></i>
                                            <i class="fas fa-star" ></i>
                                            <i class="fas fa-star" ></i>
                                        </h4>
                                        <p>Sản phẩm rất tốt</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
            </div>
            <!-- san pham noi bat -->
            <div class="suggestedProduct col-xl-3 offset-xl-1">
                <div class="catogoryTitle">
                    <i class="fas fa-carrot"></i> SẢN PHẨM NỔI BẬT
                </div>
                <div class="suggestedProductContent">
                    <ul>
                        <li>
                            <img src="../../assets/images/tcmn-image12.jpg">
                            <div class="suggestedProductInfor">
                                <p>Dâu tây</p>
                                <h3>80.000<sup>₫</sup></h3>
                                <h4>
                                    <i class="fas fa-star"></i>
                                    <i class="fas fa-star"></i>
                                    <i class="fas fa-star"></i>
                                    <i class="fas fa-star"></i>
                                    <i class="fas fa-star"></i>
                                </h4>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- end Mo ta - danh gia san pham -->
        <!-- chi tiet san pham -->
    </div>
</template>

<script>
/**
 * created date: 19/06/2021
 * created by: VXKHANH
 */
export default {
    data() {
        return {
            number: 1,
        }
    },
    methods: {
        /**
         * created by: vxkhanh
         * created date: 21/6/2021
         * Hàm dùng để chuyển đến phần dánh giá sản phẩm khi nhấn nút "Đánh giá ngay"
         */
        ratingRow(){
            console.log("Hello");
            this.$refs.txt.focus();
            var element = this.$refs.txt;
            var top = element.offsetTop;
            window.scrollTo(0, top+200);
        },
        /**
        created date: 12/7/2021
        created by: VXKHANH
        Hàm sửu dụng để cộng thên số lượng sản phẩm
         */
        inscreaNumber() {
            this.number++;
        }
    },
}
</script>

<style lang="css" scoped>
    @import url("../../css/page/productDetail.css")
</style>