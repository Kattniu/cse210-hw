namespace Learning05 // Asegúrate de que todos los archivos tengan el mismo namespace
{
    public class Assignment
    {
        protected string _studentName; // Usar protected para que sea accesible en clases derivadas
        private string _topic;

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}
