namespace Learning05 // Asegúrate de que todos los archivos tengan el mismo namespace
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            return $"{_title} by {_studentName}";
        }
    }
}
