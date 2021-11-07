<template>
    <div class="registerPage col-xl-4 container">
        <!-- Thông báo khi có lỗi đăng nhập -->
        <div class="notify container col-xl-12">
            <div class="alert alert-danger" v-show="false"><i class="fas fa-exclamation-triangle"></i> Tài khoản hoặc mật khẩu không đúng</div>
        </div>
        <!--  -->
        <div class="loginContent container col-xl-12">
            <!-- Logo đăng nhập -->
            <div class="loginLogo container col-xl-6">
                Đăng nhập
            </div>
            <!-- / -->

            <!-- form đăng nhập -->
            <div class="loginForm">
                <!-- Tên tài khoản -->
                <div class="formGroup">
                    <label class="col-form-label">Tên tài khoản</label>
                    <input class="loginInput form-control shadow-none" type="username" name="username" placeholder="Username" value="">
                </div>
                <!-- / -->

                <!-- Mật khẩu -->
                <div class="formGroup">
                    <label class="col-form-label shadow-none">Mật khẩu</label>
                    <input class="loginInput form-control shadow-none" type="password" name="password" placeholder="Password" value="">
                </div>
                <!-- / -->

                <!-- Ghi nhớ tài khoản và quên mật khẩu -->
                <div class="loginCheckbox">
                    <div class="rememberMe d-flex">
                        <input type="checkbox" name="remember" id="checkBox" class="container col-xl-1">
                        <label class="col-form-label col-xl-11" style="padding-left: 0px !important">Ghi nhớ tài khoản này?</label>
                    </div>
                    <label class="col-form-label" id="forgotPassword">
                        <a href="#">Quên mật khẩu?</a>
                    </label>
                </div>
                <!-- / -->

                <!-- Nút đănh nhập -->
                <button class="btn btn-success btn-block" type="submit" style="font-size: 18px;">Đăng nhập</button>
                <!-- / -->

                <!-- Đăng ký tài khoản khi chưa có tài khoản -->
                <div id="registerLink">
                    <p class="container">
                        Bạn chưa có tài khoản?
                        <a href="/Account/Register">Đăng ký tại đây</a>
                    </p>
                </div>
                <!-- / -->
            </div>
            <!-- / -->
        </div>
    </div>
</template>

<script>

export default {
    
}
</script>
<style lang="css">
@import url('../../css/page/register.css');
</style>