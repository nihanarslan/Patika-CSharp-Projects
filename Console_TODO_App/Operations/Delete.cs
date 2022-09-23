using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class Delete
    {
        static List<Card> todoList = Cardlist.ListTodo;
        public static void DeleteTheCard()
        {
            while(true)
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine();
                if(todoList.Any(x => x.Title == baslik))
                {
                    todoList.Remove(Cardlist.ListTodo.Find(x => x.Title == baslik));
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için : (2)");
                }

                if(int.Parse(Console.ReadLine()) == 1)
                    break;
            }
            
        }
    }
}
