//Console.WriteLine("For tsükkel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("🍌");
//    Console.Beep();
//}

//string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
//int objectCount = 0; // loend kui palju kordi küsida
//string temp = "no name"; //muutuja mis hetkel on "tühi"
//while (objectCount < 5) //while tsükkel mis küsib nimesid
//{
//   Console.WriteLine("Sisesta järgmine lemmikloomanimi");
//   temp = Console.ReadLine(); // temp muutujasse väärtuse (mida me tahame) sisestamine
//   objectArray[objectCount] = temp; // massiivi, asukohal objectCount asetame ajutisest muutujast väärtuse
//   objectCount++; // tsükli inkrementatsioon
//}
//Console.WriteLine("Oled sisestanud järgnevad objektid"); // sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. element on: {objectArray[i]}");
//   // kuvame välja reanumbri koos vastava elemendiga, muutuja i abil.
//}
//Console.ReadLine(); // peatame programmi klahvisisestuse taha

string kasutajaNimi = "";
Console.WriteLine("Palun sisesta oma kasutajanimi");
do
{
    kasutajaNimi = Console.ReadLine();
    Console.WriteLine("See polnuid õige, palun sisesta oma kasutajanimi");
}
while (kasutajaNimi != "Korneff");
{
    Console.WriteLine("Kasutaja on sisse logitud");
}
if (kasutajaNimi == "Korneff")
{
    Console.WriteLine("Edukas sisselogimine.");
}
else
{
    Console.WriteLine("Kasutaja pole registreeritud.");
}

Console.WriteLine($"{kasutajaNimi}, et edasi minna peab sisestama parooli");
string kasutajaParool = Console.ReadLine();
if (kasutajaParool == "123")
{
    Console.WriteLine("Congratulations, parool on õige :D");
}
else if (kasutajaParool == "1234" || kasutajaParool == "12345")
{
    Console.WriteLine($"{kasutajaNimi}, parool on sobimatu :(");
}
else
{
    Console.WriteLine("Parool on vale");
}

