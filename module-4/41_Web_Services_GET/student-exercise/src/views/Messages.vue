<template>
  <div class="messages">
    <topic-details v-bind:TopicId="$route.params.id" />  
  </div>
</template>

<script>
import TopicDetails from '@/components/TopicDetails.vue';

export default {
  name: 'Messages',
  components: {
    TopicDetails
  }
}
</script>
