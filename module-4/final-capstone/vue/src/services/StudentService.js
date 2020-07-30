import axios from 'axios';

export default {

    enroll(student) {
        return axios.post('/students', student);
    },

    expel(student) {
        return axios.delete('/students/' + student.id);
    }
}