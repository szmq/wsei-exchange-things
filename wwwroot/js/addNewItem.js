const alertElement = document.querySelector("#success-alert");
const formElement = document.querySelector("form");

async function addNewItem(event) {
    event.preventDefault();
    const requestData = new FormData(event.target);
    const response = await fetch('/Exchanges/Add', {
        method: 'post',
        body: requestData
    });
    if (response.ok) {
        const responseJson = await response.json();
        alertElement.style.display = 'block';
        console.log('added successfully', response);
    }
}

formElement.addEventListener("submit", addNewItem);
