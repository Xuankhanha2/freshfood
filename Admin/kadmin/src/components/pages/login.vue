<template>
    <div class="login">
        <div class="loginForm">
            <div class="title">ĐĂNG NHẬP</div>
            <div class="error"
                v-if="false"
            >
                <i class="fas fa-exclamation-circle"></i> Tài khoản hoặc mật khẩu chưa chính xác!</div>
            <div class="loginContent">
                <div class="rowInput">
                    <div class="labelText">Tên tài khoản</div>
                    <div class="inputText">
                        <input type="text" name="username" placeholder="Username">
                    </div>
                </div>
                <div class="rowInput">
                    <div class="labelText">Mật khẩu</div>
                    <div class="inputText">
                        <input type="text" name="password" placeholder="Password">
                    </div>
                </div>
                <div class="rowInput">
                    <div class="checkRow">
                        <input type="checkbox" name="remember">
                        <label>Remember this account.</label>
                    </div>
                </div>
                <div class="btnInput">
                    <div class="btnSubmit">
                        Đăng nhập
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    
}
</script>

<style lang="css" scoped>
    @import url('../../css/dictionary/login.css');
</style>