<template>
    <header class="header">
        <div class="headerContent">
            <div class="headerLeft col-xl-8">
                <ul>
                    <li>
                        <i class="fas fa-mobile-alt h-icon"></i>
                        <a href="#" class="hotline">Hotline: 0985.334.786</a>
                    </li>
                    <li>
                        <i class="far fa-envelope h-icon"></i>
                        <a href="#" class="email">Email: freshfood24@gmail.com</a>
                    </li>
                    <li>
                        <i class="fas fa-map-marker-alt h-icon"></i>
                        <a href="#" class="topAddress">Địa chỉ: Hà Nội</a>
                    </li>
                </ul>
            </div>
            <!-- /header left -->
            <div class="headerRight col-xl-4 d-flex justify-content-end">
                    <ul v-if="!logedIn">
                        <li><router-link to="/login">Đăng nhập</router-link></li>
                        <li><router-link to="/register">Đăng ký</router-link></li>
                    </ul>
                    <ul v-if="logedIn" class="col-xl-12">
                        <li class="col-xl-8">
                            <img src="../../assets/logo.png" id="avatar">
                            <a href="#">{{userName}}</a>
                            <ul class="sub-account-option col-xl-12">
                                <li><a href="#"><i class="fas fa-user-edit"></i> Thông tin tài khoản</a></li>
                                <li><a href="#"><i class="far fa-heart"></i> Sản phẩm ưa thích</a></li>
                                <li><a href="#"><i class="fas fa-sign-out-alt"></i> Đăng xuất</a></li>
                            </ul>
                        </li> 
                    </ul>
            </div>
            <!-- /header-right -->
        </div>
    </header>
</template>

<script>
export default {
    data(){
        return {
            userName: "",
            logedIn: false,
        }
    },
    created(){
        this.userName = localStorage.getItem('userName')
        if(this.userName != null && this.userName != "")
            this.logedIn = true;
        else
            this.logedIn = false;
    }
}
</script>

<style lang="css" scoped>
@import url('../../css/fontawsome/css/all.css');
    @import url('../../css/layout/header.css');
</style>