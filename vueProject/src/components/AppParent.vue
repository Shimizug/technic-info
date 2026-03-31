<script setup lang="ts">
import { ref } from 'vue'

const person = ref(null)

function fetchPerson() {
  return new Promise((resolve) => {
    setTimeout(() => {
      resolve({ name: '鈴木' })
    }, 2000)
  })
}
person.value = await fetchPerson()
</script>
<template>
  <div v-if="person">
    <p>{{ person.name }}でした</p>
  </div>
</template>
