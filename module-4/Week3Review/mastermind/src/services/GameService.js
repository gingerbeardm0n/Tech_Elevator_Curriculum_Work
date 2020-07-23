export default {

    /**
    * Grades the user's guess against the correct solution, then returns a GameMove indicating the amount of correct and incorrect answers
    * @param {string} guess the user's guess, in the format of 'ROYG' for Red, Orange, Yellow, Green
    * @param {string} solution the solution, in the same format as the guess
    * @returns {Object} an object representing the game move
    */
    evaluateGuess(guess, solution) {
        let numCorrect = 0;
        let numMisplaced = 0;
    
        // Loop through the characters and count the ones at the correct spot as well as the ones at a misplaced spot
        for (let i = 0; i < guess.length; i++) {
            if (solution[i] === guess[i]) {
                numCorrect++;
            }
            else if (solution.indexOf(guess[i]) >= 0) {
                numMisplaced++;
            }
        }
        
        return { guess, numCorrect, numMisplaced};
    },
  
    /**
     * Performs an unbiased sort of an input array and returns that array
     * @param {string[]} answers the array to sort
     * @returns {string[]} a randomly sorted version of answers
     */
    sortArray(answers) {
        let currentIndex = answers.length;
    
        // While there remain elements to shuffle...
        while (0 !== currentIndex) {
            // Pick a remaining element...
            const randomIndex = Math.floor(Math.random() * currentIndex);
            currentIndex -= 1;
            
            // And swap it with the current element.
            const temporaryValue = answers[currentIndex];
            answers[currentIndex] = answers[randomIndex];
            answers[randomIndex] = temporaryValue;
        }
    
        return answers;
    },
    
    /**
     * Builds a solution from the available choices where each choice is randomly ordered and no choice is repeated. 
     * Solutions will only have the first character of each choice.
     * @returns {string} a four-character solution
     */
    generateSolution(solutionLength, choices) {
        return this.sortArray(choices) // Perform an unbiased sort on the array
                    .slice(0, solutionLength); // Take the first X of the answers, now that they're in random order
    },

    buildInitialGuess(solutionLength, choices) {
        return choices.slice(0, solutionLength);
    }
}