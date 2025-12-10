window.initSwiper = () => {
    if (window.mySwiper) window.mySwiper.destroy();

    window.mySwiper = new Swiper('.swiper', {
        direction: 'horizontal',
        loop: false,
        slidesPerView: 1,
        loopFillGroupWithBlank: true,
        pagination: { el: '.swiper-pagination', clickable: true },
    });
};


const modal = document.getElementById("#modal");
if (modal) {
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    };
}
