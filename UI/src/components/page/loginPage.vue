<template>
    <div class="loginPage" style="padding-top: 20px !important">
                <div class="notify">
                    <div class="alert alert-danger"><i class="fas fa-exclamation-triangle"></i> Tài khoản hoặc mật khẩu không đúng</div>
                </div>
                <div class="loginContent">
                    <div class="loginLogo">
                        <a href="#">
                            <h1>Đăng nhập</h1>
                        </a>
                    </div>
                    <div class="loginForm">
                        <form action="" method="post">
                            <div class="formGroup">
                                <label>Email</label>
                                <input class="au-input au-input--full" type="email" name="email" placeholder="Email" value="@coockieEmail()">
                            </div>
                            <div class="formGroup">
                                <label>Mật khẩu</label>
                                <input class="au-input au-input--full" type="password" name="password" placeholder="Password" value="@coockiePass()">
                            </div>
                            <div class="loginCheckbox">
                                <label>
                                    <input type="checkbox" name="remember">Nhớ tài khoản này
                                </label>
                                <label>
                                    <a href="#">Quên mật khẩu?</a>
                                </label>
                            </div>
                            <button class="au-btn au-btn--block au-btn--green m-b-20" type="submit">Đăng nhập</button>
                        </form>
                        <div class="registerLink">
                            <p>
                                Bạn chưa có tài khoản?
                                <a href="/Account/Register">Đăng ký tại đây</a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
</template>

<script>
export default {
    
}
</script>

<style lang="css">
    @import url('../../css/page/login.css');
</style>