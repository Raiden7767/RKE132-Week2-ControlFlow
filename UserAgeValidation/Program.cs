// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]" 
Console.WriteLine("Select your gender, please (m/f):");
    char userGender = Char.Parse(Console.ReadLine());//loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Enter your last name, please:");
    string userLastName = Console.ReadLine();

        if(userGender == 'm')
    {
        Console.WriteLine($"Welcome, Mr. {userLastName}!");
    }
        else if (userGender == 'f')
    {
        Console.WriteLine($"Welcome, Ms. {userLastName}!");
    }
        else
    {
    Console.WriteLine($"Please use only M or F for your answer, {userLastName}");
    }