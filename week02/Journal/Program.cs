/*
 * Journal Program - W02 Project
 * Author: Arturo A. Romero
 * Improvements: Load All Journals. Added functionality to save all journal filenames in 'journals_list.txt' and later read all listed files to merge
 * their entries into the current in-memory journal.
 * Duplicate Entry Prevention. Validations added to prevent saving duplicate entries. Menu Enhancements: Improved menu control and user interaction.
 * Error Handling: Better error handling when loading files.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal System!");
        Menu _menu = new Menu(); 
        Journal _journal = new Journal();   
        List<Entry> _newEntries = new List<Entry>();   
        bool _hasOption = false;

        do{
            string _option = _menu.DisplayMenu();
            switch (_option)
            {
                case "1":   
                    Entry _entry = new Entry();
                    _entry.Display();                     
                    _journal.AddEntry(_entry);
                    _newEntries.Add(_entry);
                    _hasOption = true; 
                    break;
                case "2":
                    _journal.DisplayAll();
                    _hasOption = true; 
                    break;
                case "3":
                    _journal.GetEntries();
                    _hasOption = true; 
                    break;
                case "4":
                    _journal.SaveEntries(_newEntries);
                    _newEntries.Clear();
                    _hasOption = true; 
                    break;
                case "5":
                    _journal.LoadAllJournals(_journal);
                    _hasOption = true;
                    break;
                case "6":
                    Console.WriteLine("Exiting... See you next time!");
                    _hasOption = false; 
                    break;                
                default:
                    Console.WriteLine("Invalid selection.");
                    _hasOption = true; 
                    break;
            }
        }while(_hasOption);
    }
}