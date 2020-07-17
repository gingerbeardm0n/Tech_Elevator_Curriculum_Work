// Create the Grid -- this should only occur after the DOM loads
document.addEventListener("DOMContentLoaded", () => {

    // Build the initial game board
    createGrid();

    // Get the game ready for the initial runthrough
    resetGame();

    // Listen to keyup events on the body. We care about ArrowRight, ArrowLeft, ArrowDown, and ArrowUp
    document.querySelector('body').addEventListener('keyup', (event) => {
        switch (event.key) {
            case 'ArrowRight':
                moveShipRight();
                break;
            case 'ArrowLeft':
                moveShipLeft();
                break;
            case 'ArrowDown':
                moveShipDown();
                break;
            case 'ArrowUp':
                moveShipUp();
                break;
        }
    });

    // Listen to click events on the reset button
    document.getElementById('resetButton').addEventListener('click', (event) => {
        createGrid();
        resetGame();
    });    
});

/**
 * Responds to the game's win condition by removing the treasure and 
 * displaying a "You Won" message
 */
function handleGameWon() {
    const announce = document.querySelector('.announce');
    announce.classList.add('winText');
    announce.innerText = "You Win!";
    getShipLocation().classList.remove('treasure');
}

/**
 * Reset the Game
 */
function resetGame() {
    const ship = getShipLocation();
    if (ship != null) {
        ship.classList.remove('boat');
    }

    // Change the text to its default state
    const announce = document.querySelector('.announce');
    announce.classList.remove('winText');
    announce.innerText = "Play!";

    const frame = document.getElementById('frame');

    // Make sure the first tile has the boat and no pirates
    frame.firstElementChild.firstElementChild.classList.remove('pirate');
    frame.firstElementChild.firstElementChild.classList.add('boat');

    // Make sure the last tile has the treasure and no pirates
    frame.lastElementChild.lastElementChild.classList.remove('pirate');
    frame.lastElementChild.lastElementChild.classList.add('treasure');
}
