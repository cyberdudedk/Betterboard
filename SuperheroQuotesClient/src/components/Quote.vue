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

<script  lang="ts">
export default {
  data() {
    return {
      heroquote: {} as { quote: string, name: string }
    };
  },
  created() {
    this.fetchData();
  },
  methods: {
    fetchData() {
      this.heroquote = {
        quote: "This is a quote",
        name: "Superman",
      };
    },
  },
};
</script>