import { createApp } from 'vue'
import App from './App.vue'
import axios from 'axios'

axios.defaults.baseURL = 'http://localhost:7158'
axios.defaults.headers.common['Access-Control-Allow-Origin'] = '*';

createApp(App).mount('#app')
