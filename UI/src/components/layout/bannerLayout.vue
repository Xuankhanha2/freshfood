<template>
  <div class="banner">
    <div class="bannerLogo">
      <a href="/Home/index"
        ><img src="../../assets/images/Banner-logo.jpg" alt=""
      /></a>
    </div>
    <div class="bannerContent">
      <ul>
        <li>
          <img src="../../assets/images/banner-image1.jpg" />
          <div>
            <h1>Giao hàng miễn phí</h1>
            <p>Bán kính 100km</p>
          </div>
        </li>
        <li>
          <img src="../../assets/images/banner-image2.jpg" alt="" />
          <div>
            <h1>Hỗ trợ trực tuyến 24/7</h1>
            <p>Hotline: 19001070</p>
          </div>
        </li>
        <li>
          <img src="../../assets/images/banner-image4.jpg" alt="" />
          <div>
            <h1>Đảm bảo chất lượng</h1>
            <p>Thực phẩm tươi, sạch</p>
          </div>
        </li>
      </ul>

      <div class="cart">
        <i class="fas fa-shopping-bag"></i>
        <a href="/Cart/Index">Giỏ hàng</a>
        <div id="countCart"><span>0</span></div>
      </div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style lang="css" scoped>
@import url("../../css/layout/banner.css");
</style>