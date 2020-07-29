<template>
  <div class="topic-list">
    <router-link v-bind:to="{name: Messages, params: {id: topic.id}}" 
                 v-for="topic in topics" 
                 v-bind:key="topic.id" 
                 class="topic">
    <div >{{ topic.title }}</div>
    </router-link>
  </div>
</template>

<script>
import TopicsService from "../services/TopicsService.js";

export default {
  name: "topic-list",
  data() {
    return {
      topics: [],
    };
  },
  created() {
     TopicsService.getTopics()
      .then((response) => {
        this.topics = response.data;
      })
      .catch((error) => {
        console.error(error);
      });
  },
};
</script>

<style>
.topic-list {
  padding: 20px 20px;
  margin: 0 auto;
  max-width: 600px;
}
.topic {
  font-size: 24px;
  border-bottom: 1px solid #f2f2f2;
  padding: 10px 20px;
}
.topic:last-child {
  border: 0px;
}
</style>