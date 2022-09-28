using System;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Threading.Tasks;

namespace DataNascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaAtual, mesAtual, anoAtual, diaNascimento, mesNascimento, anoNascimento, idadeDia = 0, idadeMes = 0, idadeAno = 0, op = 0;

            do
            {
                Console.WriteLine("Escolha \n 0-Sair \n 1-Calcular idade");
                op = int.Parse(Console.ReadLine());
               
                Console.Clear();
                switch (op)
                {
                    default:
                        Console.WriteLine("Opção inválida! ");
                        break;

                    case 0:
                        Console.Write("Saindo ");
                        Thread.Sleep(300);
                        Console.Write(". ");
                        Thread.Sleep(300);
                        Console.Write(". ");
                        Thread.Sleep(300);
                        Console.Write(". ");
                        Thread.Sleep(300);
                        break;

                    case 1:
                        Console.WriteLine("<<< ARMAZENANDO DATA ATUAL >>>");
                        Console.Write("Informe o dia Atual: ");
                        diaAtual = int.Parse(Console.ReadLine());
                        Console.Write("Informe o mês Atual: ");
                        mesAtual = int.Parse(Console.ReadLine());
                        Console.Write("Informe o ano Atual: ");
                        anoAtual = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n<<< ARMAZENANDO DATA NASCIMENTO >>>");
                        Console.Write("Informe o dia de nascimento: ");
                        diaNascimento = int.Parse(Console.ReadLine());
                        Console.Write("Informe o mês de nascimento: ");
                        mesNascimento = int.Parse(Console.ReadLine());
                        Console.Write("Informe o ano de nascimento: ");
                        anoNascimento = int.Parse(Console.ReadLine());

                        if (anoNascimento > anoAtual)
                        {
                            Console.WriteLine("Dado incorreto, ano de nascimento precisa ser menor ou igual ao ano atual ");
                        }

                        else
                        {
                            if (mesAtual < 1 || mesAtual > 12 || mesNascimento < 1 || mesNascimento > 12)
                            {
                                Console.WriteLine("Dado incorreto, o mês tem que estar entre 1 e 12 ");
                            }

                            else
                            {
                                if (diaAtual < 1 || diaAtual > 31 || diaNascimento < 1 || diaNascimento > 31)
                                {
                                    Console.WriteLine("Dado incorreto, o dia tem que estar entre 1 e 31 ");
                                }
                                else
                                {
                                    if (mesNascimento > mesAtual)//não fiz aniversario
                                    {
                                        idadeAno = (anoAtual - anoNascimento) - 1;//-1 pq não fiz aniversario
                                        idadeMes = (12 - mesNascimento) + (mesAtual);
                                        if (diaNascimento > diaAtual)//não fiz aniversario
                                        {
                                            idadeDia = (30 - diaNascimento) + diaAtual;
                                        }

                                        else
                                        {
                                            idadeDia = diaAtual - diaNascimento;
                                        }

                                    }

                                    if (mesNascimento < mesAtual)//fiz aniversario
                                    {
                                        idadeAno = anoAtual - anoNascimento;

                                        if (diaNascimento > diaAtual)//ja fiz aniversario
                                        {
                                            idadeDia = (30 - diaNascimento) + diaAtual;
                                            idadeMes = (mesAtual - mesNascimento) - 1;
                                        }
                                        else
                                        {
                                            idadeDia = diaAtual - diaNascimento;
                                            idadeMes = (mesAtual - mesNascimento);
                                        }
                                    }

                                    if (mesNascimento == mesAtual)//aniversario nesse mes
                                    {
                                        if (diaNascimento > diaAtual)//não fiz aniversario
                                        {
                                            idadeAno = (anoAtual - anoNascimento) - 1;//não fiz aniversario
                                            idadeMes = 11; //faço aniversario esse mes;
                                            idadeDia = (30 - diaNascimento) + diaAtual; //faço aniversario daqui uns dias;
                                        }
                                        else
                                        {
                                            idadeAno = anoAtual - anoNascimento;//já fiz aniversário
                                            idadeMes = 0;//já fiz aniversario
                                            idadeDia = diaAtual - diaNascimento;//já fiz aiversario

                                        }
                                    }
                                    while (anoNascimento < anoAtual)
                                    {
                                        if (anoNascimento % 4 == 0)
                                        {
                                            idadeDia = idadeDia + 1;
                                        }
                                        anoNascimento++;
                                    }
                                    Console.WriteLine("Você tem: " + idadeAno + " anos " + idadeMes + " meses " + idadeDia + " dias.");

                                }
                            }

                        }
                      


                        Console.ReadKey();
                        Console.Clear();
                break;
            }
            } while (op != 0);
        }
    }
}
