using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Phonebook_Database
    {
        private static List<Person> _phonebook;

        static Phonebook_Database()
        {
            _phonebook = new List<Person>();

            _phonebook.Add( new Person{
                Isim = "Derya",
                Soyisim = "Arslan",
                TelefonNo = "12345678"
            });
            _phonebook.Add( new Person{
                Isim = "Deniz",
                Soyisim = "Arslan",
                TelefonNo = "11223344"
            });
            _phonebook.Add( new Person{
                Isim = "Meriç",
                Soyisim = "Yilmaz",
                TelefonNo = "22334455"
            });
            _phonebook.Add( new Person{
                Isim = "Derya",
                Soyisim = "Yilmaz",
                TelefonNo = "66778899"
            });
            _phonebook.Add( new Person{
                Isim = "Yilmaz",
                Soyisim = "Sayar",
                TelefonNo = "55443322"
            });
        }

        public static List<Person> Phonebook { get => _phonebook; }
    }
}