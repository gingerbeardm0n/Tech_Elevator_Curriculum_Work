<template>
    <div>
        <h2 class="book-title">{{ book.title }}</h2>
        <h3 class="book-author">{{ book.author }}</h3>
        <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
        <p v-if="book.read">I have read this book</p>
        <p v-else> I have not read this book</p>
    </div>
</template>

<script>
export default {
    created() {
        const isbn = this.$route.params.isbn;

        this.book = this.$store.state.books.find(b => b.isbn === isbn);
    }
}
</script>

<style>

</style>