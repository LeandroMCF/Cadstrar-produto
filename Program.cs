using System;

namespace Cadstrar_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolhaMenu, escolhaCorre, confiNovoNome, confiNovoValor, rep;
            string[] nome = new string[4], promocoes = new string[4];
            float[] preco = new float[4];
            bool promocao = true;
            int cont = 0, poseNome = 0, poseValor;

            Console.WriteLine("----------------\nCadastrando produtos\n----------------");
            do
            {
                Console.WriteLine($"[C] Cadastrar produto\n[L] Listar produtos\n[M] Mudar/Correção\n[S] Sair");
                escolhaMenu = Console.ReadLine();
                escolhaMenu = escolhaMenu.ToUpper();
                while (escolhaMenu != "C" && escolhaMenu != "L" && escolhaMenu != "M" && escolhaMenu != "S")
                {
                    Console.WriteLine($"Resposta inválida.\n[C] Cadastrar produto\n[L] Listar produtos\n[M] Mudar/Correção\n[S] Sair");
                    escolhaMenu = Console.ReadLine();
                    escolhaMenu = escolhaMenu.ToUpper();
                }
                switch (escolhaMenu)
                {
                    case "C":
                        do
                        {   
                            if (cont < 4)
                            {

                                Console.Write("--------------------\nDigite o nome do produto: ");
                                nome[cont] = Console.ReadLine();
                                Console.Write($"Digite o preço do produto: R$ ");
                                preco[cont] = float.Parse(Console.ReadLine());
                                Console.WriteLine($"Esse produto está na promoção?\n[S] Sim\n[N] Não");
                                string veriSN = Console.ReadLine();
                                veriSN = veriSN.ToUpper();
                                while (veriSN != "S" && veriSN != "N")
                                {
                                    Console.WriteLine($"Resposta inválida\n[S] Sim\n[N] Não");
                                    veriSN = Console.ReadLine();
                                    veriSN = veriSN.ToUpper();
                                }
                                if (veriSN == "S")
                                {
                                    promocao = true;
                                }
                                else
                                {
                                    promocao = false;
                                }

                                if (promocao == true)
                                {
                                    promocoes[cont] = "Produto em promoção";     
                                }
                                else
                                {
                                    promocoes[cont] = "Produto não está em promoção";
                                }
                                cont++;
                            }
                            else
                            {
                                Console.WriteLine($"Limite de produtos cadastrados excedido.");
                            }
                            Console.WriteLine($"Deseja adicionar mais algum produto?\n[S] Sim\n[N] Não");
                            rep = Console.ReadLine();
                            rep = rep.ToUpper();
                            while (rep != "S" && rep != "N")
                            {
                                Console.WriteLine($"Resposta inválida.\nDeseja adicionar mais algum produto?\n[S] Sim\n[N] Não");
                                rep = Console.ReadLine();
                                rep = rep.ToUpper();
                            }

                        } while (rep == "S");
                    break;


                    case "L":
                        while (cont == 0)
                        {
                            Console.WriteLine($"Você ainda não adicionou nenhum produto à sua lista.");
                            break;
                        }
                        for (var i = 0; i < cont; i++)
                        {
                            Console.WriteLine($"--------------------\n{nome[i]} R$ {preco[i]}");
                            Console.WriteLine($"{promocoes[i]}\n--------------------");
                        }
                    break;

                    case "M":
                        Console.WriteLine($"Você deseja corrigir o:\n[N] Nome\n[V] Valor\n[P] Promoção\n[C] Canselar");
                        escolhaCorre = Console.ReadLine();
                        escolhaCorre = escolhaCorre.ToUpper();
                        while (escolhaCorre != "N" && escolhaCorre != "V" && escolhaCorre != "P" && escolhaCorre != "C")
                        {
                            Console.WriteLine($"Resposta inválida.\nVocê deseja corrigir o:\n[N] Nome\n[V] Valor\n[P] Promoção\n[C] Canselar");
                            escolhaCorre = Console.ReadLine();
                            escolhaCorre = escolhaCorre.ToUpper();
                        }
                        switch (escolhaCorre)
                        {
                            case "N":
                                do
                                {   
                                Console.WriteLine($"Digite em qual posição o produto que você deseja alterar está");
                                poseNome = int.Parse(Console.ReadLine());
                                poseNome = poseNome - 1;
                                Console.WriteLine($"O produto que você deseja alterar é o: {nome[poseNome]}?\n[S] Sim\n[N] Não");
                                confiNovoNome = Console.ReadLine();
                                confiNovoNome = confiNovoNome.ToUpper();
                                while (confiNovoNome != "N" && confiNovoNome != "S")
                                {
                                    Console.WriteLine($"Resposta inválida.\nO produto que você deseja alterar é o: {nome[poseNome]}?\n[S] Sim\n[N] Não");
                                    confiNovoNome = Console.ReadLine();
                                    confiNovoNome = confiNovoNome.ToUpper();
                                }
                                } while (confiNovoNome == "N");
                                Console.WriteLine($"Digite o novo nome do produto");
                                nome[poseNome] = Console.ReadLine();
                                Console.WriteLine($"Novo nome do produto salvo!");
                            break;
                            case "V":
                                do
                                {   
                                Console.WriteLine($"Digite em qual posição o valor que você deseja alterar está");
                                poseValor = int.Parse(Console.ReadLine());
                                poseValor = poseValor - 1;
                                Console.WriteLine($"O produto que você deseja alterar o valor é o: {nome[poseValor]}?\n[S] Sim\n[N] Não");
                                confiNovoValor = Console.ReadLine();
                                confiNovoValor = confiNovoValor.ToUpper();
                                while (confiNovoValor != "N" && confiNovoValor != "S")
                                {
                                    Console.WriteLine($"Resposta inválida.\nO produto que você deseja alterar o valor é o: {nome[poseValor]}?\n[S] Sim\n[N] Não");
                                    confiNovoValor = Console.ReadLine();
                                    confiNovoValor = confiNovoValor.ToUpper();
                                }
                                } while (confiNovoValor == "N");
                                Console.WriteLine($"Digite o novo valor do produto");
                                preco[poseValor] = float.Parse(Console.ReadLine());
                                Console.WriteLine($"Novo valor do produto salvo!\n------------------");
                            break;
                        }
                    break;

                    default:
                            Console.WriteLine($"Ok, obrigado. Tchau!");
                    break;
                }    
            } while (escolhaMenu != "S");
        }

        //Funções
    }
}