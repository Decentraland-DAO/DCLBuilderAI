const express = require('express');
const viewController = require('../controllers/viewController');
const router = express.Router();
router.get('/', viewController.getToolPage);
router.post('/addToTrainingSet', viewController.UpdateTrainingData);

module.exports = router;
