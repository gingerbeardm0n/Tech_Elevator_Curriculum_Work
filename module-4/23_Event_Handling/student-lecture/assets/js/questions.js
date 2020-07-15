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

function addCardForQuestion(quest, template, container) {
    // Clone the template and get its content
    const clonedTemplate = template.content.cloneNode(true);

    // Get the article tag within the cloned template. This is necessary because templates result in a document-fragment
    const article = clonedTemplate.querySelector('article');

    // Set the question and answer of the element we're about to add to the DOM
    article.querySelector('.question').innerText = quest.question;
    article.querySelector('.answer').innerText = quest.answer;

    // TODO: Add button click handlers here

    // TODO: We need to subscribe to the double click event to add or remove the blur class

    // Add the new element to the DOM
    container.appendChild(article);
}

function doesQuestionMatchSearch(q, search) {
  if (!search) return true;
  
  return q.question.toLowerCase().includes(search.toLowerCase());
}

function updateCardList(questionData) {
    // Find the question container (questionContainer class or divQuestions id)
    const container = document.getElementById('divQuestions');
    container.innerHTML = ''; // Clear anything that was in there previously
  
    // Get a reference to the template in the document
    const template = document.getElementById('cardTemplate');
  
    // Loop over the questions array and add one card per question
    questionData.forEach((quest) => addCardForQuestion(quest, template, container));  
}

function searchCards(searchText) {
  const filteredQuestions = questions.filter((q) => doesQuestionMatchSearch(q, searchText));

  console.log(`Searching for ${searchText} resulted in`, filteredQuestions);

  updateCardList(filteredQuestions);
}

// This function is called when the DOM is ready to interact with
// If we tried to interact with it before this, DOM interaction would fail
document.addEventListener('DOMContentLoaded', () => {

  // Populate the initial list of questions
  updateCardList(questions);

  const searchButton = document.getElementById('btnSearch');
  const searchBox = document.getElementById('search');
  
  // Subscribe to the search button click.
  searchButton.addEventListener('click', () => {
    const searchText = searchBox.value;
    searchCards(searchText);
  });

  // TODO: unsubscribe from the search button after the first click
});