<template>
    <div class="sideBar">
            <div class="catogory-title">
                <i class="fas fa-carrot"></i> DANH MỤC SẢN PHẨM
            </div>
            <div class="catogory-content">
                <ul> 
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Thịt tươi</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Hoa quả</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Rau củ tươi</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Hải sản</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Thịt tươi</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Gia vị nấu ăn</a></li>
                    <li><a href="/Product/PhanLoaiSanPham/@item.id"><i class="fab fa-envira"></i>Thực phẩm đã chế biến</a></li>

                </ul>
            </div>
        </div>
</template>

<script>
export default {
    
}
</script>

<style lang="css">
.slideBar {
    margin: 0px;
    padding: 0px;
    width: 100%
}

.catogory-title {
    line-height: 35px;
    background-color: #f99717;
    border-radius: 5px 5px 0px 0px;
    padding-left: 15px;
    color: white;
    font-weight: bold;
    font-size: 16px;
}

.catogory-content{
    margin: 0px;
    padding: 0px;
    width: 100%;
    height: 300px;
    border: 1px solid #f99717;
    padding-bottom: 5px;
    border-radius: 0px 0px 5px 5px;
    overflow-y: scroll;
}

.catogory-content::-webkit-scrollbar {
    width: 5px;
    border-radius: 5px;
    display: none;
}

.catogory-content::-webkit-scrollbar-button {
    display: none;
}

.catogory-content::-webkit-scrollbar-thumb {
    background: darkred;
}

.catogory-content ul {
    margin: 0px;
    padding: 0px;
    list-style: none;
}

.catogory-content ul li {
    line-height: 35px;
    padding-left: 25px;
    background-color: #fef79c;
    margin-bottom: 1px;
    cursor: pointer;
}

.catogory-content ul li a {
    color: #5c3d21;
    font-size: 14px;
    text-decoration: none;
}

.catogory-content ul li:hover {
    background-color: #ffcc4d;
}

.catogory-content ul li i {
    color: #258031;
    margin-right: 10px;
}
</style>