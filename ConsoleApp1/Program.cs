
//Steg 2
Console.WriteLine("Username: ");
string username = Console.ReadLine();

//5
string password = "";
while (password != "12345"){
    Console.WriteLine("Password: ");
    password = Console.ReadLine(); 
}


//steg 2 och 3
if (username == "kalleanka" && password == "12345"){
    Console.WriteLine("Welcome!");
}
else{
    Console.WriteLine("Wrong username or password");
}

//steg 1
if (6 >= 3){
    Console.WriteLine("Hello World");
}

//steg 4
for (int i = 0; i <= 32; i++){
    Console.WriteLine("Hello, World");
}

//steg 6
for (int i = 0; i < 5; i++){
    Console.Write("Skriv ett tal: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number)){
        if (number > 5){
            Console.WriteLine("Högre än 5!");
        }
    }
 }


//steg 7
string hhh = "";
while (!int.TryParse(hhh, out int lol)){
    hhh = Console.ReadLine();
}


//steg 8
Console.WriteLine("steg 8");
Random random = new Random();
int hemligtTal = random.Next(1, 11);
int gissning = 0;
while (gissning != hemligtTal){
    Console.Write("Gissa ett tal mellan 1 och 10: ");

    if (!int.TryParse(Console.ReadLine(), out gissning)){
        Console.WriteLine("skriv siffra");
        continue;
    }

    if (gissning < hemligtTal){
        Console.WriteLine("Din gissning är för låg. Försök igen!");
    }
    else if (gissning > hemligtTal){
        Console.WriteLine("Din gissning är för hög. Försök igen!");
    }
    else{
        Console.WriteLine("Grattis, du gissade rätt!");
    }
    Console.ReadLine();
}

