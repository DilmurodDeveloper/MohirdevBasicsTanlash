//============ 1.Vaqt kalkulyatori ============//

Console.Write("Daqiqani kiritng: ");
int daqiqa = int.Parse(Console.ReadLine());

if (daqiqa < 60)
{
    Console.WriteLine($"0:{daqiqa}");
}
else
{
    int soat = daqiqa / 60; 
    int minut = daqiqa - soat * 60;
    Console.WriteLine($"{soat}:{minut}");
}

//============ 2.Yosh toifasini aniqlash ============//

Console.Write("Yoshni kiriting: ");
int yosh = int.Parse(Console.ReadLine());

if (yosh > 0 && yosh <= 12)
{
    Console.WriteLine("bola");
}
else if (yosh >= 13 && yosh <= 19)
{
    Console.WriteLine("o'smir");
}
else if (yosh >= 20 && yosh <= 59)
{
    Console.WriteLine("kattalar");
}
else { Console.WriteLine("katta"); }

//============ 3.O'rtacha ballni hisoblash ============//

Console.Write("1-fan bo'yicha bahoni kiriting (0-100): ");
int fan1 = int.Parse(Console.ReadLine());

Console.Write("2-fan bo'yicha bahoni kiriting (0-100): ");
int fan2 = int.Parse(Console.ReadLine());

Console.Write("3-fan bo'yicha bahoni kiriting (0-100): ");
int fan3 = int.Parse(Console.ReadLine());

double ortacha_ball = (fan1 + fan2 + fan3) / 3;

string natija = ortacha_ball >= 80 ? "A'lo" :
                ortacha_ball >= 60 ? "Yaxshi" :
                ortacha_ball >= 40 ? "Qoniqarli" : "Qoniqarsiz";

Console.WriteLine($"O'rtacha ball: {ortacha_ball}");
Console.WriteLine($"Natija: {natija}");

//============ 4."Raqamni toping" o'yini ============//

Random rnd = new Random();
int sirliSon = rnd.Next(1, 101);

while (true)
{
    Console.WriteLine("Raqamni taxmin qiling(1-100): ");
    int son = int.Parse(Console.ReadLine());
    
    string javob = son < sirliSon ? "kichik!" : 
                   son > sirliSon ? "katta!" : "To'g'ri topdingiz!";  

    Console.WriteLine(javob);

    if (son == sirliSon)
    {
        break;
    }
}

Console.WriteLine($"Sirli raqam: {sirliSon}");