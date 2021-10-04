<template>
    <div class="mainMenu">
        <div class="menuContent">
            <div class="menuLeft">
                <ul>
                    <router-link to="/home">
                    <li>
                        Trang chủ
                    </li>
                    </router-link>

                    <router-link to="/category">
                    <li>
                        Danh mục
                        <div id="subMenu">
                            <div class="row justify-content-start">
                                <div class="col-xl-3 categoryItem"><a href="#">Thịt tươi</a></div>
                                <div class="col-xl-3 categoryItem"><a href="#">Rau củ tươi</a></div>
                                <div class="col-xl-3 categoryItem"><a href="#">Trứng</a></div>
                                <div class="col-xl-3 categoryItem"><a href="#">Thực phẩm đã chế biến</a></div>
                            </div>
                            <div class="row justify-content-start">
                                <div class="col-xl-3 categoryItem"><a href="#">Hải sản</a></div>
                                <div class="col-xl-3 categoryItem"><a href="#">Các loại gia vị</a></div>
                            </div>
                        </div>
                    </li>
                    </router-link>

                    <router-link to="/provider">
                    <li>
                        Nhà cung cấp
                    </li>
                    </router-link>

                    <router-link to="/news">
                    <li>
                        Tin tức
                    </li>
                    </router-link>

                    <router-link to="/introduct">
                    <li>
                        Giới thiệu
                    </li>
                    </router-link>

                    <router-link to="/contact">
                    <li>
                        Liên hệ
                    </li>
                    </router-link>
                </ul>
            </div>
            <div class="search">
                <div class="search-bg" style="position: relative">
                    <input type="text" name="search" id="key" placeholder="Tìm kiếm..." onkeyup="searchForm();" autocomplete="off">
                    <i class="fas fa-search" style="color: black; cursor: pointer" onclick="Search();"></i>
                    <div id="smartSearch">
                        <ul>
                            <li></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

export default {

};
</script>


<style lang="css" scoped>
@import url('../../css/layout/menu.css');
</style>