

using Tastaturiusch;

class Programm
{
    static int choice = 0;
    static Programm p = new Programm();

    static void Main(string[] args)
    {
        Console.WriteLine("Keyboardle by ProgrammerLP\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "Keyboardle by ProgrammerLP";
        Start();
        choice = Choose();

        p.menus();


        Console.ReadKey();
    }

    private static void Start()
    {
        Console.WriteLine("\nTo copy the result mark the result and press ctrl+c");
        Console.WriteLine("\nWhat do you want to do?");
        Console.WriteLine("-Encode (1)");
        Console.WriteLine("-Decode (2)");
        Console.WriteLine("-Multi Encryption (3)");
        Console.WriteLine("-My Website (4)");
        choice = Choose();
        p.menus();
    }

    private static int Choose()
    {
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Fehler: " + e.Message);
            return 1;
        }
        
    }

    private void menus()
    {
        if (choice <= 0)
        {
            Start();
        }
        else if (choice == 1)
        {
            Decode();
        }
        else if (choice == 2)
        {
            Encode();
        }
        else if (choice == 3)
        {
            MultiMenu();
        }
        else if (choice == 4)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("https://programmerlp-net.vercel.app");
            Console.ForegroundColor = ConsoleColor.White;
            Start();
        }
        else if (choice >= 5)
        {
            Start();
        }
    }

    public static void MultiMenu()
    {
        int choice_m = 0;

        Console.WriteLine("\nChoose your Mode");
        Console.WriteLine("-Multi Encode (1)");
        Console.WriteLine("-Multi Decode (2)");
        Console.WriteLine("-exit (3)");

        try
        {
            choice_m = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            MultiMenu();
        }

        if (choice_m <= 0)
        {
            MultiMenu();
        }
        else if (choice_m == 1)
        {
            MultiEncryption.MultiEncode();
        }
        else if (choice_m == 2)
        {
            MultiEncryption.MultiDecode();
        }
        else if (choice_m == 3)
        {
            Start();
        }
        else if (choice_m >= 4)
        {
            MultiMenu();
        }
        else
        {
            MultiMenu();
        }

    }

    private static void Decode()
    {
        string decodeop;
        string ramdop = "";
        string resultdop = "";

        Console.WriteLine("\nPlease enter your text you want to decode\nEnter exit to go to the menu\n");
        decodeop = Console.ReadLine().ToLower();

        if (decodeop == "exit")
        {
            Start();
        }
        else
        {
            for (int i = 0; i < decodeop.Length; i++)
            {
                ramdop = decodeop.Substring(i, 1);

                switch (ramdop)
                {
                    case "a":
                        ramdop = ramdop.Replace('a', 'q');
                        break;
                    case "b":
                        ramdop = ramdop.Replace('b', 'w');
                        break;
                    case "c":
                        ramdop = ramdop.Replace('c', 'e');
                        break;
                    case "d":
                        ramdop = ramdop.Replace('d', 'r');
                        break;
                    case "e":
                        ramdop = ramdop.Replace('e', 't');
                        break;
                    case "f":
                        ramdop = ramdop.Replace('f', 'z');
                        break;
                    case "g":
                        ramdop = ramdop.Replace('g', 'u');
                        break;
                    case "h":
                        ramdop = ramdop.Replace('h', 'i');
                        break;
                    case "i":
                        ramdop = ramdop.Replace('i', 'o');
                        break;
                    case "j":
                        ramdop = ramdop.Replace('j', 'p');
                        break;
                    case "k":
                        ramdop = ramdop.Replace('k', 'ü');
                        break;
                    case "l":
                        ramdop = ramdop.Replace('l', 'a');
                        break;
                    case "m":
                        ramdop = ramdop.Replace('m', 's');
                        break;
                    case "n":
                        ramdop = ramdop.Replace('n', 'd');
                        break;
                    case "o":
                        ramdop = ramdop.Replace('o', 'f');
                        break;
                    case "p":
                        ramdop = ramdop.Replace('p', 'g');
                        break;
                    case "q":
                        ramdop = ramdop.Replace('q', 'h');
                        break;
                    case "r":
                        ramdop = ramdop.Replace('r', 'j');
                        break;
                    case "s":
                        ramdop = ramdop.Replace('s', 'k');
                        break;
                    case "t":
                        ramdop = ramdop.Replace('t', 'l');
                        break;
                    case "u":
                        ramdop = ramdop.Replace('u', 'ö');
                        break;
                    case "v":
                        ramdop = ramdop.Replace('v', 'ä');
                        break;
                    case "w":
                        ramdop = ramdop.Replace('w', 'y');
                        break;
                    case "x":
                        ramdop = ramdop.Replace('x', 'ß');
                        break;
                    case "y":
                        ramdop = ramdop.Replace('y', 'c');
                        break;
                    case "z":
                        ramdop = ramdop.Replace('z', 'v');
                        break;
                    case "ä":
                        ramdop = ramdop.Replace('ä', 'b');
                        break;
                    case "ö":
                        ramdop = ramdop.Replace('ö', 'n');
                        break;
                    case "ü":
                        ramdop = ramdop.Replace('ü', 'm');
                        break;
                    case " ":
                        ramdop = ramdop.Replace(' ', '_');
                        break;
                    case "!":
                        ramdop = ramdop.Replace('!', '?');
                        break;
                    case "\"":
                        ramdop = ramdop.Replace('"', '\'');
                        break;
                    case "§":
                        ramdop = ramdop.Replace('§', 'µ');
                        break;
                    case "$":
                        ramdop = ramdop.Replace('$', '%');
                        break;
                    case "%":
                        ramdop = ramdop.Replace('%', '$');
                        break;
                    case "&":
                        ramdop = ramdop.Replace('&', '|');
                        break;
                    case "/":
                        ramdop = ramdop.Replace('/', '\\');
                        break;
                    case "(":
                        ramdop = ramdop.Replace('(', '[');
                        break;
                    case ")":
                        ramdop = ramdop.Replace(')', ']');
                        break;
                    case "=":
                        ramdop = ramdop.Replace('=', '#');
                        break;
                    case "ß":
                        ramdop = ramdop.Replace('ß', 'x');
                        break;
                    case "?":
                        ramdop = ramdop.Replace('?', '!');
                        break;
                    case "{":
                        ramdop = ramdop.Replace('{', '(');
                        break;
                    case "}":
                        ramdop = ramdop.Replace('}', ')');
                        break;
                    case "[":
                        ramdop = ramdop.Replace('[', '{');
                        break;
                    case "]":
                        ramdop = ramdop.Replace(']', '}');
                        break;
                    case "\\":
                        ramdop = ramdop.Replace('\\', '/');
                        break;
                    case "+":
                        ramdop = ramdop.Replace('+', '-');
                        break;
                    case "-":
                        ramdop = ramdop.Replace('-', '+');
                        break;
                    case "*":
                        ramdop = ramdop.Replace('*', '^');
                        break;
                    case "~":
                        ramdop = ramdop.Replace('~', '°');
                        break;
                    case "_":
                        ramdop = ramdop.Replace('_', ' ');
                        break;
                    case ".":
                        ramdop = ramdop.Replace('.', ',');
                        break;
                    case ",":
                        ramdop = ramdop.Replace(',', '.');
                        break;
                    case ":":
                        ramdop = ramdop.Replace(':', ';');
                        break;
                    case ";":
                        ramdop = ramdop.Replace(';', ':');
                        break;
                    case "µ":
                        ramdop = ramdop.Replace('µ', '§');
                        break;
                    case "#":
                        ramdop = ramdop.Replace('#', '=');
                        break;
                    case "'":
                        ramdop = ramdop.Replace('\'', '"');
                        break;
                    case "<":
                        ramdop = ramdop.Replace('<', '>');
                        break;
                    case ">":
                        ramdop = ramdop.Replace('>', '<');
                        break;
                    case "|":
                        ramdop = ramdop.Replace('|', '&');
                        break;
                    case "^":
                        ramdop = ramdop.Replace('^', '*');
                        break;
                    case "°":
                        ramdop = ramdop.Replace('°', '~');
                        break;
                }
                resultdop += ramdop;
            }

            Console.WriteLine(resultdop);
            Decode(); 
        }
    }

    private static void Encode()
    {
        string encodeop;
        string rameop = "";
        string resulteop = "";

        Console.WriteLine("\nPlease enter your encoded text you want to decode\nEnter exit to go to the menu\n");
        encodeop = Console.ReadLine().ToLower();

        if (encodeop == "exit")
        {
            Start();
        }
        else
        {
            for (int i = 0; i < encodeop.Length; i++)
            {
                rameop = encodeop.Substring(i, 1);

                switch (rameop)
                {
                    case "q":
                        rameop = rameop.Replace('q', 'a');
                        break;
                    case "w":
                        rameop = rameop.Replace('w', 'b');
                        break;
                    case "e":
                        rameop = rameop.Replace('e', 'c');
                        break;
                    case "r":
                        rameop = rameop.Replace('r', 'd');
                        break;
                    case "t":
                        rameop = rameop.Replace('t', 'e');
                        break;
                    case "z":
                        rameop = rameop.Replace('z', 'f');
                        break;
                    case "u":
                        rameop = rameop.Replace('u', 'g');
                        break;
                    case "i":
                        rameop = rameop.Replace('i', 'h');
                        break;
                    case "o":
                        rameop = rameop.Replace('o', 'i');
                        break;
                    case "p":
                        rameop = rameop.Replace('p', 'j');
                        break;
                    case "ü":
                        rameop = rameop.Replace('ü', 'k');
                        break;
                    case "a":
                        rameop = rameop.Replace('a', 'l');
                        break;
                    case "s":
                        rameop = rameop.Replace('s', 'm');
                        break;
                    case "d":
                        rameop = rameop.Replace('d', 'n');
                        break;
                    case "f":
                        rameop = rameop.Replace('f', 'o');
                        break;
                    case "g":
                        rameop = rameop.Replace('g', 'p');
                        break;
                    case "h":
                        rameop = rameop.Replace('h', 'q');
                        break;
                    case "j":
                        rameop = rameop.Replace('j', 'r');
                        break;
                    case "k":
                        rameop = rameop.Replace('k', 's');
                        break;
                    case "l":
                        rameop = rameop.Replace('l', 't');
                        break;
                    case "ö":
                        rameop = rameop.Replace('ö', 'u');
                        break;
                    case "ä":
                        rameop = rameop.Replace('ä', 'v');
                        break;
                    case "y":
                        rameop = rameop.Replace('y', 'w');
                        break;
                    case "x":
                        rameop = rameop.Replace('x', 'ß');
                        break;
                    case "c":
                        rameop = rameop.Replace('c', 'y');
                        break;
                    case "v":
                        rameop = rameop.Replace('v', 'z');
                        break;
                    case "b":
                        rameop = rameop.Replace('b', 'ä');
                        break;
                    case "n":
                        rameop = rameop.Replace('n', 'ö');
                        break;
                    case "m":
                        rameop = rameop.Replace('m', 'ü');
                        break;
                    case " ":
                        rameop = rameop.Replace(' ', '_');
                        break;
                    case "!":
                        rameop = rameop.Replace('!', '?');
                        break;
                    case "\"":
                        rameop = rameop.Replace('"', '\'');
                        break;
                    case "§":
                        rameop = rameop.Replace('§', 'µ');
                        break;
                    case "$":
                        rameop = rameop.Replace('$', '%');
                        break;
                    case "%":
                        rameop = rameop.Replace('%', '$');
                        break;
                    case "&":
                        rameop = rameop.Replace('&', '|');
                        break;
                    case "/":
                        rameop = rameop.Replace('/', '\\');
                        break;
                    case "(":
                        rameop = rameop.Replace('(', '{');
                        break;
                    case ")":
                        rameop = rameop.Replace(')', '}');
                        break;
                    case "=":
                        rameop = rameop.Replace('=', '#');
                        break;
                    case "ß":
                        rameop = rameop.Replace('ß', 'x');
                        break;
                    case "?":
                        rameop = rameop.Replace('?', '!');
                        break;
                    case "{":
                        rameop = rameop.Replace('{', '[');
                        break;
                    case "}":
                        rameop = rameop.Replace('}', ']');
                        break;
                    case "[":
                        rameop = rameop.Replace('[', '(');
                        break;
                    case "]":
                        rameop = rameop.Replace(']', ')');
                        break;
                    case "\\":
                        rameop = rameop.Replace('\\', '/');
                        break;
                    case "+":
                        rameop = rameop.Replace('+', '-');
                        break;
                    case "-":
                        rameop = rameop.Replace('-', '+');
                        break;
                    case "*":
                        rameop = rameop.Replace('*', '^');
                        break;
                    case "~":
                        rameop = rameop.Replace('~', '°');
                        break;
                    case "_":
                        rameop = rameop.Replace('_', ' ');
                        break;
                    case ".":
                        rameop = rameop.Replace('.', ',');
                        break;
                    case ",":
                        rameop = rameop.Replace(',', '.');
                        break;
                    case ":":
                        rameop = rameop.Replace(':', ';');
                        break;
                    case ";":
                        rameop = rameop.Replace(';', ':');
                        break;
                    case "µ":
                        rameop = rameop.Replace('µ', '§');
                        break;
                    case "#":
                        rameop = rameop.Replace('#', '=');
                        break;
                    case "'":
                        rameop = rameop.Replace('\'', '"');
                        break;
                    case "<":
                        rameop = rameop.Replace('<', '>');
                        break;
                    case ">":
                        rameop = rameop.Replace('>', '<');
                        break;
                    case "|":
                        rameop = rameop.Replace('|', '&');
                        break;
                    case "^":
                        rameop = rameop.Replace('^', '*');
                        break;
                    case "°":
                        rameop = rameop.Replace('°', '~');
                        break;
                } 
                resulteop += rameop;
            }

            Console.WriteLine(resulteop);
            Encode();
        }
    }
}