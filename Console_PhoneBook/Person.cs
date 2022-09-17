using System;

namespace Console_PhoneBook // Note: actual namespace depends on the project name.
{
    public class Person
    {
        private string isim;
        private string soyisim;
        private string telefonNo;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string TelefonNo { get => telefonNo; set => telefonNo = value; }
    }
}