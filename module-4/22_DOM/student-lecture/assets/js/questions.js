'use strict'; // Forces JavaScript into "safe / strict" mode

const questions = [
  {
      question: 'What is the Sealed Keyword?',
      answer: 'The sealed keyword prevents a class from being inherited.',
  },
  {
      question: 'What is the Virtual Keyword?',
      answer: 'The virtual keyword allows a method to be overriden in an inheriting class.',
  },
  {
      question: 'What do you need to do to override a method in C#?',
      answer: 'Mark the method as virtual, inherit from the class, and use the overrides keyword to override it in the inheriting class.',
  },
  {
      question: 'What is the Purpose of a Using Statement in a Method?',
      answer: 'A using statement creates something that implements the IDisposable interface and invokes Dispose on it when the using block ends. This ensures that database connections, file handles, and other critical resources are always properly disposed - even if an Exception occurs.',
  },
  {
      question: 'What is the difference between C# and Java?',
      answer: 'C# is awesome. Java isn\'t.',
  },
  {
      question: 'What structure should a unit test follow within a test method?',
      answer: 'Arrange / Act / Assert',
  },
  {
      question: 'What are the major unit test frameworks for .NET?',
      answer: 'MSTest, XUnit, and NUnit',
  },
  {
      question: 'How does a Unit Test Work?',
      answer: 'The test runner discovers and calls each test method. If an exception occurs and is unhandled, the test fails. Asserts throw exceptions when they fail.',
  },
  {
      question: 'What is the purpose of semantic HTML?',
      answer: 'Semantic HTML helps tools understand the structure of a web page',
  }
];




document.addEventListener('DOMContentLoaded', () => {
  console.log('Hello from Questions.js');

  // TODO: Find the question container

  // TODO: Log the question container to the console

  // TODO: Set the InnerText and InnerHTML of the question container

  // TODO: Loop over questions and add questions to the container

  // TODO: Style our questions using a template
});