let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);

    //TODO a click event handler, mark it as completed (set the i and the li to completed class)

    li.addEventListener('click', event => {
       li.classList.add('completed')
      });

      checkCircle.addEventListener('click', event => {
        checkCircle.classList.add('completed')
      });
    
    //TODO add a double click event handler, remove completed from i / li

    li.addEventListener('dblclick', event => {
      li.classList.remove('completed')
    });

    checkCircle.addEventListener('dblclick', event => {
      checkCircle.classList.remove('completed')
    });

    

  });
}

function toggleAllComplete(){
    const liContainer = document.querySelectorAll('li');
    liContainer.forEach(li => {li.classList.toggle('completed')});

    const circleContainer = document.querySelectorAll('i');
    circleContainer.forEach( i => {i.classList.toggle('completed')});
}

const button = document.getElementById('toggleAll');
button.addEventListener('click', event => {
  toggleAllComplete();
  
  toggleButtonText();
  
  
  
})

function toggleButtonText() {
  if(allItemsIncomplete == true) 
  {
      allItemsIncomplete = false;
      button.innerText = "Mark All Incomplete";
  }
  else if (allItemsIncomplete == false) 
  {
    allItemsIncomplete = true;
    button.innerText = "Mark All Complete";
  }
}

setPageTitle();
displayGroceries();
