using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositorio1 = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaousuario = ObterOpcaoUsuario();

            while (opcaousuario.ToUpper() != "x")
            {
                switch (opcaousuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluiSerie();
                        break;
                    case "5":
                        VisualizarFilme();
                        break;
                    case "6":
                        ListarFilmes();
                        break;
                    case "7":
                        InserirFilme();
                        break;
                    case "8":
                        AtualizarFilme();
                        break;
                    case "9":
                        ExcluiFilme();
                        break;
                    case "10":
                        VisualizarFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw  new ArgumentOutOfRangeException();

                }
                opcaousuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços..");
            Console.ReadLine();

        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar series");

            var lista =repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}",serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }
        
        private static void InserirSerie()
            {
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo da serie: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o ano de inicio da serie: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Serie: ");
                string entradaDescricao = Console.ReadLine();

                Serie novaSerie = new Serie (id: repositorio.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);
                                            
                
                repositorio.Insere(novaSerie);

            }

            private static void ExcluiSerie()
            {
                Console.Write("Digite o id da serie:");
                int IndiceSerie = int.Parse(Console.ReadLine());

                repositorio.Exclui(IndiceSerie);
            }

            private static void VisualizarSerie()
            {
                Console.Write("Digite o id da Serie:");
                int IndiceSerie = int.Parse(Console.ReadLine());

                var serie = repositorio.RetornaPorId(IndiceSerie);

                Console.WriteLine(serie);
            }
            private static void AtualizarSerie()
            {
                Console.Write("Digite o id da serie: ");
                int IndiceSerie = int.Parse(Console.ReadLine());

                
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo da serie: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o ano de inicio da serie: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição da Serie: ");
                string entradaDescricao = Console.ReadLine();

                Serie atualizaSerie = new Serie (id: IndiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);

                repositorio.Atualiza(IndiceSerie,atualizaSerie);

            }

            private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            var lista1 =repositorio1.Lista();

            if (lista1.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado");
                return;
            }

            foreach (var filme in lista1)
            {
                var excluido = filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}",filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }
        
        private static void InserirFilme()
            {
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo do Filme: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o ano de inicio do Filme: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição do Filme: ");
                string entradaDescricao = Console.ReadLine();

                Filme novoFilme = new Filme (id: repositorio1.ProximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);
                                            
                
                repositorio1.Insere(novoFilme);

            }

            private static void ExcluiFilme()
            {
                Console.Write("Digite o id do Filme:");
                int IndiceFilme = int.Parse(Console.ReadLine());

                repositorio1.Exclui(IndiceFilme);
            }

            private static void VisualizarFilme()
            {
                Console.Write("Digite o id do Filme:");
                int IndiceFilme = int.Parse(Console.ReadLine());

                var filme = repositorio1.RetornaPorId(IndiceFilme);

                Console.WriteLine(filme);
            }
            private static void AtualizarFilme()
            {
                Console.Write("Digite o id do Filme: ");
                int IndiceFilme = int.Parse(Console.ReadLine());

                
                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o gênero entre as opções acima: ");
                int entradaGenero = int.Parse(Console.ReadLine());

                Console.Write("Digite o titulo do Filme: ");
                string entradaTitulo = Console.ReadLine();

                Console.Write("Digite o ano de inicio do Filme: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.Write("Digite a Descrição do Filme: ");
                string entradaDescricao = Console.ReadLine();

                Serie atualizaFilme= new Serie (id: IndiceFilme,
                                            genero: (Genero)entradaGenero,
                                            titulo:entradaTitulo,
                                            ano:entradaAno,
                                            descricao:entradaDescricao);

                repositorio.Atualiza(IndiceFilme,atualizaFilme);

            }
        


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series e Filmes ao seu Dispor!!");
            Console.WriteLine("Informe a opção Desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir series");
            Console.WriteLine("5 - Visualizar Serie");
            Console.WriteLine();
            Console.WriteLine("6 - Listar filmes");
            Console.WriteLine("7 - Inserir novo filme");
            Console.WriteLine("8 - Atualizar Filme");
            Console.WriteLine("9 - Excluir Filmes");
            Console.WriteLine("10 - Visualizar Filme");
            Console.WriteLine();
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaousuario;

            
        }
    }
}
