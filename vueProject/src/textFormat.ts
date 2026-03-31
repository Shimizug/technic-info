import { ref, computed } from 'vue'

export function putParenthesesAround() {
  const input = ref('')
  const formatted = computed(() => `[${input.value}]`)
  return { input, formatted }
}
