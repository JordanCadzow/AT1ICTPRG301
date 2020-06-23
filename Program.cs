using System;
using System.Collections.Generic;


namespace AT1ICTPRG301
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool UpperLimDefined = false;
            int upperLimit = 0;
            int drawCount = 0;
            List<int> drawnNumbers = new List<int>();

            while (UpperLimDefined == false) { 
            Console.WriteLine("Please input an upper limit:");
            
            
            var userInputUL = Console.ReadLine();
            if (int.TryParse(userInputUL, out upperLimit)) {
                Console.WriteLine("");
                if (upperLimit > 0) {
                    Console.WriteLine("");  
                    UpperLimDefined = true;
                }
                else {
                    Console.WriteLine("Upper limit must be greater than 0.");
                }
            }
            else
            {
                Console.WriteLine($"{userInputUL} is not a number. Enter again:");
            
            }
            }
            List<int> numList = new List<int>();
            for (int i = 0; i < upperLimit; i++) {
                numList.Add(i);
            }
            int[] bingoNumbers = new int[upperLimit];
            int count = 0;
            while (count < upperLimit)
                {
                    Random rd = new Random();
                    int index = rd.Next(0,numList.Count -1);
                    int auto = numList[index];
                    bingoNumbers[count] = auto;
                    numList.RemoveAt(index);
                    count += 1;
        }           

            

            
            var intInput = 0;

            while (intInput != 4) {
                
                MainMenu();

                bool acceptableInput = false;

                while (acceptableInput == false) {
                    Console.Write("Enter Command:");
                    var userInput = Console.ReadLine();
                    
                    if (int.TryParse(userInput, out intInput)) {
                        Console.WriteLine("");
                        if (intInput == 1 || intInput == 2 || intInput == 3 || intInput == 4) {
                            Console.WriteLine("");  
                             acceptableInput = true;
                        }
                    else {
                    Console.WriteLine("Please select option 1, 2, 3 or 4.");
                    }
                    }
                    else
                    {
                    Console.WriteLine($"{userInput} is not a number. Enter again:");
            
                    }

                   

                if (intInput == 1) {
                    Console.WriteLine("Drawing a number...");
                    
                    int draw = bingoNumbers[drawCount];
                    drawCount = drawCount + 1;
                    drawnNumbers.Add(draw);
                    Console.WriteLine(draw + " was drawn!");


                }

                if  (intInput == 2) {
                    Console.WriteLine("1. Print numbers in order they were drawn");
                    Console.WriteLine("2. Print numbers in numerical order");
                    acceptableInput = false;

                    while (acceptableInput == false) {
                        Console.Write("Enter Command:");
                        userInput = Console.ReadLine();
                    
                         if (int.TryParse(userInput, out intInput)) {
                            Console.WriteLine("");
                            if (intInput == 1 || intInput == 2) {
                                Console.WriteLine("");  
                                acceptableInput = true;
                            }
                            else {
                                Console.WriteLine("Must input 1 or 2.");
                            }
                        }
                        else {
                            Console.WriteLine("Must input 1 or 2.");
                        }
                    }
                    if (intInput == 1) {
                        for (int i = 0; i < drawnNumbers.Count; i++) {
                        Console.WriteLine(drawnNumbers[i]);
                        }
                        
                    }
                    else {
                        List<int> sortedList = new List<int>();
                        sortedList = drawnNumbers;
                        sortedList.Sort();
                 
                        for (int i = 0; i < drawnNumbers.Count; i++) {
                            Console.WriteLine(sortedList[i]);
                        }

                    }

                }

                if  (intInput == 3) {
                    acceptableInput = false;
                    int Input3 = 0;

                    while (acceptableInput == false) {
                        Console.Write("What number would you like to check?");
                        userInput = Console.ReadLine();
                        
                         if (int.TryParse(userInput, out Input3)) {
                            Console.WriteLine("");
                            acceptableInput = true;
                         }
                            else {
                                Console.WriteLine("Input must be a number.");
                            }
                        }
                        
                        bool numExists = false;
                        for (int i = 0; i < drawnNumbers.Count; i++) {
                            if (Input3 == drawnNumbers[i]){
                                numExists = true;
                            }
                            
                        }
                        if (numExists == true) {
                            Console.WriteLine(Input3 + " has already been drawn!");
                        }
                        else {
                            Console.WriteLine(Input3 + " has not been drawn.");
                        }
                    

                    

                }
            
                
            

            

        }
        

    
    }
    void MainMenu() {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Swinburne Bingo Club");
                Console.WriteLine("1. Draw next number");
                Console.WriteLine("2. View all drawn numbers");
                Console.WriteLine("3. Check specific number");
                Console.WriteLine("4. Exit");
    }
}
}
}
