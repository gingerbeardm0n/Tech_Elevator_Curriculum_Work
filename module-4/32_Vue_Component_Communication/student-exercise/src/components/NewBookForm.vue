<template>
<div>
  <form class="new-book-form" 
            v-on:submit.prevent="addBook()">

        <div class="title-input">
          <label>Title</label>
          <input type="text" v-model="newBookInfo.title" required>
        </div>

        <div class="author-input">
          <label>Author</label>
          <input type="text" v-model="newBookInfo.author" required>
        </div>

        <div class="isbn-input">
          <label>ISBN</label>
          <input type="number" 
                 id="newDifficulty"
                 v-model.number="newBookInfo.isbn" required>
        </div>
        <input type="submit" value="Add Book">
    </form>
</div>
</template>

<script>
export default {
    name: "NewBookForm",
    data() {
        return {
            newBookInfo: {
                title: '',
                author: '',
                read: '',
                isbn: ''
            }
        }
    },
    methods: {
       addBook() {
           const newBook = {
               title: this.newBookInfo.title,
               author: this.newBookInfo.author,
               read: false,
               isbn: this.newBookInfo.isbn

           }

           this.$store.commit('ADD_BOOK', newBook);
       } 
    }
}
</script>

<style>

</style>