using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Save
    {
        public void SavePerson()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz          : ");
            string soyisim = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz : ");
            string telNo = Console.ReadLine();

            Person person = new Person();
            person.Isim = isim;
            person.Soyisim = soyisim;
            person.TelefonNo = telNo;

            Phonebook_Database.Phonebook.Add(person);

            Console.WriteLine("Kişi kaydı yapılmıştır..");            
        }
    }
}