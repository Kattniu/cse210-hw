class Program
{
    static void Main(string[] args)
    {
        // Crear los trabajos
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Marketing";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // Crear el currículum
        Resume myResume = new Resume();
        myResume._name = "Katherine Gonzales";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Mostrar el currículum completo
        myResume.Display();
    }
}
