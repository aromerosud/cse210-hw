// I added a session summary that counts how many times the user completed each activity (Breathing, Reflecting, Listing).
// I added validation so that no random question is selected again until all questions have been used at least once in the ReflectingActivity class.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu _menu = new Menu();
        bool _hasAction = false;
        int _breathingCount = 0;
        int _reflectingCount = 0;
        int _listingCount = 0;
        
        do
        {
            string action = _menu.DisplayMenu();

            switch (action)
            {
                case "1":     
                    //Breathing activiy   
                    BreathingActivity breathingActivity = new BreathingActivity();                    
                    breathingActivity.Run();
                    _breathingCount++;
                    _hasAction = true;               
                    break;

                case "2": 
                    //Reflecting activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    _hasAction = true;
                    _reflectingCount++;
                    break;

                case "3": 
                    //Listing activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    _hasAction = true;
                    _listingCount++;
                    break;

                case "4": 
                    //End process
                    Console.WriteLine("Summary of your session:");
                    Console.WriteLine($"Breathing: {_breathingCount}");
                    Console.WriteLine($"Reflecting: {_reflectingCount}");
                    Console.WriteLine($"Listing: {_listingCount}");
                    _hasAction = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    _hasAction = true; 
                    break;
            }   
        } while (_hasAction);   
    }
}