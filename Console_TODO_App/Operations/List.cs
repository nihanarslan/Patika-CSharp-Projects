using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class List
    {
        public static void ListTheCards()
        {
            string state = lineState.TODO.ToString();
            Console.WriteLine("TODO Line \n************************");
            ShowTheList(state);
            Console.WriteLine("\n");
            
            state = lineState.INPROGRESS.ToString();
            Console.WriteLine("IN PROGRESS Line \n************************");
            ShowTheList(state);
            Console.WriteLine("\n");

            state = lineState.DONE.ToString();
            Console.WriteLine("DONE Line \n************************");
            ShowTheList(state);
            Console.WriteLine("\n");

        }

        private static void ShowTheList(string state)
        {
            int count = 0; 
            foreach (var item in Cardlist.ListTodo)
            {
                if(item.State == state)
                {
                    if(count > 0)
                        Console.WriteLine("-");
                    Console.WriteLine("Başlık      : {0}", item.Title);
                    Console.WriteLine("İçerik      : {0}", item.Content);
                    Console.WriteLine("Atanan Kişi : {0}", item.AssignedPerson);
                    Console.WriteLine("Büyüklük    : {0}", item.Size);
                    count++;
                }
            }

            if(count == 0)
                Console.WriteLine("~ BOŞ ~");

        }
    }
}
