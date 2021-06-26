<template>
    <div class="mainMenu">
        <div class="menuContent">
            <div class="menuLeft">
                <ul>
                    <li><a href="/Home">Trang chủ</a></li>
                    <li>
                        <a href="/Product/Index">Sản phẩm</a>
                        <ul>
                            <li><a href="/Product/PhanLoaiSanPham/@item.id">item1</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Nhà cung cấp</a></li>
                    <li><a href="/News/listNews">Tin tức</a></li>
                    <li><a href="#">Giới thiệu</a></li>
                    <li><a href="/Home/Contact">Liên hệ</a></li>
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