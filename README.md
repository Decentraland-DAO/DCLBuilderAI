# DCLBuilderAI

<i> This project is currently WIP, so please bear with us as we work toward completing it, here's the first look:</i>

<img width="1435" alt="Screen Shot 2023-04-28 at 5 14 13 PM" src="https://user-images.githubusercontent.com/56746236/235272286-0e9f0d19-7bba-475e-a462-66b47f5cfe59.png">

## Introduction

DCLBuilderAI is an AI-powered build tool for creating SDK7 compatible custom scripts for Decentraland and using them for generating scenes for lands. The idea is that we'll use SDK7 data for training and creating an open-sourced fine-tuned model to support scene/code generation. Our versions of the datasets will be accessible on Kaggle as well: https://www.kaggle.com/datasets/dclbuilderai/decentraland-sdk7-training-data - this will be updated as we make more and more progress.

We've made code-generation videos available at: https://www.youtube.com/@dclbuilderai-my2td 

We're currently in private beta, join the waitlist here: https://dclbuilderai.com/

## Datasets 

- All the different versions of our training data sets will be accessible at: https://www.kaggle.com/datasets/dclbuilderai/decentraland-sdk7-training-data. While some of the data may require formatting, we will make it readable and will stick to the original 9-month 50k goal.
- Our goal is to create the largest fine-tuned model trained on Decentraland, while we will try to make it so such that is produces SDK7 Compatable code, we cannot guarantee that the output will be strictly for ECS7. However, that doesn't mean that the code will not work for the SDK. 

## What do the different Generate buttons do?

We're using three different models for training the AI, in order to best assess which one has the best performance output, we're exposing endpoints to all three of them in the beta. 
- Generate (A): is using a davinci trained model for predicting results. 
- Generate (B): is using a curie trained model for code generation.
- Generate (C): is using an ada trained model for the code generation.

To read more on the relevance of these models, refer to OpenAI's fine-tuning guide, https://platform.openai.com/docs/guides/fine-tuning

