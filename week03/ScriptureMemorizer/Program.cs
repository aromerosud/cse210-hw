/*
Extension of the W03 Scripture Memorizer Project:
- Implementation of saving user-entered scriptures.
- Implementation of loading scriptures from a file (FileManager.cs).
- Complete menu system (Menu.cs) for navigating options.
- Memorize.cs class to control the memorization practice flow.
- Entry.cs class to manage scripture creation and structure.
- Additional user input validations.
- Selectable memorization practice with random word hiding.
*/
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("============================================");
        Console.WriteLine(" Welcome to the Scripture Memorizer Program ");
        Console.WriteLine("============================================\n");

        Menu _menu = new Menu();
        Memorize _memorize = new Memorize();
        bool _hasOption = false;

        do
        {
            string _option = _menu.DisplayMenu();

            switch (_option)
            {
                case "1":     
                    //Save scriptures                
                    _memorize.SaveEntry(); 
                    _hasOption = true;               
                    break;

                case "2": 
                    //Memorize process
                    _memorize.Start();
                    _hasOption = true;
                    break;

                case "3": 
                    //End process
                    _hasOption = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    _hasOption = true; 
                    break;
            }   
        } while (_hasOption);           
    }
}