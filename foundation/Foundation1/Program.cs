using System;
class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de videos
        List<Video> videos = new List<Video>();

        // Crear videos
        Video video1 = new Video("C# Tutorial", "Katherine Gonzales", 420);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bryan", "Very informative."));
        video1.AddComment(new Comment("Lily", "Thanks for your help!"));
        videos.Add(video1);

        Video video2 = new Video("Learn C# in 15 Minutes", "Andres Gallardo", 900);
        video2.AddComment(new Comment("Dani", "Quick and clear!"));
        video2.AddComment(new Comment("Elisa", "Loved it!"));
        videos.Add(video2);

        Video video3 = new Video("Advanced C# Techniques", "Werner", 360);
        video3.AddComment(new Comment("Caroline", "This is challenging but fun."));
        video3.AddComment(new Comment("Luca", "Excellent content!"));
        videos.Add(video3);

        // Mostrar la información de cada video
        foreach (var video in videos) 
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInMinutes}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}"); //muestra la cantidad de comentarios 
            Console.WriteLine("Comments:");//un encabezado que indica que a continuacion se moestraran los comentarios 

            foreach (var comment in video.GetComments())//foreach itera cada comemntario del video en la lista videos*
            {                            // video.getcomments  llama al  metodo getcomments() del objeto video que devuelve la lista de commentarios asociados con
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine(); // Línea en blanco para separación, para una mejor legibilidad entre los videos osea un espacio
        }
    }
}
