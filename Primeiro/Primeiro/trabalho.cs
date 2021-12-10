using System;
using System.Globalization;
using System.Threading;
namespace TheRock
{
    class Rock
    {
       // public int IniciarPrograma()
        static void Main(string[] args)
        {
            // ------- Variaveis Globais -------- //
            string Finalizar = "1";
            string Estilo = null; 
            // ------- Fim das variaveis Globais ------- //


            while (Finalizar != "0")
            {

                Console.Clear();
                Console.WriteLine(" -> Digite o estilo de música desejado");
                Console.Write(" -> ");
                Estilo = Console.ReadLine();
                if (Estilo == "rock" || Estilo == "Rock" || Estilo == "ROCK")
                {
                    Console.Clear();
                    Console.WriteLine("============================================top 10 músicas the rock============================================");
                    Console.WriteLine("");
                    Console.WriteLine(" -> Exibindo Resultados de buscas pela playlist '{0}'", Estilo);
                    Console.WriteLine(" -> Kashimir");
                    Console.WriteLine(" -> Bohemian Rhapsody");
                    Console.WriteLine(" -> Alive");
                    Console.WriteLine(" -> Black Dog");
                    Console.WriteLine(" -> Like a rolling stone");
                    Console.WriteLine(" -> AC/DC");
                    Console.WriteLine(" -> Angie");
                    Console.WriteLine(" -> Purple Stain");
                    Console.WriteLine(" -> Another Brick in the Wall");
                    Thread.Sleep(4000);
                }


                else if(Estilo == "Samba" || Estilo == "samba" || Estilo == "SAMBA")
                {
                    Console.Clear();
                    Console.WriteLine("============================================top 10 músicas de samba============================================");
                    Console.WriteLine("");
                    Console.WriteLine(" -> Exibindo Resultados de buscas pela playlist '{0}'...", Estilo);
                    Console.WriteLine(" -> Alma Boêmia");
                    Console.WriteLine(" -> Sunday Bloody Sunday - Sambô");
                    Console.WriteLine(" -> Não deixe o samba morrer");
                    Console.WriteLine(" -> Timoneiro");
                    Console.WriteLine(" -> Brasil Pandeiro");
                    Console.WriteLine(" -> Canta canta, minha gente");
                    Console.WriteLine(" -> Tristeza pé no chão");
                    Console.WriteLine(" -> Conversa de botequim");
                    Console.WriteLine(" -> Trem das Onze");
                    Thread.Sleep(4000);
                }

                else if(Estilo == "MPB" || Estilo == "mpb" || Estilo == "Mpb")
                {
                    Console.Clear();
                    Console.WriteLine("============================================top 10 músicas de MPB============================================");
                    Console.WriteLine("");
                    Console.WriteLine(" -> Exibindo Resultados de buscas pela playlist '{0}'...", Estilo);
                    Console.WriteLine(" -> Pais e Filhos");
                    Console.WriteLine(" -> Como Nossos Pais");
                    Console.WriteLine(" -> Mais do mesmo");
                    Console.WriteLine(" -> Águas de Março");
                    Console.WriteLine(" -> Vamos Fugir");
                    Console.WriteLine(" -> Gostava Tanto de Você");
                    Console.WriteLine(" -> Como Nossos Pais");
                    Console.WriteLine(" -> Metamorfose Ambulante");
                    Console.WriteLine(" -> Pro Dia Nascer Feliz");
                    Thread.Sleep(4000);
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine(" -> Playlist '{0}' Não encontrada, por favor, tente outro genero", Estilo);
                }

                Console.WriteLine(" -> Deseja visualizar mais playlists? caso contrario, Digite '0' para encerrar");
                Console.Write(" -> ");
                Finalizar = Console.ReadLine();
            }
            Console.Clear();
            Console.Write("Desligando Sistema");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Console.WriteLine("Programa desenvolvido Por Victor_Maciel");
            Console.WriteLine("Programa Encerrado pelo usuario");
            Console.Write("Codigo enviado {0} zerando variaveis '{1}', '{2}'", Finalizar, Estilo, Finalizar);
            Thread.Sleep(100);
            //return 1;
        }
       
    }
}