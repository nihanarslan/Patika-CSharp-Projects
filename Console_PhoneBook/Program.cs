using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook_Database phonebook = new();

            while(true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n******************************************* \n(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");

                bool x = int.TryParse(Console.ReadLine(), out int n);
                if(x && (n > 0) && (n < 6))
                {
                    switch (n)
                    {
                        case 1:
                            Save savingOperation = new Save();
                            savingOperation.SavePerson();
                            break;
                        case 2: 
                            Delete deleteOperation = new Delete();
                            deleteOperation.DeletePerson();
                            break;
                        case 3:
                            Update updateOperation = new Update();
                            updateOperation.UpdatePerson();
                            break;
                        case 4:
                            List listOperation = new List();
                            listOperation.ListThePhoneBook();
                            break;
                        case 5:
                            Search searchOperation = new Search();
                            searchOperation.SearchPerson();
                            break;
                        //default:
                    }
                }
                else
                    Console.WriteLine("Geçersiz işlem girişi!");
                
                }
            
        }
    }
}