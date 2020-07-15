// TODO: listen to DOMContentLoaded
document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('formContact');
    form.addEventListener('submit', (event) => {
        console.log(event);
        alert("Seriously? Don't actually submit confidential information to untrusted sources!");

        event.preventDefault();
    });
});