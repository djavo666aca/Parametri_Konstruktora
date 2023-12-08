namespace Parametri_Konstruktora
{
    internal class Program
    {
        string Radnja;
        int Telefon;
        char Slovo_grada;

        Program(string R, int T, char S) 
        {
        Radnja = R;
            Telefon = T;
               Slovo_grada = S;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program("Maxi", 069,'B') ;
            
            Console.WriteLine(p1.Radnja);
            Console.WriteLine(p1.Telefon);
            Console.WriteLine(p1.Slovo_grada);

            Program p2 = new Program("Idea", 061, 'N');

            Console.WriteLine(p2.Radnja);
            Console.WriteLine(p2.Telefon);
            Console.WriteLine(p2.Slovo_grada);
        }
    }
}
