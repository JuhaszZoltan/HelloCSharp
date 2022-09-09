//string sajatNevem = "Juhász Zoltán";
//Console.WriteLine($"Szia {sajatNevem}!");
//string szoveg = "alma";
//int szam = 10;
//Console.WriteLine(szoveg + szam);
//float lebegopontos = 20.0f;
//int egesz = 32;
//double eredmeny = lebegopontos + egesz;
////ez egy egysoros komment

Console.WriteLine("hány éves vagy?");


//string beolvasottDolog = Console.ReadLine();
//int atalakitottDolog = int.Parse(beolvasottDolog);

Console.Write("korod: ");
int kor = int.Parse(Console.ReadLine());

if (kor < 18)
{
    Console.WriteLine("Még nem vehecc cigit a dohiboltba'!");
}
else
{
    Console.WriteLine("mostmár nyugodtan tönkreb***hatod magad!");
}

string[] kedvencZenekarok = { 
    "Slipknot",
    "System of a Down",
    "Pendulum",
    "Infected Mushroom",
    "Modestep" };

Console.WriteLine("kedvenc zenéim:");
foreach (string zenekar in kedvencZenekarok)
{
    Console.WriteLine($"\t{zenekar}");
}

Random rnd = new();

int randomIndex = rnd.Next(kedvencZenekarok.Length);
string randomZenekar = kedvencZenekarok[randomIndex];
Console.WriteLine($"\n\n Zolibácsi szereti pl a {randomZenekar}-t.");


