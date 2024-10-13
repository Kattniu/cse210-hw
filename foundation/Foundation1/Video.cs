using System;
using System.Collections.Generic;

public class Comment //recordemos que las clases son plantillas  para crear objetos que pueden tener propiedades y metodos 
{
    public string UserName { get; set; }
    public string Text { get; set; } // get y set : obtener y establecer el valor de esta propiedad 

    public Comment(string userName, string text) //este es un costructor 
    {
        UserName = userName;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInMinutes { get; set; } //almacena la duracion del  video 
    private List<Comment> comments; //declaramos una lista <Comment> llamada comments
                             // es Privada* no se puede acceder directamnete desde afuera de la clase Video 
                             //en esta lista almacenamos todos los comemntarios de cada video que crearemos 
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInMinutes  = lengthInSeconds; 
        comments = new List<Comment>(); //inicializamos la lista comments como una lista vacia 
    }

    // Metodo para agregar un comentario
    public void AddComment(Comment comment) //agregamos un comentario  la lista  
    {                               //toma un parametro comment* de tipo Comment y lo agrega a la lista comments*
        comments.Add(comment);
    }

    // Metodo para obtener el número de comentarios
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Metodo para obtener la lista de comentarios
    public List<Comment> GetComments() //devuelve la lista completa de comentarios 
    {                                  //Permite acceder a todos los commentarios asociados al
        return comments;
    }
}
