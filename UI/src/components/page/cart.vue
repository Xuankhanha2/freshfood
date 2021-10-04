<template>
    <div class="cartView">
        <h3 class="cartTitle"><i class="fas fa-shopping-cart">
            </i> GIỎ HÀNG 
            <span id="count_sp">(có 0 sản phẩm)</span>
        </h3>
        <div class="cartContent row">
            <div class="cartContentLeft col-xl-9">
                <!-- drop-box -->
                <div>
                    <table class="listProduct">
                        <tr>
                            <th>Hình ảnh</th>
                            <th>Tên hàng</th>
                            <th>Đơn giá</th>
                            <th>Số lượng</th>
                            <th>Thành tiền</th>
                            <th> </th>
                        </tr>
                        <tr>
                            <td><img src="../../assets/images/zalo.png" alt=""></td>
                            <td><a href="/Product/ChiTietSanPham/@item.id">Hồng xanh</a></td>
                            <td>100.000 ₫</td>
                            <td>
                                <input type="number" min="1" id="number" name="number" value="0" style="width: 50px">
                            </td>
                            <td>100.000 ₫</td>
                            <td class="deleteProduct"><a href="javascript: Delete_Load(@item.id); UpdateCart();"><i class="fas fa-times"></i></a></td>
                        </tr>

                        <tr>
                            <td><img src="../../assets/images/zalo.png" alt=""></td>
                            <td><a href="/Product/ChiTietSanPham/@item.id">Hồng xanh</a></td>
                            <td>100.000 ₫</td>
                            <td>
                                <input type="number" min="1" id="number" name="number" value="0" style="width: 50px">
                            </td>
                            <td>100.000 ₫</td>
                            <td class="deleteProduct"><a href="javascript: Delete_Load(@item.id); UpdateCart();"><i class="fas fa-times"></i></a></td>
                        </tr>
                        <tr v-if="false">
                            <td colspan="5">
                                Chưa có mặt hàng nào.
                            </td>
                        </tr>
                    </table>
                    <a href="/Home" class="btn btn-dark"> Tiếp tục mua hàng</a>
                    <a href="javascript: Clear()"><div class="btn btn-primary"><i class="fas fa-trash-alt"></i> Xóa toàn bộ</div></a>
                </div>
                <!-- end drop box -->
            </div>
            <div class="payInfor col-xl-3">
                <div class="saleTiket">
                    <p>Mã khuyến mại</p>
                    <span><a href="#"><i class="fas fa-ticket-alt"></i> Chọn mã khuyến mại</a></span>
                </div>
                <div class="payBox">
                    <p>Chọn khu vực giao hàng</p>
                    <form class="local">
                        <input type="radio" name="address"> <label>Bắc Từ Liêm - Hà Nội</label>
                        <br>
                        <input type="radio" name="address"> <label>Quận 10 - TP. HCM</label>
                    </form>
                    
                    <h4>Thành tiền: <span id="total">00 ₫</span></h4>
                </div>
                <a href="/Cart/Checkout"><div class="btn-danger pay">Thanh toán</div></a>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    
}
</script>

<style lang="css" >
    @import url('../../css/page/cart.css');
</style>