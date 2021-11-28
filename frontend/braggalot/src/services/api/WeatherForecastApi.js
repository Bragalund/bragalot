import axios from 'axios'

export default {
    getWeatherForcasts(){
        return axios.get('/weatherforecast',{
            headers: {
                
            }
        })
            .then(response => {
                return response.data
            })
    },
}