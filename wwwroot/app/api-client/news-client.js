import config from './api-config';
import axios from 'axios';

export function searchNews(searchTerm, publishedYear) {
    return axios.get(`${config.baseUrl}news?searchTerm=${searchTerm}&publishedYear=${publishedYear}`)
}
