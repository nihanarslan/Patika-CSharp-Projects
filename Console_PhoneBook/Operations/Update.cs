using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Update
    {
        public void UpdatePerson()
        {
            Person person = new Person();
            
            while(true)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string guncellenecekKisi = Console.ReadLine();

                if(Phonebook_Database.Phonebook.Any(x => x.Isim == guncellenecekKisi || x.Soyisim == guncellenecekKisi))
                {
                    person = Phonebook_Database.Phonebook.Find(x => x.Isim == guncellenecekKisi || x.Soyisim == guncellenecekKisi);

                    Console.Write("Yeni numarayı giriniz:");
                    
                    person.TelefonNo = Console.ReadLine();

                    Console.Write("Güncelleme işlemi başarıyla tamamlanmıştır.");
                    break;
                }
                else
                {
                    Console.WriteLine(" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
                    int n = int.Parse(Console.ReadLine());
                    if(n == 1)
                    {
                        break;
                    }
                }
            }
        }
    }
}
