<script setup lang="ts">
import { ref } from 'vue'
const selected = ref<string[]>([])
const headers = [
  { title: 'Name', key: 'name' },
  { title: 'Age', key: 'age' },
]

const items = [
  { id: 1, name: 'John Doe', age: 30 , aa :true},
  { id: 2, name: 'Jane Smith', age: 10 , aa :false},
  { id: 3, name: 'Bob Johnson', age: 35 , aa :true},
  { id: 4, name: 'Alice Williams', age: 28 , aa :true},
  { id: 5, name: 'Charlie Brown', age: 32 , aa :true},
  { id: 6, name: 'Emily Davis', age: 17 , aa :false},
  { id: 7, name: 'Michael Wilson', age: 31 , aa :true},
  { id: 8, name: 'Sarah Miller', age: 29 , aa :true},
  { id: 9, name: 'David Anderson', age: 33 , aa :true},
  { id: 10, name: 'Laura Taylor', age: 26 , aa :false},
]

const isAdult = (item: { age: number }) => item.age >= 18
</script>

<template>
  <v-app>
    <v-container>
  <v-data-table
    v-model="selected"
    :headers="headers"
    :items="items"
    item-value="id"
    item-selectable="aa"
    hide-default-footer
    show-select
  >
    <template v-slot:[`item.data-table-select`]="{ item, props }">
      <v-checkbox-btn v-bind="props" :disabled="!isAdult(item)" />
    </template>
  </v-data-table>
    </v-container>
  </v-app>
</template>
