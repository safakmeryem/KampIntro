using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            operations.Topla(78, 52,5);
            operations.Topla(13, 9,3);
            // Şu an burada encapsulationa uymadım
            // yeni bir parametre geldiğinde her yerden değiştiriyorum, proje büyüdüğünde sıkıntı bu

        }
    }
}
