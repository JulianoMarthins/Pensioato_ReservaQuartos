using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperior {
    internal class Program {
        static void Main(string[] args) {
                      

            Console.Write("Quantos quartos deseja reservar: ");
            int num = int.Parse(Console.ReadLine());


            Pessoa[] reservas = new Pessoa[10];

            Console.WriteLine(reservas.Length);

            for (int i = 1; i <= num; i++) {

                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                reservas[quarto] = new Pessoa(nome, email);

            }


            Console.WriteLine("\nQuartos reservados: ");


            for(int i = 1; i <= reservas.Length; i++) {
                if(reservas[i] != null) {
                    Console.WriteLine($"Quarto {i}: {reservas[i].nome}, {reservas[i].email}");

                }
                
             
            }


        }
    }
}
