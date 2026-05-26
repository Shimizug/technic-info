<template>
  <v-app>
    <v-container>
      <v-data-table
        v-model="selected"
        :headers="headers"
        :items="items"
        item-key="id"
        hide-default-footer
        show-select
        @toggle-select-all="onSelectAll"
      >
        <template v-slot:[`item.data-table-select`]="{ item, isSelected, select }">
          <v-simple-checkbox
            :value="isSelected"
            :disabled="!isAdult(item)"
            @input="select($event)"
          />
        </template>
      </v-data-table>
    </v-container>
  </v-app>
</template>
<script>
export default {
  name: 'App',
  data() {
    return {
      selected: [],
      headers: [
        { text: 'Name', value: 'name' },
        { text: 'Age', value: 'age' },
      ],
      items: [
        { id: 1, name: 'John Doe', age: 30 },
        { id: 2, name: 'Jane Smith', age: 18 },
        { id: 3, name: 'Bob Johnson', age: 35 },
        { id: 4, name: 'Alice Williams', age: 28 },
        { id: 5, name: 'Charlie Brown', age: 32 },
        { id: 6, name: 'Emily Davis', age: 17 },
        { id: 7, name: 'Michael Wilson', age: 31 },
        { id: 8, name: 'Sarah Miller', age: 29 },
        { id: 9, name: 'David Anderson', age: 33 },
        { id: 10, name: 'Laura Taylor', age: 26 },
      ],
    }
  },
  methods: {
    isAdult(item) {
      return item.age >= 18
    },
    onSelectAll({ items, value }) {
      if (value) {
        this.selected = items.filter((item) => this.isAdult(item))
      } else {
        this.selected = []
      }
    },
  },
}
</script>