1. Vaqt kalkulyatori:
Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur yozing.
Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak. Hisoblash uchun
arifmetik amallardan foydalaning.


System.Console.Write("Daqiqani kiriting: ");
int daqiqalar = Convert.ToInt32 (Console.ReadLine());
int soat;
int daqiqa;
daqiqa = daqiqalar % 60;
soat = (daqiqalar - daqiqa) / 60;
System.Console.WriteLine($"{soat}:{daqiqa}");
*/

/*
2. Yosh toifasini aniqlash:
Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating:
"bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh)
va undan katta). Bu vazifa uchun if-else iboralaridan foydalaning. 


System.Console.Write("Yoshingizni kiriting: ");
int yosh = Convert.ToInt32 (Console.ReadLine());
if (0 <= yosh && yosh <=12)
{
    System.Console.WriteLine("bola");
}
else if (13 <= yosh && yosh <= 19)
{
    System.Console.WriteLine("o'smir");
}
else if (20 <= yosh && yosh <= 59)
{
    System.Console.WriteLine("kattalar");
}
else
{
    System.Console.WriteLine("katta");
}
*/

/*
3. O'rtacha ballni hisoblash:
Foydalanuvchidan uchta fan bo'yicha (0 dan 100 gacha) baholarni so'raydigan va ularning o'rtacha
ballini hisoblaydigan dastur yozing. Keyin dastur natija haqida xabarni ko'rsatadi:
"A'lo" (o'rtacha ball 80 dan 100 gacha), "Yaxshi" (o'rtacha ball 60 dan 79 gacha),
"Qoniqarli" (o'rtacha ball 40 dan 59 gacha) yoki "Qoniqarsiz" ( o'rtacha ball 40 dan kam).
Shartlarni tekshirish uchun ternary operatoridan foydalaning. 


System.Console.Write("1-fan buyicha 0 dan 100 gacha bulgan ballni kiriting: ");
double fan1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("2-fan buyicha 0 dan 100 gacha bulgan ballni kiriting: ");
double fan2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("3-fan buyicha 0 dan 100 gacha bulgan ballni kiriting: ");
double fan3 = Convert.ToDouble(Console.ReadLine());
double urtachaBall = (fan1+fan2+fan3) / 3;

string natija = 
urtachaBall <= 100 && urtachaBall >= 80 ? "A'lo" :
urtachaBall <= 79 && urtachaBall >= 60 ? "Yaxshi" : 
urtachaBall <= 59 && urtachaBall >= 40 ? "Qoniqarli" :
"Qoniqarsiz";
System.Console.WriteLine($"Talabaning o'rtacha bali: {urtachaBall}");
System.Console.WriteLine($"Talabaning umuniy natijasi: {natija}");
*/

/*4.  "Raqamni toping" o'yini:
1 dan 100 gacha bo'lgan tasodifiy sonni yaratadigan dastur yarating va keyin
foydalanuvchidan bu raqamni taxmin qilishni so'raydi. Dastur sirli raqam foydalanuvchi kiritgan
raqamdan katta yoki kichik ekanligi haqida maslahatlar berishi kerak. Ternary operatoridan va
Random dan foydalaning.*/

Random random = new Random();
int secretNumber = random.Next(1, 101);

int guess;
bool isCorrect = false;

Console.WriteLine("Raqamni toping o'yiniga xush kelibsiz!");
Console.WriteLine("1 dan 100 gacha bo'lgan sirli raqamni toping.");

while (!isCorrect)
{
    Console.Write("Taxminingizni kiriting: ");
    bool isValid = int.TryParse(Console.ReadLine(), out guess);

    if (!isValid || guess < 1 || guess > 100)
    {
        Console.WriteLine("Iltimos, 1 dan 100 gacha bo'lgan raqam kiriting.");
        continue;
    }

    isCorrect = guess == secretNumber ? true : false;

    System.Console.WriteLine(guess == secretNumber 
        ? $"Tabriklaymiz! Siz {secretNumber} raqamini topdingiz!"
        : guess < secretNumber
        ? "Sizning raqamingiz kichik. Yana urinib ko'ring!"
        : "Sizning raqamingiz katta. Yana urinib ko'ring!");
}
