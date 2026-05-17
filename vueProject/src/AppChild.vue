<template>
  <Teleport to="body" :disabled="true">
    <div class="child">子供</div>
  </Teleport>
</template>
<style scoped>
.child {
  position: absolute;
  top: 25px;
  left: 50px;
  width: 1000px;
  height: 1000px;
  background: yellow;
}
</style>
