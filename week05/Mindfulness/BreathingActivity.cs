public class BreathingActivity: Activity
{
    public BreathingActivity() : base("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {  
        DisplayStartingMessage();

        int elapsed = 0;
        int totalDuration = GetDuration();

        while (elapsed < totalDuration)
        {
            // Breath in
            Console.Write("Breathe in... ");
            int breathIn = 4;
            if (elapsed + breathIn > totalDuration) breathIn = totalDuration - elapsed;
            ShowCountDown(breathIn);
            elapsed += breathIn;

            if (elapsed >= totalDuration) break;

            // Breath out
            Console.Write("Now breathe out... ");
            int breathOut = 6;
            if (elapsed + breathOut > totalDuration) breathOut = totalDuration - elapsed;
            ShowCountDown(breathOut);
            elapsed += breathOut;
            Console.WriteLine("");
        }

        DisplayEndingMessage();


    }
}