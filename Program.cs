using System;
namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
                if(var_tipo == "f")
                    {
                    // ---- Pessoa Física ----
                    Pessoa_Fisica pfis = new Pessoa_Fisica();
                     pfis.nome = var_nome;
                    pfis.endereco = var_endereco;
                    Console.WriteLine("Informar CPF:");
                    pfis.cpf = Console.ReadLine();
                    Console.WriteLine("Informar RG:");
                    pfis.rg = Console.ReadLine();
                    Console.WriteLine("Informar Valor de Compra:");
                    val_pag = float.Parse(Console.ReadLine());
                    pfis.Pagar_Imposto(val_pag);
                    Console.WriteLine("-------- Pessoa Física ---------");
                    Console.WriteLine("Nome ..........: " + pfis.nome);
                    Console.WriteLine("Endereço ......: " + pfis.endereco);
                    Console.WriteLine("CPF ...........: " + pfis.cpf);
                    Console.WriteLine("RG ............: " + pfis.rg);
                    Console.WriteLine("Valor de Compra: " + pfis.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pfis.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar  : " + pfis.total.ToString("C"));
                    }
                if(var_tipo == "j")
                    {
                    // ---- Pessoa Jurídica ----
                    Pessoa_Juridica pjur = new Pessoa_Juridica();
                    pjur.nome = var_nome;
                    pjur.endereco = var_endereco;
                    Console.WriteLine("Informar CNPJ:");
                    pjur.cnpj = Console.ReadLine();
                    Console.WriteLine("Informar IE:");
                    pjur.ie = Console.ReadLine();
                    Console.WriteLine("Informar Valor de Compra:");
                    val_pag = float.Parse(Console.ReadLine());
                    pjur.Pagar_Imposto(val_pag);
                    Console.WriteLine("-------- Pessoa Jurídica ---------");
                    Console.WriteLine("Nome ..........: " + pjur.nome);
                    Console.WriteLine("Endereço ......: " + pjur.endereco);
                    Console.WriteLine("CNPJ ..........: " + pjur.cnpj);
                    Console.WriteLine("IE ............: " + pjur.ie);
                    Console.WriteLine("Valor de Compra: " + pjur.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: " + pjur.valor_imposto.ToString("C"));
                    Console.WriteLine("Total a Pagar  : " + pjur.total.ToString("C"));
            }
        }
    }
}