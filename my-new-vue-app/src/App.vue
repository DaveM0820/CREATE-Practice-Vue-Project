<template>
  <div id="app">
    <DataHandler />
  </div>
</template>

<script>
import DataHandler from './components/DataHandler.vue';

export default {
  name: 'App',
  components: {
    DataHandler
  }
};
</script>

<style>
/* Global styles for your app */
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
