<template>
    <div class="categoryPage">
        <div v-for="(arr,index) in array" :key="index" class="btn" 
            @Click="change(arr)"
        >
            {{arr}}
        </div>

        <div width="400" height="500" :class="className">
            khanh
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            check: true,
            nameK: 'KHanh',
            array:['red','blue','yellow'],
            className : 'color',
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
    .yellow{
        background: Yellow;
    }
    .red{
        background: red;
    }
    .blue{
        background: blue;
    }
    .btn{
        display: inline-block;
        background: #dddddd;
        margin: 10px;
    }
</style>