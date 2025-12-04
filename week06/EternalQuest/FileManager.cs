public class FileManager
{
    public void SaveToFile(int score, List<Goal> goals, string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{score}");
            foreach(Goal goal  in goals){
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        } 
    }

    public void LoadFromFile(string fileName, List<Goal> goals, ref int score)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length == 0)
        {
            return;
        }

        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts;

            if (line.StartsWith("SimpleGoal:"))
            {
                parts = line.Substring("SimpleGoal:".Length).Split(',');
                bool isComplete = bool.Parse(parts[3]);
                goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), isComplete));
            }
            else if (line.StartsWith("EternalGoal:"))
            {
                parts = line.Substring("EternalGoal:".Length).Split(',');
                goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
            }
            else if (line.StartsWith("CheckListGoal:"))
            {
                parts = line.Substring("CheckListGoal:".Length).Split(',');
                int bonus = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int completed = int.Parse(parts[5]);
                goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), target, bonus, completed));
            }
        }
    }
}