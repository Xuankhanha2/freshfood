<template>
    <div class="popup">
        <div class="form categoryDetail">
            <!-- <button @click="ValideteForm()">Load</button> -->
            <div class="form-title">
                {{pageTitle}}
            </div>
            <div class="form-content">
                <div class="form-left deleteBorderRight changePaddingBottom">
                    <!-- Tiêu đề tin -->
                    <newLabel :text="'Tiêu đề tin:'" 
                        :required="true"/>
                    <div class="input">
                        <input type="text" 
                            class="textbox margin-r-16"
                            v-model="news.newsTitle"
                            @keyup="required.newsTitle = false"
                        >
                        <div class="tooltip tooltipChangePosition" 
                            v-show="required.newsTitle">
                                Dữ liệu không được để trống!
                        </div>
                    </div>
                    <!-- / -->

                    <!-- Mô tả về tin -->
                    <newLabel :text="'Mô tả tin tức'" 
                        :required="false"/>
                    <div class="input">
                        <textarea
                            class="textbox margin-r-16"
                            v-model="news.description"
                        >   
                        </textarea>
                        <div class="tooltip" 
                            v-show="false">
                                Dữ liệu không được để trống!
                        </div>
                    </div>
                    <!-- / -->

                    <!-- Nội dung tin -->
                    <newLabel :text="'Nội dung tin tức'" 
                        :required="false"
                        title="Thẻ icon có thể lấy trên trang Fontawsome"
                    />
                    <div class="newsContent">
                        <ckeditor :editor="editor" v-model="news.newsContent" :config="editorConfig" ></ckeditor>
                    </div>
                    <!-- / -->

                    <!-- Checkbox tin tức hot -->
                    <div class="form-right-bottom-content">
                        <div class="form-r-col">
                            <div class="row-check">
                                <input type="checkbox" 
                                    v-model="news.hotNews"
                                >
                                <label></label>
                                <div class="col-row-text">
                                    Tin hot
                                </div>
                            </div>
                        </div>
                        <div class="form-r-col">
                            <!--  -->
                        </div>
                    </div>
                    <!-- /Checkbox tin tức hot -->

                    <!-- Ô nhập link ảnh hiển thị của tin tức -->
                    <newLabel :text="'Link ảnh hiển thị'" 
                        :required="false"
                        title="Thẻ icon có thể lấy trên trang Fontawsome"
                    />
                    <div class="input">
                        <!-- Ô nhập dữ liệu -->
                        <input type="text" 
                            ref="feeName" 
                            class="textbox margin-r-16"
                            :class="{'required-outline':false}"
                            v-model="news.newsImage"
                        >
                        <!-- Tooltip thông báo khi dữ liệu của trường này bị để trống khi gửi -->
                        <div class="tooltip " 
                            v-show="false">
                                Dữ liệu không được để trống!
                        </div>
                    </div>
                    <!-- /Ô nhập link ảnh hiển thị của tin tức -->

                </div>
                
            </div>
            <div class="form-footer">
                <div class="f-footer-left">
                    <div class="row-check non-margin">
                        
                    </div>
                </div>
                <div class="f-footer-right">
                    <newButton
                        :Text="'Đóng'"
                        :second="true"
                        @click.native="closeForm()"
                    />
                    <newButton 
                        :Text="'Lưu'"
                        :second="false"
                        @click.native="processData"
                    />
                </div>
            </div>
            <div class="btn-close-form"
                @click="closeForm()"
            ></div>
        </div>
        <div class="blur">

        </div>
        <newPopup  
            :thirdBtn="true"
            :text="notifyText"
            v-if="popup"
            @closePopup="closePopup"
        />
    </div>
</template>

<script>
/**
    created by: vu xuan khanh
    created date: 27/7/2021
*/
import newLabel from '../../layout/label.vue'
import newButton from '../../layout/button.vue'
import axios from 'axios'
import newPopup from '../../popup/notifyPopup.vue'
import ClassicEditor from '@ckeditor/ckeditor5-build-classic';

export default {
    props:{
        pageTitle:String,
        focusOn: Boolean,
        isUpdate: Boolean,
        refNews: Object,
    },
    data() {
        return {
            /**Biến chứa giá trị danh mục khi cập nhật */
            news: {},
            /**Biến kiểm tra các ô không được để dữ liêu trống */
            required:{
                newsTitle:false,
                newsImage:false,
                newsDescription: false
            },
            /*Nội dung thông báo*/
            notifyText: '',
            /*Biến hiển thị thông báo*/
            popup: false,
            /*Biến của CKEditor*/
            editor: ClassicEditor,
            editorConfig: {
                // The configuration of the editor.
            }
        }
    },
    beforeUpdate(){
        
    },
    components:{
        // Textbox,
        newLabel,
        newButton,
        newPopup
    },
    methods:{
        // Save:async function(){}
        //Hàm dùng để đóng form khi nhấn vào nút đóng
        closeForm(){
            this.$emit('closeForm');
        },
        /**Hàm xử lý cho nút gửi dữ liệu  bào gồm cả thêm và sửa*/
        async processData(){
            // var rowAffect = 0;
            var processResult;
            //Validate dữ liệu
            var isValid = this.validateData();
            //Kiem tra dữ liệu hợp lệ. Nếu hợp lệ thì thực hiện thêm - sửa
            if(isValid){
                if(this.isUpdate){
                    //Thục hiện sửa
                    await axios.put('https://localhost:44368/api/v1.0/categories',this.cloneCategory).then((result)=>{
                        processResult = result.data;
                        //Hiển thị kết quả sau khi xử lý
                        this.notifyText = processResult.message;
                        this.popup = true;
                        this.loadData();
                    }).catch(()=>{
                        this.notifyText = "Đã có lỗi xảy ra.";
                        this.popup = true;
                        
                    })
                    
                }else{
                    //Thực hiện thêm
                    await axios.post('https://localhost:44368/api/v1.0/categories',this.cloneCategory).then((result)=>{
                        processResult = result.data;
                        //Hiển thị kết quả sau khi xử lý
                        this.notifyText = processResult.message;
                        this.popup = true;
                        this.loadData();
                    }).catch(()=>{
                        this.popup = true;
                        this.notifyText = "Đã có lỗi xảy ra.";
                    })
                    
                }
                console.log(processResult);
            }else{
                //Nếu dữ liệu chưa hợp lệ thì kết thúc hàm bằng lệnh return 
                console.log("Return");
                return;
            }
            
        },
        /**Hàm xử lý nghiệp vụ cho các ô nhập liệu*/
        validateData(){
            var newsTitle = this.cloneCategory.categoryName;
            //Thực hiện kiểm tra dữ liêu hợp lệ
            var isValid = true;
            if(newsTitle == "" | newsTitle == null | newsTitle == undefined){
                isValid = false;
                this.required.newsTitle = true;
            }else{
                newsTitle = String(newsTitle);
                newsTitle = newsTitle.trim();
                if(name == ""){
                    isValid = false;
                    this.required.newsTitle = true;
                }
                else{
                    this.required.newsTitle = false;
                    this.news.newsTitle = newsTitle;
                }   
            }
            return isValid;
        },
        /*Hàm xử lý sự kiện đóng popup thông báo*/
        closePopup(){
            this.notifyText = "";
            this.popup = false;
            
        },
        /**load dữ liệu khi thực hiện thêm, sửa thành công */
        loadData(){
            this.$emit('loadData');
        }  
    },
    created() {
        if(this.refNews != null){
            this.news={...this.refNews};
            console.log(this.news);
        }
    },
}
</script>

<style lang="css" scoped>
    @import'../../../css/dictionary/product/productDetail.css';
    @import'../../../css/dictionary/news/newsDetail.css';
</style>