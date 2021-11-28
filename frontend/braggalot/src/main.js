import { createApp } from 'vue'
import App from './App.vue'
import axios from 'axios'

axios.defaults.baseURL = 'https://localhost:7189'
axios.defaults.headers.common['Access-Control-Allow-Origin'] = '*';

createApp(App).mount('#app')
