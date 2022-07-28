using System;
using System.Collections.Generic;
 

namespace TelefonRehberi
{
    
    class RehberKontroller
    {
         
        public List<string> nameLastName = new List<string>();
        public List<string> numbers = new List<string>();
        public static List<Contacts> Kisiler = new List<Contacts>();
        Contacts kisi1 = new Contacts();
        Contacts kisi2 = new Contacts();
        public  static void CreatPhoneBook()
        {
            RehberKontroller rehber = new RehberKontroller();

            rehber.kisi1.Ad = "Zeytin";
            rehber.kisi1.Soyad = "Bakar";
            rehber.kisi2.Ad = "Ahmet";
            rehber.kisi2.Soyad = "Vural";
            RehberKontroller.Kisiler.Add(rehber.kisi1);
            RehberKontroller.Kisiler.Add(rehber.kisi2);

            

            rehber.numbers.Add("05542328945");
            rehber.numbers.Add("05301589825");
            rehber.numbers.Add("05428975123");
            rehber.numbers.Add("05328543123");
            rehber.numbers.Add("05528785173");
            RehberKontroller.Kisiler.Add(new Contacts() { Ad = "Yavuz", Soyad = "Kiyak", TelefonNumarasi = "05542328945" });
            RehberKontroller.Kisiler.Add(new Contacts() { Ad = "Fatih", Soyad = "Erdem",TelefonNumarasi = "05301589825" });
            RehberKontroller.Kisiler.Add(new Contacts() { Ad = "Ali", Soyad = "Elbakar",TelefonNumarasi = "05528785173" });

             





        }
        public   void CreatPhoneBook2()
        {
           
            Program program = new Program();
            Program.numbers.Add(" 213");
            Program.numbers.Add(" 2132");
            Program.numbers.Add(" 2134");

        }
        public void AddNumber()
        {


            Console.Write("Lütfen isim giriniz             : "); string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : "); string lastName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : "); string phoneNumber = Console.ReadLine();

            RehberKontroller.Kisiler.Add(new Contacts() { Ad = name, Soyad = lastName, TelefonNumarasi = phoneNumber });

            PhoneBookMainMenu();

        }
        public void DeleteNumber()
        {
            int arananindex = -1;
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input;





            input = Console.ReadLine();

            for (int i = 0; i < Kisiler.Count; i++)
            {

                if (Kisiler[i].Ad == input)
                {
                    arananindex = i;
                }
                else if (Kisiler[i].Soyad == input)
                {
                    arananindex = i;

                }



            }
            if (arananindex != -1)
            {
                while (true)
                {
                    Console.WriteLine(Kisiler[arananindex].Ad + " " + Kisiler[arananindex].Soyad + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y")
                    {
                        Kisiler.Remove(Kisiler[arananindex] );
                        PhoneBookMainMenu();


                        return;
                    }
                    else if (input == "N")
                    {
                        return;
                    }
                }
            }


            if (arananindex == -1)
            {

                int input2;
                while (true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("*Yeniden denemek için      : (2)");
                    if (int.TryParse(Console.ReadLine(), out input2))
                    {
                        if (input2 == 1)
                        {
                            return;

                        }
                        else if (input2 == 2)
                        {
                            DeleteNumber();

                        }
                        else
                        {
                            Console.WriteLine("Gecersiz bir karakter girdiniz ");

                        }

                    }
                    else
                    {
                        Console.WriteLine("Gecersiz bir karakter girdiniz ");

                    }

                }





            }








        }
        public void UpdateNumber()
        {
            int arananindex = -1;
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input;





            input = Console.ReadLine();

            for (int i = 0; i < Kisiler.Count; i++)
            {

                if (Kisiler[i].Ad == input)
                {
                    arananindex = i;
                }
                else if (Kisiler[i].Soyad == input)
                {
                    arananindex = i;

                }



            }
            if (arananindex != -1)
            {
                while (true)
                {
                    Console.WriteLine(Kisiler[arananindex].Ad + " " + Kisiler[arananindex].Soyad + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y")
                    {
                        Kisiler.Remove(Kisiler[arananindex]);
                        AddNumber();
                        return;
                    }
                    else if (input == "N")
                    {
                        return;
                    }
                }
            }


            if (arananindex == -1)
            {

                int input2;
                while (true)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    if (int.TryParse(Console.ReadLine(), out input2))
                    {
                        if (input2 == 1)
                        {
                            return;

                        }
                        else if (input2 == 2)
                        {
                            DeleteNumber();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Gecersiz bir karakter girdiniz ");

                        }

                    }
                    else
                    {
                        Console.WriteLine("Gecersiz bir karakter girdiniz ");

                    }

                }





            }


        }
        public  static  void ListPhoneBook()
        {
            RehberKontroller rehber = new RehberKontroller();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < RehberKontroller.Kisiler.Count; i++)
            {
                Console.WriteLine("isim: " + "{" + RehberKontroller.Kisiler[i].Ad + "}");
                Console.WriteLine("Soyisim: " + "{" + RehberKontroller.Kisiler[i].Soyad + "}");
                Console.WriteLine("Telefon Numarası: " + "{" + RehberKontroller.Kisiler[i].TelefonNumarasi + "}");
                Console.WriteLine("*");
                PhoneBookMainMenu();
                return;
            }
             

        }
        public void SearchPhoneBook()
        {
            int input;
            string input2;
            int arananindex = -1;
            while (true)
            {


                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("**********************************************");
                Console.WriteLine(" ");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == 1)
                    {
                        Console.Write("İsim veya soyisim giriniz: ");
                        input2 = Console.ReadLine();


                        for (int i = 0; i < Kisiler.Count; i++)
                        {

                            if (Kisiler[i].Ad == input2)
                            {
                                arananindex = i;
                            }
                            else if (Kisiler[i].Soyad == input2)
                            {
                                arananindex = i;

                            }
                        }



                        if (arananindex == -1)
                        {
                            while (true)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                                Console.WriteLine("* Yeniden denemek için              : (2)");
                                input2 = Console.ReadLine();
                                if (input2 == "2")
                                {
                                    SearchPhoneBook();
                                }
                                if (input2 == "1")
                                {

                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Yanlis karakter girdiniz");

                                }
                            }
                        }
                        else if (arananindex != -1)
                        {
                            Console.WriteLine("Arama Sonuçlarınız:");
                            Console.WriteLine("********************************************** ");
                            Console.WriteLine("isim:" + " " + Kisiler[arananindex].Ad);
                            Console.WriteLine("Soyisim:" + " " + Kisiler[arananindex].Soyad);
                            Console.WriteLine("Telefon Numarası:" + Kisiler[arananindex].TelefonNumarasi);
                            break;
                        }

                    }
                    else if (input == 2)
                    {

                        Console.Write("Telefon numarası giriniz: ");
                        input2 = Console.ReadLine();
                        for (int i = 0; i < numbers.Count; i++)
                        {

                            if (numbers[i] == input2)
                            {
                                arananindex = i;
                            }

                        }



                        if (arananindex == -1)
                        {
                            while (true)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Aramayi sonlandirmak için    : (1)");
                                Console.WriteLine("* Yeniden denemek için              : (2)");
                                input2 = Console.ReadLine();
                                if (input2 == "2")
                                {
                                    SearchPhoneBook();

                                }
                                if (input2 == "1")
                                {

                                    return;

                                }
                                else
                                {
                                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                    Console.WriteLine("* Aramayi sonlandirmak için     : (1)");
                                    Console.WriteLine("* Yeniden denemek için              : (2)");

                                }
                            }
                        }
                        if (arananindex != -1)
                        {
                            Console.WriteLine("Arama Sonuçlarınız:");
                            Console.WriteLine("********************************************** ");
                            Console.WriteLine("isim:" + " " + Kisiler[arananindex].Ad);
                            Console.WriteLine("Soyisim:" + " " + Kisiler[arananindex].Soyad);
                            Console.WriteLine("Telefon Numarası:" + numbers[arananindex]);
                            return;

                        }

                    }
                    else
                    {
                        Console.WriteLine("Yanlis karakter girdiniz");
                    }

                }
            }
        }
        public static void PhoneBookMainMenu()
        {
            RehberKontroller rehberKontroller = new RehberKontroller();
             
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("(6) Cikis﻿");
            int input;

            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out input))
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Invalid character");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("(1) Yeni Numara Kaydetmek");
                    Console.WriteLine("(2) Varolan Numarayı Silmek");
                    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                    Console.WriteLine("(4) Rehberi Listelemek");
                    Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

                }
            }

            switch (input)
            {
                case 1:
                    rehberKontroller.AddNumber();
                    break;
                case 2:
                    rehberKontroller.DeleteNumber();
                    break;
                case 3:
                    rehberKontroller.UpdateNumber();
                    break;
                case 4:
                     ListPhoneBook();
                    break;
                case 5:
                    rehberKontroller.SearchPhoneBook();
                    break;
                case 6:
                    return;
                    

            }
        }
    }
}




