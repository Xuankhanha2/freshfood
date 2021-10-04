<template>
    <div class="categoryPage">
        <div class="widgetBar">
            <div class="history">
                <span class="parentPage"><a href="/Home">Trang chủ</a></span>
                <span style="padding: 0px 8px; color:brown">/</span>
                <span class="currentPage">Danh mục sản phẩm</span>
            </div>
            <div class="filterPrice">
                <label>(Giá) Từ: </label>
                <input type="text" name="price_from" id="from" size="15" required />
                <label>Đến: </label>
                <input type="text" name="price_to" id="to" size="15" required />
                <button id="btnFilter">Lọc</button>
            </div>
            <div class="sort">
                <label for="">Sắp xếp: </label>
                <select name="sort" id="sort">
                    <option value="0">--Chọn--</option>
                    <option value="priceAsc">Giá tăng dần</option>
                    <option value="priceDesc">Giá giảm dần</option>
                    <option value="nameAsc">Sắp xếp A-Z</option>
                    <option value="nameDesc">Sắp xếp Z-A</option>
                </select>
            </div>
        </div>
        <div class="productRow">
            <!-- <div class="title"><div class="categoryName">TRÁI CÂY MỖI NGÀY</div></div> -->
            <div class="productList row">
                <div class="marginProductCell col-xl-3">
                    <div class="productCell">
                        <router-link to="/productDetail"><img src="../../assets/images/tcmn-image3.jpg"></router-link>
                        <router-link to="/productDetail"><h1>Hồng xanh</h1></router-link>
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
                        <p>80.000 ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-20%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary">Thêm vào giỏ</div>
                    </div>
                </div>

                <div class="marginProductCell col-xl-3">
                    <div class="productCell">
                        <router-link to="/productDetail"><img src="../../assets/images/tcmn-image3.jpg"></router-link>
                        <router-link to="/productDetail"><h1>Hồng xanh</h1></router-link>
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
                        <p>80.000 ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-20%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary">Thêm vào giỏ</div>
                    </div>
                </div>

                <div class="marginProductCell col-xl-3">
                    <div class="productCell">
                        <router-link to="/productDetail"><img src="../../assets/images/tcmn-image3.jpg"></router-link>
                        <router-link to="/productDetail"><h1>Hồng xanh</h1></router-link>
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
                        <p>80.000 ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-20%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary">Thêm vào giỏ</div>
                    </div>
                </div>

                <div class="marginProductCell col-xl-3">
                    <div class="productCell">
                        <router-link to="/productDetail"><img src="../../assets/images/tcmn-image3.jpg"></router-link>
                        <router-link to="/productDetail"><h1>Hồng xanh</h1></router-link>
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
                        <p>80.000 ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-20%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary">Thêm vào giỏ</div>
                    </div>
                </div>

                <div class="marginProductCell col-xl-3">
                    <div class="productCell">
                        <router-link to="/productDetail"><img src="../../assets/images/tcmn-image3.jpg"></router-link>
                        <router-link to="/productDetail"><h1>Hồng xanh</h1></router-link>
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
                        <p>80.000 ₫</p>

                        <!-- discount percent -->
                        <div class="sale">-20%</div>

                        <!-- button add wishlist -->
                        <div class="wishlist"><i class="far fa-heart"></i></div>

                        <!-- button Thêm vào giỏ -->
                        <div class="btn btn-primary">Thêm vào giỏ</div>
                    </div>
                </div>
                
            </div>
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            
        }
    },
    methods: {
        change(arr){
            
            this.className = arr;
        }
    },
}
</script>
<style lang="css">
@import url('../../css/page/categoryPage.css');
</style>