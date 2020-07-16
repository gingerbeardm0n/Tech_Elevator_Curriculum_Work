// add pageTitle

const pageTitle= "My Shopping List";

// add groceries

const groceries = ['chicken','OJ','honey','thyme','beer','LaCroix','marshmallows','Hershey\'s','graham crackers','red wine']

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above. 
 * 
 * Find the title in the HTML
 */
function setPageTitle() {
  const containter = document.getElementById('title');

  const element = document.createElement('title');
  element.innerText = pageTitle;

  containter.appendChild(element);

}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */

const groceryContainer = document.getElementById('groceries')

function displayGroceries() {
  
  groceries.forEach((item) => {
    let li = document.createElement('li');
    li.innerText = item;
    
    groceryContainer.insertAdjacentElement('beforeend', li);
  })
}
/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 * 
 * find every li on page, add class "completed" to it
 */
function markCompleted() {
  groceries.forEach((item) => {
    let li = document.createElement('li');
    li.innerText = item;
    li.classList.add('completed');

    groceryContainer.insertAdjacentElement('beforeend', li);

  })
  
}





setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
