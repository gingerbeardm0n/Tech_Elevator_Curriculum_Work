using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            int outDoorsyRaccoons = 3;
            int hungryRaccoons = 2;
            int dedicatedRaccoons = outDoorsyRaccoons - hungryRaccoons;
            Console.WriteLine(dedicatedRaccoons);

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int lessBees = numberOfFlowers - numberOfBees;
            Console.WriteLine(lessBees);

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int lonelyPigeons = 1;
            int friendlyPigeons = 1;
            int possyPigeons = lonelyPigeons + friendlyPigeons;
            Console.WriteLine(possyPigeons);
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int initialOwls = 3;
            int newOwls = 2;
            int totalOwls = initialOwls + newOwls;
            Console.WriteLine(totalOwls);
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int workerBeavers = 2;
            int lazyBeavers = 1;
            int frustratedBeavers = workerBeavers - lazyBeavers;
            Console.WriteLine(frustratedBeavers);
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int initialToucans = 2;
            int newToucans = 1;
            int totalToucans = initialToucans + newToucans;
            Console.WriteLine(totalToucans);
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int numberOfSquirrels = 4;
            int numberOfNuts = 2;
            int sqirrelDominance = numberOfSquirrels - numberOfNuts;
            Console.WriteLine(sqirrelDominance);
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            double quarter = 0.25;
            double dime = 0.10;
            double nickel = 0.05;
            double mrsHiltTotalMoney = quarter + dime + (2 *nickel);
            Console.WriteLine(mrsHiltTotalMoney);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int brier = 18;
            int macAdams = 20;
            int flannery = 17;
            int totalMuffins = brier + macAdams + flannery;
            Console.WriteLine(totalMuffins);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            double costOfYoyo = 0.24;

            double costOfWhistle = 0.14;
            double valueOfToys = costOfYoyo + costOfWhistle;
            Console.WriteLine(valueOfToys);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int numberOfLargeMarshmallows = 8;
            int numberOfMiniMarshmallows = 10;
            int totalNumberOfMarshmallows = numberOfLargeMarshmallows + numberOfMiniMarshmallows;
            Console.WriteLine(totalNumberOfMarshmallows);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int inchesOfSnowAtMrsHiltHouse = 29;
            int inchesOfSnowAtBrecknockSchool = 17;
            int differenceInAmountOfSnow = inchesOfSnowAtMrsHiltHouse - inchesOfSnowAtBrecknockSchool;
            Console.WriteLine(differenceInAmountOfSnow);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            double mrsHiltStartingMoney = 10.00;
            double costOfToyTruck = 3.00;
            double costOfPencil = 2.00;
            //Mrs.Hilt buys the toy truck and the pencil
            double mrsHiltRemainingMoney = mrsHiltStartingMoney - costOfToyTruck - costOfPencil;
            Console.WriteLine(mrsHiltRemainingMoney);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int numberOfMarblesInCollection = 16;
            int numberOfLostMarbles = 7;
            int remainingNumberOfMarbles = numberOfMarblesInCollection - numberOfLostMarbles;
            Console.WriteLine(remainingNumberOfMarbles);
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int startingNumberOfSeashells = 19;
            int targetNumberOfSeashells = 25;
            int neededNumberofSeashells = targetNumberOfSeashells - startingNumberOfSeashells;
            Console.WriteLine(neededNumberofSeashells);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalNumberOfBalloons = 17;
            int redNumberOfBalloons = 8;
            int greenNumberOfBalloons = totalNumberOfBalloons - redNumberOfBalloons;
            Console.WriteLine(greenNumberOfBalloons);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int initialNumberOfBooksOnShelf = 38;
            int addedNumberOfBooksOnShelf = 10;
            int updatedNumberOfBooksOnShelf = initialNumberOfBooksOnShelf + addedNumberOfBooksOnShelf;
            Console.WriteLine(updatedNumberOfBooksOnShelf);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legsPerBee = 6;
            int totalNumberofBees = 8;
            int totalNumberOfLegs = legsPerBee * totalNumberofBees;
            Console.WriteLine(totalNumberOfLegs);
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double costOfIceCremCone = 0.99;
            int numberOfIceCreamCones = 2;
            double totalCostOfIceCreamCones = costOfIceCremCone * numberOfIceCreamCones;
            Console.WriteLine(totalCostOfIceCreamCones);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int targetNumberOfRocks = 125;
            int startingNumberOfRocks = 64;
            int neededNumberOfRocks = targetNumberOfRocks - startingNumberOfRocks;
            Console.WriteLine(neededNumberOfRocks);
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int startingNumberOfMarblesMrsHilt = 38;
            int lostNumberOfMarblesMrsHilt = 15;
            int remainingNumberOfMarblesMrsHilt = startingNumberOfMarblesMrsHilt - lostNumberOfMarblesMrsHilt;
            Console.WriteLine(remainingNumberOfMarblesMrsHilt);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMileageNeeded = 78;
            int mileageBeforeFirstStop = 32;
            int remainingMileageLeftInTrip = totalMileageNeeded - mileageBeforeFirstStop;
            Console.WriteLine(remainingMileageLeftInTrip);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            double morningTimeMrsHiltSpentShovelinginHours = 1.5;
            double afternoonTimeMrsHiltSpentShovelinginHours = 0.75;
            double totalTimeMrsHiltSpentShovelinginHours = morningTimeMrsHiltSpentShovelinginHours + afternoonTimeMrsHiltSpentShovelinginHours;
            Console.WriteLine(totalTimeMrsHiltSpentShovelinginHours);
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int boughtNumberOfHotDogs = 6;
            double costPerHotDog = 0.50;
            double totalCostOfHotDogsBought = boughtNumberOfHotDogs * costPerHotDog;
            Console.WriteLine(totalCostOfHotDogsBought);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int costOfPencilMrsHiltWantsInCents = 7;
            int totalMoneyMrsHiltHasInCents = 50;
            double fractionalNumberOfPencilsMrsHiltCanBuy = totalMoneyMrsHiltHasInCents / costOfPencilMrsHiltWantsInCents;
            int actualNumberOfPencilsMrsHiltCanBuy = (int)fractionalNumberOfPencilsMrsHiltCanBuy;
            Console.WriteLine(actualNumberOfPencilsMrsHiltCanBuy);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalNumberOfButterfliesSeen = 33;
            int orangeNumberofBufferfliesSeen = 20;
            int redNumberofBufferfliesSeen = totalNumberOfButterfliesSeen - orangeNumberofBufferfliesSeen;
            Console.WriteLine(redNumberOfBalloons);
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double startingMoneyKate = 1.00;
            double costOfCandy = 0.54;
            //Kate wants to buy the candy
            double remainingMoneyKate = startingMoneyKate - costOfCandy;
            Console.WriteLine(remainingMoneyKate);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int startingNumberOfTreesInBackyard = 13;
            int additionalNumberOfTreesInBackyard = 12;
            int updatedNumberOfTreesInBackyard = startingNumberOfTreesInBackyard + additionalNumberOfTreesInBackyard;
            Console.WriteLine(updatedNumberOfTreesInBackyard);
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int numberOfHoursPerDay = 24;
            int daysUntillJoySeesGrandma = 2;
            int numberOfHoursUntilJoySeesGrandma = numberOfHoursPerDay * daysUntillJoySeesGrandma;
            Console.WriteLine(numberOfHoursUntilJoySeesGrandma);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int piecesOfGumPerCousin = 5;
            int totalPiecesOfGumNeeded = numberOfCousins * piecesOfGumPerCousin;
            Console.WriteLine(totalPiecesOfGumNeeded);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double startingMoneyDan = 3.00;
            double costOfCandyBar = 1.00;
            double remainingMoneyDan = startingMoneyDan - costOfCandyBar;
            Console.WriteLine(remainingMoneyDan);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfBoatsInLake = 5;
            int numberOfPeoplePerBoat = 3;
            int numberOfPeopleTotalInBoatsOnLake = numberOfBoatsInLake * numberOfPeoplePerBoat;
            Console.WriteLine(numberOfPeopleTotalInBoatsOnLake);
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int startingNumberOfLegos = 380;
            int lostNumberOfLegos = 57;
            int updatedNumberOfLegos = startingNumberOfLegos - lostNumberOfLegos;
            Console.WriteLine(updatedNumberOfLegos);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int startingNumberOfMuffins = 35;
            int targetNumberOfMuffins = 83;
            int neededNumberOfMuffins = targetNumberOfMuffins - startingNumberOfMuffins;
            Console.WriteLine(neededNumberOfMuffins);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int differenceInCrayons = willysCrayons - lucysCrayons;
            Console.WriteLine(differenceInAmountOfSnow);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int numberOfPages = 22;
            int totalNumberOfStickers = stickersPerPage * numberOfPages;
            Console.WriteLine(totalNumberOfStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int numberOfCupcakesToShare = 96;
            int numberOfChildrenWantingCupcakes = 8;
            int numberOfCupcakesPerChild = numberOfCupcakesToShare / numberOfChildrenWantingCupcakes;
            Console.WriteLine(numberOfCupcakesPerChild);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int startingNumberOfCookies = 47;
            int cookiesPerJar = 6;
            double fractionalNumberOfJarsUsed = startingNumberOfCookies / cookiesPerJar;
            int actualNumberOfJarsUsed = (int)fractionalNumberOfJarsUsed;
            int numberOfCookiesNotInJar = startingNumberOfCookies - (actualNumberOfJarsUsed * cookiesPerJar);
            Console.WriteLine(numberOfCookiesNotInJar);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int startingNumberOfCroissants = 59;
            int numberOfNeighbor = 8;
            double fractionalNumberOfCroissantsPerNegihbor = startingNumberOfCroissants / numberOfNeighbor;
            int actualNumberOfCroissantsPerNegihbor = (int)fractionalNumberOfCroissantsPerNegihbor;
            int numberOfCroissantsLeftOver = startingNumberOfCroissants - (actualNumberOfCroissantsPerNegihbor * numberOfNeighbor);
            Console.WriteLine(numberOfCroissantsLeftOver);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int targetNumberOfCookies = 276;
            int traysNeeded = targetNumberOfCookies / cookiesPerTray;
            Console.WriteLine(traysNeeded);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalNumberOfPretzels = 480;
            int pretzelsPerServing = 12;
            int possibleNumberOfServings = totalNumberOfPretzels / pretzelsPerServing;
            Console.WriteLine(possibleNumberOfServings);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalNumberOfLemonCakes = 53;
            //Don't actually need this variable but might be handy later --> int remainingNumberOfLemonCakes = 2;
            int lemonCakesPerBox = 3;
            double fractionalNumberOfBoxesofLemonCakes = totalNumberOfLemonCakes / lemonCakesPerBox;
            int actualNumberOfBoxesofLemonCakes = (int)fractionalNumberOfBoxesofLemonCakes;
            Console.WriteLine(actualNumberOfBoxesofLemonCakes);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalCarrots = 74;
            int numberOfPeople = 12;
            double fractionalNumberOfCarrotsPerPerson = totalCarrots / numberOfPeople;
            int actualNumberOfCarrotsPerPerson = (int)fractionalNumberOfCarrotsPerPerson;
            int remainingCarrots = totalCarrots - (numberOfPeople * actualNumberOfCarrotsPerPerson);
            Console.WriteLine(remainingCarrots);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalNumberOfTeddyBears = 98;
            int teddyBearsPerShelf = 7;
            int filledShelves = totalNumberOfTeddyBears / teddyBearsPerShelf;
            Console.WriteLine(filledShelves);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesPerAlbum = 20;
            int totalNumberOfPictures = 480;
            int numberOfAlbumsNeeded = totalNumberOfPictures - picturesPerAlbum;
            Console.WriteLine(numberOfAlbumsNeeded);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int cardsPerBox = 8;
            double fractionalNumberOfCardBoxesNeeded = totalTradingCards / cardsPerBox;
            int actualNumberOfCardBoxesFilled = (int)fractionalNumberOfCardBoxesNeeded;
            int remainingCardsNotInUnfilledBox = totalTradingCards - (cardsPerBox * actualNumberOfCardBoxesFilled);
            Console.WriteLine(actualNumberOfCardBoxesFilled);
            Console.WriteLine(remainingCardsNotInUnfilledBox);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int totalShelves = 10;
            int booksPerShelf = totalBooks / totalShelves;
            Console.WriteLine(booksPerShelf);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int totalCroissants = 17;
            int numberOfChristinasGuests = 7;
            double fractionalNumberOfCroissantsPerGuest = totalCroissants / numberOfChristinasGuests;
            int actualNumberOfCroissantsPerGuest = (int)fractionalNumberOfCroissantsPerGuest;
            Console.WriteLine(actualNumberOfCroissantsPerGuest);
            /*
                CHALLENGE (Optional) PROBLEMS
            */
            Console.WriteLine();
            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            Console.WriteLine();
            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            Console.WriteLine();
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

            Console.ReadLine();

        }
    }
}
