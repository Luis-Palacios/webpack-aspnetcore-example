import { searchNews } from "./api-client/news-client";

let yearSelect = document.getElementById('ddl-years');

yearSelect.addEventListener('change', (evt) => {
    var value = evt.target.value;
    searchNews('Netflix', value).then((res) => {
        console.log(res);
    });
});