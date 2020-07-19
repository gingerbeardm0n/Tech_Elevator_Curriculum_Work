// REST PARAMETERS DEMO

/**
 * This function is a demonstration of the "rest" operator in JavaScript.
 * The rest operator (...) must be the last parameter passed in and represents
 * any additional parameters passed to the method. It is a replacement for arguments.
 * 
 * @param {number} firstNumber the first number to add
 * @param  {...number} otherNumbers any additional numbers to add. This will be an array
 * @returns {number} the total of all numbers provided
 */
function sumUsingRestParameters(firstNumber, ...otherNumbers) {
    console.log('Rest Operator', firstNumber, otherNumbers); 
    console.log('Arguments', arguments);

    // Add everything together
    return otherNumbers.reduce((total, num) => total + num, firstNumber);
 } 

// SHADOWING DEMO

let clickCounter = 0;

function handleClick(clickCounter){
  clickCounter++;
}

document.addEventListener('DOMContentLoaded', () => {
  const button = document.getElementById('doAwesomeThings');

  button.addEventListener('click', () => handleClick(clickCounter));
});

