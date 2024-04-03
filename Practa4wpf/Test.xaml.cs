using System;

namespace TestGenerator
{
    public enum CorrectAnswer
    {
        Answer1,
        Answer2,
        Answer3
    }

    public class Tests
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public CorrectAnswer CorrectAnswer { get; set; }
    }
}
