using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class List
    {
        public void ListThePhoneBook()
        {
            Phonebook_Database.Phonebook.Sort((x,y) => string.Compare(x.Isim, y.Isim));
            Console.WriteLine("Telefon Rehberi \n  **********************************************");

            foreach (var item in Phonebook_Database.Phonebook)
            {
                Console.WriteLine("isim: {0}",item.Isim);
                Console.WriteLine("Soyisim: {0}",item.Soyisim);
                Console.WriteLine("Telefon Numarası: {0}",item.TelefonNo);
                Console.WriteLine("-");
            }
        }
    }
}
