<script setup lang="ts">
import AppChild from './AppChild.vue'
</script>
<template>
  <div class="parent">
    <AppChild />
  </div>
</template>
<style scoped>
.parent {
  position: relative;
  width: 100px;
  height: 100px;
  background: red;
  overflow: hidden;
}
</style>
