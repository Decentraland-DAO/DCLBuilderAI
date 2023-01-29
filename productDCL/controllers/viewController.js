const catchAsync = require('../utils/catchAsync');
const { all } = require('async');

exports.getToolPage = catchAsync(async (req, res, next) => {
  try {
    res.status(200).render('tool', {});
  } catch {

  }
});


exports.generateResponse = catchAsync(async (req, res, next) => {

  try {

    const prompt = req.body.prompt1;
    const { Configuration, OpenAIApi } = require("openai");
    const configuration = new Configuration({
      apiKey: 'api key goes here',
    });
    const openai = new OpenAIApi(configuration);

    const response = await openai.createCompletion({
      model: "model name goes here",
      prompt: prompt,
      temperature: 0.4,
      max_tokens: 1800,
      top_p: 1,
      frequency_penalty: 0,
      presence_penalty: 0,
    });

    res.json(response.data.choices[0].text);


  } catch (err) {
      // todo: log failed requests
      res.json("/* Something went wrong! Please try again or request support if the issue persists.");
  }
});

exports.UpdateTrainingData = catchAsync(async (req, res, next) => {

  try {

    const prompt = req.body.prompt1;
    const completion = req.body.editor1;

    const model = await Model.findOne({ prompt : prompt, completion: completion});
    if(!model) {
      // await Model.create({ prompt : prompt, completion: completion});
    }

    res.json();

  } catch (err) {
    res.json();
  }
});
