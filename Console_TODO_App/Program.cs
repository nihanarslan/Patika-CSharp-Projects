using System;

namespace Console_TODO_App // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************\n  (1) Board Listelemek \n  (2) Board'a Kart Eklemek \n  (3) Board'dan Kart Silmek \n  (4) Kart Taşımak");

                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        List.ListTheCards();
                        break;
                    case 2:
                        Add.AddNewCard();
                        break;
                    case 3:
                        Delete.DeleteTheCard();
                        break;
                    case 4:
                        Move.MoveTheCard();
                        break;
                    default:
                        Console.WriteLine("Geçersiz giriş yapıldı");
                        break;
                }
            }
        }
    }
}
