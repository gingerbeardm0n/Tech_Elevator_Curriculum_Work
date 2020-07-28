<template>
  <div  class="card" v-bind:class="{'read': book.read}">
       <h2 class="book-title">{{book.title}}</h2> 
       <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
       <h3 class="book-author">{{book.author}}</h3>
       <button class="mark-read" 
               v-if="book.read"
               v-on:click="flipstatus(book.isbn)">Mark Read</button>
       <button class="mark-unread" 
               v-else
               v-on:click="flipstatus(book.isbn)">Mark Unread</button>

  </div>
</template>

<script>
export default {
    name: 'book-card',
    props: ['book'],

    computed: {
        isBookRead() {
        return this.$store.state.book.read
      }
    },
    methods: {
        flipstatus() {
            this.$store.commit('FLIP_STATUS', this.book.isbn);
        }
    }
    
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>