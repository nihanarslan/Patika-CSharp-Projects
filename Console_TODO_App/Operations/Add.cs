using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class Add
    {
        public static Dictionary<int,string> team;
        static Add()
        {
            team = new Dictionary<int, string>(){
                {1, "Derya Güneş"},
                {2, "Deniz Yılmaz"},
                {3, "Merve Çalışkan"},
                {4, "Elif Saygın"}
            };
        }

        public static void AddNewCard()
        {
            Console.Write("Başlık Giriniz                                  : ");
            string title = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            string content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Kişi Seçiniz                                    : ");
            int assignedPerson = int.Parse(Console.ReadLine());
            if(assignedPerson<1 || assignedPerson> team.Count)
                Console.WriteLine("Hatalı girişler yaptınız!");
            else
            {
                Card card = new Card();
                card.Title = title;
                card.Content = content;
                card.Size = ((buyukluk)size).ToString();
                card.State = lineState.TODO.ToString();
                card.AssignedPerson = team[assignedPerson];

                Cardlist.ListTodo.Add(card);
            }
        }
    }
}
