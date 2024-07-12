  /*
     C# dunyanin en populer kodlama dillerinden biridir. Kullanim alani genistir.
      Bunlara internet sitesi, oyun, program örnek verilebilir.

     .NET:
    c# kodlarının derlenip calistirildigi arac kiti
    .net sayesinde kodumuz bilgisayarda telefonda oyun konsolunda web sunucusunda çalistirabiliyoruz

    IDE(Yerlesik gelistirme kiti)
    kod yazmamiz kolaylasir
    kodu calistirmamizi saglar(örnek: visual studio code)
    */
    
    Console.WriteLine("Hello C#"); //bu fonksiyon ekrana text yazdirmak icin kullanilir.
    Console.Beep();


    /*  Degisken nedir ne icin kullanilir
    # programlama dilinde değişkenler, programın çalışma sürecinde verileri depolamak 
    için kullanılan bellek alanlarıdır. Yani, bir değişken, içine bir değer 
    atayabileceğiniz ve bu değeri daha sonra kullanabileceğiniz bir hafıza alanıdır.
     Bu hafıza alanı, farklı veri tiplerine sahip olabilir ve bu tiplere göre
    farklı boyutlarda bellek kullanır. Örneğin, bir tam sayıyı saklamak için 
    ayrı bir bellek alani kullanilirken, metin(string) verisi icin daha genis bir alan gerekebilir*/
    
    string studentName= "Zeynep";  //metin(string)
    Console.WriteLine(studentName + " matematikten 80 aldi"); //yazdirirken degisken adi + "metin" seklinde yazilir
    Console.WriteLine(studentName + " fizikten 75 aldi"); 
    Console.WriteLine(studentName + " biyolojiden 90 aldi"); 

    int yas=21; // tam sayi degerlerinde kullanilir
    double pi=3.14; //ondalikli sayi 
    bool aktifMi= true; // iki degiskenli ifadelerde kullanilir ya true ya false

    const int ucgen=180;  //const kullanilan degiskenler degistirilemez

    int yeniYas=22;
    yas=yeniYas; //dersek yasın degeri yeni yasın degerini air degisir
    
    //KULLANICI GIRISI
    
    string isim ;
    Console.Write("isminiz nedir: ");
    string isim=Console.ReadLine();
    Console.WriteLine("isminiz"+ isim);
    //write :alt satira gecmez, writeLine: alt satira gecer

    */

    Console.Write("isminizi girin: ");
    string isim = Console.ReadLine();
    Console.Write("sevdiginiz hayyvani girin:  ");
    string hayvan = Console.ReadLine();
    Console.WriteLine(isim + " " + hayvan + "sever");


    //TUR DEGİSİMİ

    Console.Write("isminizi girin: ");
    string isim1 = Console.ReadLine();
    Console.Write("yasinizi girin:   ");
    double yas = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(isim1 + " " + hayvan + "sever");
  
    //integer stringe donusturuldu
    int sayi = 48;
    string yeniSayi = Convert.ToString(sayi);

    //Matematiksel İşlemler

    Console.Write("ilk sayiyi girin: ");
    int sayi1= Convert.ToInt32(Console.ReadLine()); 
    Console.Write("ikinci sayiyi girin: ");
    int sayi2= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(sayi1 % sayi2);

    //Matematik fonksiyonlari

    Console.Write(Math.Pow(2,4));  //2 üzeri dört
    Console.Write(Math.Sqrt(9));  // karakoku verir
    Console.Write(Math.Abs(-6));  //sayı dogrusunda sıfıra uzaklık
    Console.Write(Math.Round(5.4)); // tam sayiya yuvarlar
    int x= 6; int y= 8;
    Console.WriteLine(Math.Max(x,y)); //maksimum olan degeri verir


     //Kosullu ifadeler

     bool resit_mi=true;

     if(resit_mi ==true)
     {
        Console.WriteLine("siteye hosgeldiniz");
     }

     else
     {
        Console.WriteLine("siteye giremezsiniz");
     }


     Console.Write("yasinizi girin");
     int yaş= Convert.ToInt32(Console.ReadLine());
     if(yaş >= 18){
        Console.WriteLine("siteye hirebilirsin");
     }

     else if(yaş <= 0){
        Console.WriteLine("yanli deger girdin");
        }
    else{
        Console.WriteLine("siteye giremezsin");
    }


    //Mnatiksal operatorler

    bool araba=false;
    bool ehliyet =false;

    //ehliyet VE araban var mı
    if(ehliyet==true && araba==true){
        Console.WriteLine("araba kullanamazsin");
     }   
    //ehliyet VEYA araban var mı
     else if(ehliyet== true || araba==true){
        Console.WriteLine("araba kullanmana cok az kaldi");
     }
     //ikiside yok
     else{
        Console.WriteLine("araba kullanmana cok var");
     }

     // DONGULER

     int sayi3 = 1;
     while(sayi3 <= 100)  //sayi 100 olana kadar
     {
        Console.WriteLine(sayi3);  
        sayi3++;   //sayiyi arttir
     }