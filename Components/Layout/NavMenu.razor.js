const openBtn = document.getElementById("openModal");
const closeBtn = document.getElementById("closeModal");
const modal = document.getElementById("modal");


openBtn.addEventListener("click", () => {
    const inner = modal.querySelector('.modal-inner');
    if (modal.classList.contains("open")) {
        inner.classList.remove('open-animate');
        inner.classList.remove('close-animate');
        void inner.offsetWidth; 
        inner.classList.add('close-animate');
        inner.addEventListener('animationend', function handler() {
            modal.classList.remove("open");
            inner.classList.remove('close-animate');
            inner.removeEventListener('animationend', handler);
        });
    } else {
        modal.classList.add("open");
        inner.classList.remove('close-animate');
        inner.classList.remove('open-animate');
        void inner.offsetWidth;
        inner.classList.add('open-animate');
    }
});