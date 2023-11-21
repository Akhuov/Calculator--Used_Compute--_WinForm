
using System.Linq.Expressions;
using System.Reflection.Metadata;
int MatH(int a, int b,char c)
{
    switch(c){
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            return a / b;
        case '%':
            return a % b;
        default: return a;
    }
}


void Show()
{
    Console.Write("Warning!!!\nThis calculator works only with two numbers(num+-%*/num)\n");
}

Console.WriteLine("Welcome to my first Calculator on C#");
Show();



while(true)
{
    var inp = "";
    var ch = "+-%*/";
    int res = 0;
    char bel = '_';
    string a = "", b = "";
    int x = 0;
    Console.Write("Write your Ex:");
    inp = Console.ReadLine();
    Console.Clear();
    {
        if (inp != "")
        {
            if (inp.ToLower() == "clear")
            {
                Show();
                Console.Clear();
                continue;
            }



            if (inp.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine("##########\n" + "Thank you!" + "\n##########");
                break;
            }





            for (int i = 0; i < inp.Length; i++)
            {
                foreach (char d in ch)
                {
                    if (d == inp[i])
                    {
                        bel = d;
                        x = i;
                    }
                    else
                        continue;
                }
            }
            if (bel == '_')
            {
                Show();
                continue;
            }


            int io = 0;

            for (int i = 0; i < x; i++)
            {
                if (Char.IsDigit(inp[i]))
                    a += inp[i];
                if (!(Char.IsDigit(inp[i])))
                    io++;

            }
            for (int i = x + 1; i < inp.Length; i++)
            {
                if (Char.IsDigit(inp[i]))
                    b += inp[i];
                if (!(Char.IsDigit(inp[i])))
                    io++;
            }
            if (io != 0 || a == "" || b == "")
                Show();




            res = MatH(Convert.ToInt32(a), Convert.ToInt32(b), bel);

        }
        else
        {
            Console.Clear();
            Show();
            continue;
        }
    }
    Console.WriteLine($"{a} {bel} {b} = {res}");
}
