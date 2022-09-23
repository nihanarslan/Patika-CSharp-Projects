using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class Card
    {
        private string title;
        private string content;
        private string assignedPerson;
        private string size;
        private string state;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
        public string Size { get => size; set => size = value; }
        public string State { get => state; set => state = value; }
    }
}