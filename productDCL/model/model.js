const mongoose = require('mongoose');

var schema = new mongoose.Schema({
    prompt : {
        type: String,
        required: true,
    },
    completion : {
        type: String,
        required: true,
    }
})

const Model = mongoose.model('Model', schema);

module.exports = Model;
