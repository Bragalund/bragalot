<template>
<p>This is the weatherforecasts</p>
  <article v-for="forecast in forecasts" :key="forecast.id">
    <p>{{ forecast.summary }} {{ forecast.temperatureC }}</p>
  </article>
</template>

<script>
import WeatherForecastApi from "@/services/api/WeatherForecastApi";

export default {
  name: 'WeatherForecast',

  data() {
    return {
      loading: true,
      forecasts: []
    }
  },


  created() {
    WeatherForecastApi.getWeatherForcasts().then(forecasts => {
      this.forecasts = forecasts
    }).catch(error =>
        console.log(error))
        .finally(() => {
              this.loading = false
            }
        )
  }
}
</script>

<style scoped>

</style>