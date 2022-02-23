
using System;
using CADASTRO_PESSOA_FS1.Classes;
using System.IO; //necessária para o StreamWrite utilizado na criação dos arquivos .txt
using System.Threading;

Console.WriteLine(@$"
============================================================
|           Bem vindo ao Sistema de Cadastro de            |
|               Pesssoas Físicas e Jurídicas               |
============================================================
");

BarraAçao("Carregando ", 1500); //código definido após o final do "do-while" no static

string opcao; //precisa ser definida anteriormente para ser usada na estrut de repetição do while

do
{
    Console.Clear();

    Console.WriteLine(@$"
============================================================
|               Escolha uma das opções abaixo:             |
|                 1 - Pessoa Física                        |
|                 2 - Pessoa Jurídica                      |
|                                                          |
|                 0 - Sair                                 |
============================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.nome = "Elisson Andrade";
            novaPf.dataNascimento = "02/01/1989";
            novaPf.cpf = "111.222.333-44";
            novaPf.rendimento = 1000.10m;

            novoEnd.logradouro = "Rua de Piata";
            novoEnd.numero = 123;
            novoEnd.complemento = "SENAI Informática";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Data de Nascimento: {novaPf.dataNascimento}
            CPF: {novaPf.cpf}
            Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Escola: {novoEnd.complemento}
            Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
            ");

            Console.WriteLine($"'Enter' para continuar...");
            Console.ReadLine();

            break;

        case "2":

            PessoaJuridica metodoPj = new PessoaJuridica(); //objeto para método

            PessoaJuridica novaPj = new PessoaJuridica(); //objeto separado para criar dados da pessoa juridica
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pessoa Jurídica";
            novaPj.cnpj = "11.222.333/0001-44";
            novaPj.razaoSocial = "Razão Social Pj LTDA";
            novaPj.rendimento = 10000.10m;

            novoEndPj.logradouro = "Rua de Piata";
            novoEndPj.numero = 123;
            novoEndPj.complemento = "SENAI Informática";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            Endereço: {novoEndPj.logradouro}, {novoEndPj.numero}
            Instituição: {novoEndPj.complemento}
            CNPJ: {novaPj.cnpj}
            CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
            ");

            Console.WriteLine($"'Enter' para continuar...");
            Console.ReadLine();

            break;

        case "0":

            Console.Clear();
            Console.WriteLine($"    Obrigado por utilizar nosso Sistema!\n");

            BarraAçao("         Finalizando ", 500);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"    Opção inválida! Por favor, verifique as opções do menu.\n");

            BarraAçao("         Voltando ao menu ", 1200);

            break;
    }

} while (opcao != "0");

static void BarraAçao(string texto, int tempo) //criando uma função static para definir configurações da barra de carregamento
{
            // Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write($"{texto}");
            for (var i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
}
