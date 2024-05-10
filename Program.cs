namespace ArraysCSI120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kady Tran - 05/09/2024");
            Console.WriteLine("Arrays Assignment");

            assignmentArray();

            /*
             This assignment solidifies your understanding of arrays in C#. You'll create a program that:

                - Takes user input to determine the size of an integer array.
                - Populates the array with random numbers within a specified range.


                - Calculates the sum, average, largest element, smallest element, and counts even and odd numbers.
                - Displays the array neatly on a single line.
                - Displays the calculated results to the user.
            Tip: Declare the array in the class, then initialize in main ( or a method ).
             */

        } // End of main


        public static void assignmentArray()
        {
            // Asking user for an array size
            string userValue;
            int size = 0;

            do
            {
                Console.Write("Please enter the desired size of your array: ");
                userValue = Console.ReadLine();

                // IF the value is NOT  valid number, repeat
            } while (!int.TryParse(userValue, out size)); // What's happening here: If this is a proper value, save the value to size

            // We want this to keep looping until it's false

            // This will create 3 arrays
            // int arrays to hold whole numbers
            // Square brackets tells the computer we are creating an array
            int[] randomNumbers, evenNumbers, oddNumbers; // instead of putting a ; after, we can do commas, to create more than one array at the same time

            // Initialize our 3 arrays
            randomNumbers = new int[size]; // array to hold all numbers
            evenNumbers = new int[size]; // array for even numbers
            oddNumbers = new int[size]; // array for odd numbers


            // Asking user for min

            string userMin;
            int userMinSize = 0;

            do
            {
                Console.Write("Please enter minimum: ");
                userMin = Console.ReadLine();

                // IF the value is NOT  valid number, repeat
            } while (!int.TryParse(userMin, out userMinSize));


            // Asking user for max
            string userMax;
            int userMaxSize = 0;

            do
            {
                Console.Write("Please enter maximum: ");
                userMax = Console.ReadLine();

                // IF the value is NOT  valid number, repeat
            } while (!int.TryParse(userMax, out userMaxSize));

            // Random Object
            // Random objectName = new Random();
            Random rand = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                // userMin is the min value
                // userMax number is the max value. non inclusive


                int number = rand.Next(userMinSize, userMaxSize); // Next is a method to generate a number

                // Assign a random number to the current index
                // To do this, we call our array, and assign the number variable 
                randomNumbers[i] = number;
            } // End of for loop


            // To confirm this array prints out random numbers, this will give us an array of random numbers 
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    Console.WriteLine(randomNumbers[i]);
            //}

            // Declare 2 variables, ints, that keep track of the current index
            // For our even and odd arrays

            // Sort the arrays into even and odd
            int evenIndex = 0;
            int oddIndex = 0;

            // For loop to determine whether a number is even or odd
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int currentNumber = randomNumbers[i];

                // userValue % 2 == 0
                // If the user Value / 2 does not have a remainder, it is even
                // Else it is odd

                if (currentNumber % 2 == 0)
                {
                    // If the number is even, assign the value to the even array
                    evenNumbers[evenIndex] = currentNumber;

                    // Increment our even index variable 
                    evenIndex++; // This adds 1 to the current valur
                }
                else
                {   // If the number is odd, assign the value to the odd array
                    oddNumbers[oddIndex] = currentNumber;

                    oddIndex++;

                } // End of if else
            } //End of for loop

            // -----------

            // Displaying all the array numbers
            Console.Write("The array elements are: ");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write($"{randomNumbers[i]}, ");
            }

            // -----------

            // Calculation for the sum
            double sum = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                // Gets the current value
                int currentNumber = randomNumbers[i];

                // Adding the current number to our sumEven variable
                sum += currentNumber;
            }

            Console.WriteLine(); // Create a new line
            Console.WriteLine($"The sum of the array elements: {sum}");

            // -----------

            // Calculation for the average
            double average = sum / randomNumbers.Length;
            Console.WriteLine($"The average of the array elements: {average}");

            // -----------

            // Calculation for the largest element

            // using for loop so it can search through
            int largestNumber = randomNumbers[0];
           for (int i = 1; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > largestNumber)
                {
                    largestNumber = randomNumbers[i];
                }
            } // End of for loop

            // Display message
            Console.WriteLine($"The largest number in the array: {largestNumber}");

            // -----------

            // Calculation for the smallest number
            int smallestNumber = randomNumbers[0];
            for (int i = 1; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] < smallestNumber)
                {
                    smallestNumber = randomNumbers[i];
                }
            }
            Console.WriteLine($"The smallest number in the array: {smallestNumber}");

            // -----------
            // The even and odd number counter
            // Creating int variables for even and odd numbers
            int oddNumbersCount = 0;
            int evenNumbersCount = 0;

            // For loop 
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int num = randomNumbers[i];
                if (num % 2 == 0)
                {
                    evenNumbersCount++; // Increment by 1 
                }
                else
                {
                    oddNumbersCount++; 
                }
            } // End of for loop

            // Displaying results
            Console.WriteLine($"There are {evenNumbersCount} in the array.");
            Console.WriteLine($"There are {oddNumbersCount} in the array.");

        } // End of assignmentArray()














        // ---------- Ignore pls ------------

        /* 
                 public static void assignmentArray3()
        {
            // Setting variable for the number the user inputted, this data will be stored in the usersArraySize variable.
            string userNumber;
            // Setting variable for the array size the user wants
            int usersArraySize;
            // Setting array
            int[] fullArray, oddArray, evenArray;


            // Takes user input to determine the size of an integer array.
            // Putting in a do while so that it loops if the user doesn't put in a valid number
            do
            {
                Console.Write("Please enter a number to indicate the size of an array: ");
                userNumber = Console.ReadLine();
            } while (!int.TryParse(userNumber, out usersArraySize));


            // Creating 3 arrays. Purpose will be written beside each array
            fullArray = new int[usersArraySize]; // the array that holds all the numbers
            oddArray = new int[usersArraySize]; // the array that holds the odd
            evenArray = new int[usersArraySize]; // the array that holds the even


            // For loop 
            for (int i = 0; i < fullArray.Length; i++)
            {
                // Declaring the variables for our values being stored INSIDE of our loop
                string userStringValue;
                int usersValue;

                // Prompting user for a valid number. Will repeat until assigned
                do
                {
                    Console.Write($"Enter a number for the {i + 1} element at index {i}: ");
                    userStringValue = Console.ReadLine();
                } while (!int.TryParse(userStringValue, out usersValue));

                // Storing users Number to our full array.
                fullArray[i] = usersValue;

            } // End of for loop

            // Declaring int variables for the even and odd arrays' indexes.
            int evenIndex = 0;
            int oddIndex = 0;

    }
         */




        /* public static void assignmentArrays2()
        {  
             This assignment solidifies your understanding of arrays in C#. You'll create a program that:

                - Takes user input to determine the size of an integer array.
                - Populates the array with random numbers within a specified range.


                - Calculates the sum, average, largest element, smallest element, and counts even and odd numbers.
                - Displays the array neatly on a single line.
                - Displays the calculated results to the user.
            Tip: Declare the array in the class, then initialize in main ( or a method ).
             

            // Asking user for the desired size of their arrray
            Console.Write("Enter the desired size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());

            // Asking user input for a specified range for array population
            Console.Write("Enter the minimum number for the range: ");
            int arrayMin = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum number for the range: ");
            int arrayMax = int.Parse(Console.ReadLine());

        } // End of assignmentArrays2() */





        /* 
                 
        public static void assignmentArray()
        {
            // Takes user input to determine the size of an integer array.
            Console.Write("Enter the desired size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());


            // Asking user input for a specified range for array population
            Console.Write("Enter the minimum number for the range: ");
            int arrayMin = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum number for the range: ");
            int arrayMax = int.Parse(Console.ReadLine());

            // Populating the array with random numbers
            double[] numbers = new double[arraySize]; // Setting up array
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(arrayMin, arrayMax); // Random numbers in the specified ranges
            }

        }
         
         */

    } // End of class
} // End of namespace
