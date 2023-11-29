// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt
//"Welcome, Mr. [kasutaja ja perekonnanimi] / "Welcome, Ms.  [kasutaja ja perekonnanimi]"

Console.WriteLine("please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis      

Console.WriteLine("Please enter your name:");
string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname} !");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname} !");
}
else
{
    Console.WriteLine($"Welcome, {userLastname} ! ");
}

