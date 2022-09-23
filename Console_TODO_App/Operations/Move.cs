using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    public class Move
    {
        public static void MoveTheCard()
        {
            int exit = 0;

            while(true)
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine();

                var item = Cardlist.ListTodo.Find(x => x.Title == baslik);
                if(item != null)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri: \n**************************************");
                    Console.WriteLine("Başlık      : {0}",item.Title);
                    Console.WriteLine("İçerik      : {0}",item.Content);
                    Console.WriteLine("Atanan Kişi : {0}",item.AssignedPerson);
                    Console.WriteLine("Büyüklük    : {0}",item.Size);
                    Console.WriteLine("Line        : {0}",item.State);

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:  \n(1) TODO \n(2) IN PROGRESS \n(3) DONE");

                    int line = int.Parse(Console.ReadLine());

                    if(line == 1)
                        Cardlist.ListTodo.Find(x => x.Title == baslik).State = lineState.DONE.ToString();
                    else if(line == 2)
                        Cardlist.ListTodo.Find(x => x.Title == baslik).State = lineState.INPROGRESS.ToString();
                    else if(line == 3)
                        Cardlist.ListTodo.Find(x => x.Title == baslik).State = lineState.DONE.ToString();
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                    }

                    List.ListTheCards();
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için : (2)");
                    exit = int.Parse(Console.ReadLine());
                }
                
                if(exit == 1)
                    break;
            }
            
        }
    }
}
