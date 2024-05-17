using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        if (!Int32.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        var safe = Console.ReadLine();
        var boolvar = true;
        if (safe.Length == 0 || safe.Length >= 1 && !boolvar)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        int A = a & b;
        int B = a | b ;
        int C = a ^ b;
        switch (safe[0])
        {
            case '&':
            {
                Console.WriteLine("10form -- Result of {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("2form -- Result of {0} & {1} = {2}", Convert.ToString(a,2), Convert.ToString(b,2), Convert.ToString(A, 2));
                Console.WriteLine("16form -- Result of {0} & {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(A, 16));
                    break;
            }
            case '|':
                {
                    Console.WriteLine("10form -- Result of {0} | {1} = {2}", a, b, a | b);
                    Console.WriteLine("2form -- Result of {0} | {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(B, 2));
                    Console.WriteLine("16form -- Result of {0} | {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(B, 16));
                    break;
                }
            case '^':
                {
                    Console.WriteLine("10form -- Result of {0} ^ {1} = {2}", a, b, a ^ b);
                    Console.WriteLine("2form -- Result of {0} ^ {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(C, 2));
                    Console.WriteLine("16form -- Result of {0} ^ {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(C, 16));
                    break;
                }
            default:
                {
                    Console.WriteLine(1);
                    break;
                }
        }
    }

}
