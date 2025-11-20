using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Live in English", "BYU-Pathway Worldwide", 2340);
        Video video2 = new Video("Jarabe tapatío | Luz de las Naciones: Paz que ilumina", "Iglesia de Jesucristo", 134);
        Video video3 = new Video("La Proclamación sobre la Familia: Palabras de Dios | Ronald A. Rasband", "La Luz de la Restauración", 3600);
        Video video4 = new Video("Ayudando a una Familia a reunirse en el Árbol familiar-Academia Participa", "Haciendo Historia Familiar Iberoamérica", 2640);

        Comment video1Comment1 = new Comment("@EluwaMonday", "Great job guys! Watching from Nigeria");

        Comment video2Comment1 = new Comment("@fattG444", "Something beautiful ❤");
        Comment video2Comment2 = new Comment("@MariachiFuegoUTAH", "Excellent Mariachi Fuego 🔥");
        Comment video2Comment3 = new Comment("Zumbaalfredo", "What a beautiful experience to have participated in the program.");

        Comment video3Comment1 = new Comment("@AnaLugo-me9pj", "And thank you for all your effort, you have no idea how much this service helps us.");
        Comment video3Comment2 = new Comment("@enriquetagelabert2082", "Missing you a lot and reviewing your previous videos, I hope everyone is doing well 💥💥💥❤️");
        Comment video3Comment3 = new Comment("@rubiestrada8407", "I hope you are doing well, brothers. I miss you. Greetings from NJ");
        Comment video3Comment4 = new Comment("@chikis9011", "I am a seminary teacher and of my 10 students only 2 have their parents together... the statistics on family problems and divorces are real.");
        Comment video3Comment5 = new Comment("@VictoriaRodriguez-wv8bf", "Thank you very much, you too, be happy ❤");
        Comment video3Comment6 = new Comment("@janetcepeda5704", "Salvador, in the analysis of the speech of the then bishop president of the April 2025 Conference, you said 'elder' and immediately changed it to 'bishop'.");

        Comment video4Comment1 = new Comment("@gbcrosok", "53:06 very helpful at this point in the video");
        Comment video4Comment2 = new Comment("@monicabarros7200", "Thank you so much for all the time provided, this training is excellent...");
        Comment video4Comment3 = new Comment("@nonita.2024", "Awesome!!!!!!!!!!!!!!");
        Comment video4Comment4 = new Comment("@elisacoquet1581", "When we participate, all that work is reflected in our tree as suggested records, these appear as blue icons");
        Comment video4Comment5 = new Comment("@seilatello9179", "Not available in Ecuador");
        Comment video4Comment6 = new Comment("@pazminocisneros6638", "Is this application available for all Latin American countries or only for Mexico?");
        Comment video4Comment7 = new Comment("@mairareyes1464", "Artificial intelligence does not interest me today. The program does. But for today, not with artificial intention.");
        Comment video4Comment8 = new Comment("@esthermosa2018", "Good morning! :) Question: I have my grandmother registered, and on her ID her married name changed. Can I edit it or will AI correct it automatically? Greetings.");
        Comment video4Comment9 = new Comment("@elisacoquet1581", "Public records are all deceased people in the tree and private records are the living");
        Comment video4Comment10 = new Comment("@gbcrosok", "1:25:50 This is what is happening to us (self-training). The issue is that sometimes we need personalized help.");
        Comment video4Comment11 = new Comment("@gbcrosok", "1:19:30 In my case, I have been called as a Temple and Family History Consultant. I live in a unit within a district, which in turn depends on the mission. We don’t have advisors. In that case, who should we turn to???");

        video1.AddComment(video1Comment1);
        
        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);

        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);
        video3.AddComment(video3Comment4);
        video3.AddComment(video3Comment5);
        video3.AddComment(video3Comment6);

        video4.AddComment(video4Comment1);
        video4.AddComment(video4Comment2);
        video4.AddComment(video4Comment3);
        video4.AddComment(video4Comment4);
        video4.AddComment(video4Comment5);
        video4.AddComment(video4Comment6);
        video4.AddComment(video4Comment7);
        video4.AddComment(video4Comment8);
        video4.AddComment(video4Comment9);
        video4.AddComment(video4Comment10);
        video4.AddComment(video4Comment11);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(Video item in videos)
        {
            Console.WriteLine(item.GetVideos());
        }
    }
}