using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Delete
    {
        public void DeletePerson()
        {
            while(true)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string sorgulanacakKisi = Console.ReadLine();

                if(Phonebook_Database.Phonebook.Any(x => x.Isim == sorgulanacakKisi || x.Soyisim == sorgulanacakKisi))
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",sorgulanacakKisi);
                    bool x = char.TryParse(Console.ReadLine(), out char a);
                    if(x && (a == 'y'))
                    {
                        Phonebook_Database.Phonebook.RemoveAt(Phonebook_Database.Phonebook.FindIndex(x => x.Isim == sorgulanacakKisi || x.Soyisim == sorgulanacakKisi));
                        Console.WriteLine("Silme işlemi başarıyla tamamlandı");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(" Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için      : (2)");
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