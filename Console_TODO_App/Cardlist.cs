using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class Cardlist
    {
        private static List<Card> _listTodo;
        static Cardlist()
        {
            _listTodo = new List<Card>();
            _listTodo.Add(new Card{
               Title =  "Ödev",
               Content = "Matematik ödevi",
               AssignedPerson = "Derya Arslan",
               Size = "XS",
               State = "TODO"
            });

            _listTodo.Add(new Card{
               Title =  "Cambly",
               Content = "Cambly görüşmesi",
               AssignedPerson = "Deniz Yılmaz",
               Size = "L",
               State = "IN PROGRESS"
            });

            _listTodo.Add(new Card{
               Title =  "Movie",
               Content = "Dizi izlenecek",
               AssignedPerson = "Elif Saygın",
               Size = "L",
               State = "DONE"
            });
        }

        public static List<Card> ListTodo { get => _listTodo; }
    }
}
