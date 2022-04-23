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
                        <input type="text" name="username" placeholder="Username" 
                            v-model="user.username"
                            autocomplete="off"
                        >
                    </div>
                </div>
                <div class="rowInput">
                    <div class="labelText">Mật khẩu</div>
                    <div class="inputText">
                        <input type="password" name="password" placeholder="Password"
                            v-model="user.password"
                            autocomplete="off"
                        >
                    </div>
                </div>
                <div class="rowInput">
                    <div class="checkRow">
                        <input type="checkbox" name="remember"
                            v-model="remember"
                        >
                        <label>Remember this account.</label>
                    </div>
                </div>
                <div class="btnInput">
                    <div class="btnSubmit"
                        @click="submitLogin()"
                    >
                        Đăng nhập
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
import apiPath from '../../path'
export default {
    data() {
        return {
            // Object user sử dụng để gửi request đăng nhập
            user: {
                username: "",
                password: ""
            },
            // Biến để check có có ghi nhớ login hay không
            remember: false,
            required:{
                username: false,
                password: false
            }
        }
    },
    created(){
        if(localStorage.getItem("user")){
            this.user = JSON.parse(atob(localStorage.getItem("user")));
        }
    },
    methods: {
        /**
         * created date: 19/01/2022
         * created by: khanhvx
         * Hàm gửi yêu cầu đăng nhập
         */
        async submitLogin(){
            if(this.validateForm()){
                let accessToken;
                await axios.post(apiPath.login, this.user).then((res)=>{
                    accessToken = res.data;
                }).catch(()=>{
                    alert("Login fail!");
                })
                if(accessToken){
                    localStorage.setItem('accessToken', accessToken);
                    if(this.remember){
                        this.remeberAccount(this.user);
                    }
                    this.$router.push('/dashboard');
                }
            }
        },

        /**
         * created date: 19/04/2022
         * created by: khanhvx
         * Hàm validate form đăng nhập trước khi gửi yêu cầu đăng nhập
         */
        validateForm(){
            let isValid = true;
            if(this.isNullOrUndefined(this.user.username) || String(this.user.username).trim() === "")
            {
                this.required.username = true;
                isValid = false;
            }else{
                this.required.username = false; 
            }
            if(this.isNullOrUndefined(this.user.password) || String(this.user.password).trim() === ""){
                this.required.password = true;
                isValid = false;
            }
            else{
                this.required.password = false;
            }
            return isValid;
        },
        
        /**
         * created date: 23/04/2022
         * created by: khanhvx
         * Hàm kiểm tra giá trị của biến có phải là null hay undefined hay không
         */
        isNullOrUndefined(value){
            if( value === null || value === undefined){
                return true;
            }
            else{
                return false;
            }
        },

        /**
         * created date: 23/04/2022
         * created by: Khanhvx
         * Hàm lưu tài khoản login của người dùng vào Local storage
         */
        remeberAccount(user){
            if(user && !this.isNullOrUndefined(user.username) &&
                !this.isNullOrUndefined(user.password)){
                localStorage.setItem("user", btoa(JSON.stringify(this.user)));
            }
        },

        /**
         * created date: 23/04/2022
         * created by: khanhvx
         * Hàm kiểm tra token xem đã hết hạn chưa
         */
        checkingToken(){
            
        }
    },
}
</script>

<style lang="css" scoped>
    @import url('../../css/dictionary/login.css');
</style>