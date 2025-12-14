const modal = document.getElementById('modal');
const closeBtn = document.getElementsByClassName('closeModal');

openBtn.addEventListener('click', () => {
    modal.classList.add('open');
});

closeBtn.addEventListener('click', () => {
    modal.classList.remove('open');
});