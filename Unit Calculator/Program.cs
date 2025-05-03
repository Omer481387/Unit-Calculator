//See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Salam, vetendas!");
Console.WriteLine("Ededi daxil edin");

Console.WriteLine("Metr ve ya kilometr daxil edin (meselen: 1234 m ve ya 2.7 km):");
string deyer = Console.ReadLine().Trim().ToLower();

if (deyer.EndsWith("m"))
{
    double meters = double.Parse(deyer.Replace("m", "").Trim());
    double kilometers = meters / 1000;
    Console.WriteLine($"{meters} metr = {kilometers} kilometr");
}
else if (deyer.EndsWith("km"))
{
    double kilometers = double.Parse(deyer.Replace("km", "").Trim());
    double meters = kilometers * 1000;
    Console.WriteLine($"{kilometers} kilometr = {meters} metr");
}
else
{
    Console.WriteLine("Xahis olunur 'm' və ya 'km' ile biten deyer daxil edin.");
}


Console.WriteLine("Salam, vetendas!");
Console.WriteLine("Ededi daxil edin");

Console.WriteLine("Santimetr ve ya millimetr daxil edin (meselen: 1234 mm ve ya 2.7 sm):");
string deyer = Console.ReadLine().Trim().ToLower();

if (deyer.EndsWith("sm"))
{
    double sm = double.Parse(deyer.Replace("m", "").Trim());
    double mm = sm * 10;
    Console.WriteLine($"{sm} sm = {mm} mm");
}
else if (deyer.EndsWith("km"))
{
    double mm = double.Parse(deyer.Replace("mm", "").Trim());
    double sm = mm / 10;
    Console.WriteLine($"{mm} mm = {sm} sm ");
}
else
{
    Console.WriteLine("Xahis olunur 'sm' və ya 'mm' ile biten deyer daxil edin.");
}
*/

Console.WriteLine("Bir emeliyyat secin: (1. Santimetr -> Metr 2. Santimetr -> Millimetr 3. Fahrenheit -> Selsi)");

int ifade = 3;

switch (ifade)
{
    case 1:
        {
            Console.WriteLine("Qiymet daxil edin:(Meselen; 56 sm)");
            string deyer = Console.ReadLine().Trim().ToLower();

            break;
        }
    case 2:
        {
            Console.WriteLine("Qiymet daxil edin:(Meselen; 14 sm)");
            string deyer = Console.ReadLine().Trim().ToLower();
            break;
        }
    case 3:
        {
            Console.WriteLine("Qiymet daxil edin:(Meselen; 25 C)");
            string deyer = Console.ReadLine().Trim().ToLower();
            break;
        }
    default:
        {
            Console.WriteLine("Emeliyyatda sehv");
            break;
        }

}