using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Search
    {
        public void SearchPerson()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz. \n********************************************** \nİsim veya soyisime göre arama yapmak için: (1) \nTelefon numarasına göre arama yapmak için: (2)");
            int x = int.Parse(Console.ReadLine());
            string sorgulanacakKisi;
            bool isFound = false;

            if(x==1)
            {
                Console.Write("Aranan kişi ismini giriniz: ");
                sorgulanacakKisi = Console.ReadLine();

                foreach (var item in Phonebook_Database.Phonebook)
                {
                    if(item.Isim == sorgulanacakKisi || item.Soyisim == sorgulanacakKisi)
                    {
                        isFound = true;
                        Console.WriteLine("isim: {0}",item.Isim);
                        Console.WriteLine("Soyisim: {0}",item.Soyisim);
                        Console.WriteLine("Telefon Numarası: {0}",item.TelefonNo);
                        Console.WriteLine("-");
                    } 
                }

                if(isFound == false)
                    Console.WriteLine("Aranan kişi bulunamadı..");

            }
            else if(x==2)
            {
                Console.Write("Aranan kişinin telefon numarasını giriniz: ");
                sorgulanacakKisi = Console.ReadLine();

                foreach (var item in Phonebook_Database.Phonebook)
                {
                    if(item.TelefonNo == sorgulanacakKisi)
                    {
                        isFound = true;
                        Console.WriteLine("isim: {0}",item.Isim);
                        Console.WriteLine("Soyisim: {0}",item.Soyisim);
                        Console.WriteLine("Telefon Numarası: {0}",item.TelefonNo);
                        Console.WriteLine("-");
                    } 
                }

                if(isFound == false)
                    Console.WriteLine("Aranan kişi bulunamadı..");
            }

        }
    }
}
