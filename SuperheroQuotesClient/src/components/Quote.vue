<template>
  <div class="superhero-quote">
    <div class="quote">
      {{ heroquote.quote }}
    </div>
    <span class="superhero">
      - {{ heroquote.name }}
    </span>
  </div>
</template>

<style scoped>
.quote {
  font-size: var(--quote-size);
  color: var(--quote-color);
}

.superhero {
  font-size: var(--super-hero-size);
  color: var(--super-hero-color);
}

.superhero-quote {
  background: var(--quote-box-color);
}
</style>

<script  lang="ts">
export default {
  data() {
    return {
      heroquote: {} as { quote: string, name: string }
    };
  },
  created() {
    this.fetchData();
    setInterval(this.fetchData, 10000);
  },
  methods: {
    async fetchData() {
      const res = await fetch("http://localhost:5016/Quote");
      const data = await res.json();
      this.heroquote = data;
    },
  },
};
</script>