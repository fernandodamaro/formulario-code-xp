using System;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,email,logradouro,complemento,bairro,cidade,estado,civil,departamento,cargo,entrada,saida;
            string idade,numero,cep,rg,cpf,quantos,salario;
            string filhos;
            
            Console.Write("Nome completo: ");
            nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("CEP: ");
            cep = Console.ReadLine();

            Console.Write("Logradouro: ");
            logradouro = Console.ReadLine();  

            Console.Write("Número: ");
            numero = Console.ReadLine();          

            Console.Write("Complemento: ");
            complemento = Console.ReadLine();

            Console.Write("Bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Cidade: ");
            cidade = Console.ReadLine();

            Console.Write("Estado: ");
            estado = Console.ReadLine();

            Console.Write("RG: ");
            rg = Console.ReadLine();

            Console.Write("CPF: ");
            cpf = Console.ReadLine();

            Console.Write("Estado Civil: ");
            civil = Console.ReadLine();

            Console.Write("Tem filhos? ");
            filhos = Console.ReadLine();

            Console.Write("Quantos? ");
            quantos = Console.ReadLine();

            Console.Write("Departamento: ");
            departamento = Console.ReadLine();

            Console.Write("Cargo: ");
            cargo = Console.ReadLine();

            Console.Write("Salário: R$");
            salario = Console.ReadLine();

            Console.Write("Horario de entrada: ");
            entrada = Console.ReadLine();

            Console.Write("Horario de saída: ");
            saida = Console.ReadLine();
          

            FileInfo fi = new FileInfo("dados_formulario.csv");

            StreamWriter arquivo;
          
            if(fi.Exists){
            arquivo = new StreamWriter("dados_formulario.csv",true);
            arquivo.WriteLine(nome+";"+email+";"+logradouro+";"+complemento+";"+bairro+";"+cidade+";"+estado+";"+civil+";"+departamento+";"+cargo+";"+entrada+";"+saida+";"+idade+";"+numero+";"+cep+";"+rg+";"+cpf+";"+salario+";"+filhos+";"+quantos);
            }
            else{
            arquivo = new StreamWriter("dados_formulario.csv",true);
            arquivo.WriteLine("nome;email;logradouro;complemento;bairro;cidade;estado;civil;departamento;cargo;entrada;saida;idade;numero;cep;rg;cpf;salario;filhos;quantos");
            arquivo.WriteLine(nome+";"+email+";"+logradouro+";"+complemento+";"+bairro+";"+cidade+";"+estado+";"+civil+";"+departamento+";"+cargo+";"+entrada+";"+saida+";"+idade+";"+numero+";"+cep+";"+rg+";"+cpf+";"+salario+";"+filhos+";"+quantos);
            }

            /*Todas as variaveis listadas abaixo */
            // string nome,email,logradouro,complemento,bairro,cidade,estado,civil,departamento,cargo,entrada,saida;
            // int idade,numero,cep,rg,cpf,quantos,salario;
            // bool filhos;

            arquivo.Close(); 

            Console.WriteLine("Olá, "+nome+" o formulário foi enviado com sucesso!");
            

        }
    }
}
