using System.Security.AccessControl;

class Program 
{
    static void Main(string[] args)
    {
     
        //exercicio 1 - Tocar todas as notas de uma oitava.

        // Console.WriteLine("Qual oitava deseja tocar?");
        // int oitava = int.Parse(Console.ReadLine());
        // int contador = 1;
        // const int TAMANHO_OITAVA = 7;


        // while (contador <= TAMANHO_OITAVA)
        // {
        //     Piano.ReproduzTecla(oitava,contador);
        //     contador++;
        // }


        //exercicio 2 - Tocar notas ímpares da oitava:

        const int TAMANHO_OITAVA = 7;
        int contador = 1;

        while (contador <= TAMANHO_OITAVA)
        {
            if (contador % 2 == 1)
            {
                Piano.ReproduzTecla(1,contador);
            }
        contador++;
        }
    }
}