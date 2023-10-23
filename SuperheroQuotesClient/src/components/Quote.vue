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
  text-align: right;
  font-weight: 700;
}

.superhero-quote {
  background: var(--quote-box-color);
  border: 3px solid var(--quote-box-border);
  padding: 3rem;
  display: flex;
  flex-direction: column;
  gap: 1rem;
  box-shadow: rgba(0, 0, 0, 0.35) 0.3rem 0.2rem 1rem;
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
    setInterval(this.fetchData, parseInt(process.env.TIMER_INTERVAL));
  },
  methods: {
    async fetchData() {
      const res = await fetch(process.env.API_BASE + "/Quote");
      const data = await res.json();
      this.heroquote = data;
    },
  },
};
</script>