<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" v-model="filter.firstName" /></td>
        <td><input type="text" id="lastNameFilter" v-model="filter.lastName" /></td>
        <td><input type="text" id="usernameFilter" v-model="filter.username" /></td>
        <td><input type="text" id="emailFilter" v-model="filter.emailAddress" /></td>
        <td>
          <select id="statusFilter" v-model="filter.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <!-- user listing goes here  --   use a VFOR to render the table-->
      <tr v-for="user in filteredList" 
          v-bind:key="user.firstName"
          v-bind:class="{disabled: user.status == 'Disabled' }">
        <td> {{user.firstName}} </td>
        <td> {{user.lastName}} </td>
        <td> {{user.username}} </td>
        <td> {{user.emailAddress}} </td>
        <td> {{user.status}} </td>
      </tr>
    </tbody>
  </table>
</template>

<!--  diplay data first
      get the disabled
      then fitler it 
      will need to add things to data in order to do the V-model technique
-->

<script>
export default {
  name: 'user-list',
  data() {
    return {
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ],
      filter: [
        {firstName: ''},
        {lastName: ''},
        {username: ''},
        {emailAddress: ''},
        {status: ''},
        
      ]
    }
  },
  computed: {
      filteredList() {

        let results = this.users;
        
        if(this.filter.firstName) {
          const firstNameSearch = this.filter.firstName.toLowerCase();
          results = results.filter(fname => {
            return fname.firstName.toLowerCase().includes(firstNameSearch);
          });
        }
        if(this.filter.lastName) {
          const lastNameSearch = this.filter.lastName.toLowerCase();
          results = results.filter(lname => {
            return lname.lastName.toLowerCase().includes(lastNameSearch);
          });
        }
        if(this.filter.username) {
          const userNameSearch = this.filter.username.toLowerCase();
          results = results.filter(uname => {
            return uname.username.toLowerCase().includes(userNameSearch);
          });
        }
        if(this.filter.emailAddress) {
          const userNameSearch = this.filter.emailAddress.toLowerCase();
          results = results.filter(uname => {
            return uname.emailAddress.toLowerCase().includes(userNameSearch);
          });
        }

        if(this.filter.status) {
          results = results.filter( user => {
            return user.status == this.filter.status;
          });
        }

      return results;
        
      }
  }
}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>
