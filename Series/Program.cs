using System;
using System.Collections.Generic;

namespace Series{

    class Program{

        static void addSerie(Catalog catalog){

            Console.Clear();

            bool exit = false;

            while(!exit){

                int id = catalog.nextId;
                Console.WriteLine("----------------------------------------");
                Console.Write("titulo: ");
                string title = Console.ReadLine();
                Console.Write("descricao: ");
                string description = Console.ReadLine();
                Console.Write("autor: ");
                string author = Console.ReadLine();

                Serie serie = new Serie(id, title, description, author);

                catalog.add(serie);

                Console.Write("Adicionado. Deseja adicionar mais? [y]");
                string option = Console.ReadLine();

                if(option[0] != 'y' && option[0] != 'Y') exit = true;
                Console.Clear();
            }
        }

        static void deleteSerie(Catalog catalog){

            Console.Clear();

            bool exit = false;

            while(!exit){

                Console.WriteLine("----------------------------------------");
                Console.Write("digite o id para deletar a serie: ");
                int id = Convert.ToInt32(Console.ReadLine());

                catalog.delete(id);

                Console.Write("Deletado. Deseja deletar mais? [y]");
                string option = Console.ReadLine();

                if(option[0] != 'y' && option[0] != 'Y') exit = true;
                Console.Clear();
            }
        }

        static void seeSerie(Catalog catalog){

            Console.Clear();

            bool exit = false;

            while(!exit){

                Console.WriteLine("----------------------------------------");
                Console.Write("digite o id para ver a serie: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Serie serie = catalog.get(id);

                if(serie == null){
                    Console.WriteLine(">>>>> A serie nao existe");
                }
                else{
                    Console.WriteLine(">>>>> Titulo: " + serie.title);
                    Console.WriteLine(">>>>> Descricao: " + serie.description);
                    Console.WriteLine(">>>>> Autor: " + serie.author);
                }

                Console.Write("Deseja ver mais? [y]");
                string option = Console.ReadLine();

                if(option[0] != 'y' && option[0] != 'Y') exit = true;
                Console.Clear();
            }
        }

        static void updateSerie(Catalog catalog){

            Console.Clear();

            bool exit = false;

            while(!exit){

                Console.WriteLine("----------------------------------------");
                Console.Write("digite o id para atualizar a serie: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("titulo: ");
                string title = Console.ReadLine();
                Console.Write("descricao: ");
                string description = Console.ReadLine();
                Console.Write("autor: ");
                string author = Console.ReadLine();

                Serie serie = new Serie(id, title, description, author);

                catalog.update(id, serie);

                Console.Write("Atualizado. Deseja atualizar mais? [y]: ");
                string option = Console.ReadLine();

                if(option[0] != 'y' && option[0] != 'Y') exit = true;
                Console.Clear();
            }
        }

        static void listSeries(Catalog catalog){

            List<Serie> series = catalog.list();

            for(int i=0;i<series.Count;i++){
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Titulo: " + series[i].title);
                Console.WriteLine("Descricao: " + series[i].description);
                Console.WriteLine("Autor: " + series[i].author);
            }

            Console.WriteLine("--------------------------------------------");
            Console.Write("Deseja voltar? [any]: ");
            string option = Console.ReadLine();
        }

        static void menu(){

            bool exit = false;

            Catalog catalog = new Catalog();

            while(!exit){

                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Seja bem-vindo ao DIOFLIX!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Escolha uma opcao:\n");
                Console.WriteLine("[1] Adicionar serie");
                Console.WriteLine("[2] remover serie");
                Console.WriteLine("[3] ver serie");
                Console.WriteLine("[4] atualizar serie");
                Console.WriteLine("[5] listar series");
                Console.WriteLine("[any] sair");

                string option = Console.ReadLine();

                if(option == "1") addSerie(catalog);
                else if(option == "2") deleteSerie(catalog);
                else if(option == "3") seeSerie(catalog);
                else if(option == "4") updateSerie(catalog);
                else if(option == "5") listSeries(catalog);
                else exit = true;
            }
        }

        static void Main(string[] args){

            menu();
        }
    }
}