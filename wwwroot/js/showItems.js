const div = document.querySelector("#items");

async function getAllItems() {
    const response = await fetch('/Exchanges/ShowAll');
   
    if (response.ok) {
        const responseJson = await response.json();
        console.log('responseJson', responseJson);
        let html = '';
        responseJson.forEach(item => {
            if (item.isVisible) {
                html += `<p>Id: ${item.id}, name: ${item.name}, description: ${item.description}</p>`;
            }
        })

        debugger;
        div.innerHTML = html;

    }
}

getAllItems();