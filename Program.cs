
namespace SistemaCompras
{
    class Program
    {
        static void Main (string[] args)
        {
            float val_pag;
            Console.WriteLine("Nome :");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Endereço :");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (F) ou Juridica (J)");
            string var_tipo =  Console.ReadLine();

            if(var_tipo == "F")
            {
                //Pessoa Fisica//
                Pessoa_Fisica  pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco =  var_endereco;
                Console.WriteLine("CPF :");
                pf.CPF = Console.ReadLine();
                Console.WriteLine("RG :");
                pf.RG = Console.ReadLine();
                Console.WriteLine("Valor da compra :");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_imposto(val_pag);
                Console.WriteLine("-----PESSOA FISICA-----");
                Console.WriteLine("Nome............:" + pf.nome);
                Console.WriteLine("Endereço........:" + pf.endereco);
                Console.WriteLine("CPF.............:" + pf.CPF);
                Console.WriteLine("RG..............:" + pf.RG);
                Console.WriteLine("Valor de Compra.:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.........:"+ pf.valor_imposto);
                Console.WriteLine("A PAGAR.........:" + pf.total.ToString("C"));
            }

            if(var_tipo == "J")
            {
                Pessoa_Juridica  pj = new Pessoa_Juridica();       
                pj.nome = var_nome;
                pj.endereco =  var_endereco;
                Console.WriteLine("CNPJ :");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("RG :");
                pj.IE = Console.ReadLine();
                Console.WriteLine("Valor da compra :");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_imposto(val_pag);

                Console.WriteLine("-----PESSOA JURIDICA-----");
                Console.WriteLine("Nome............:" + pj.nome);
                Console.WriteLine("Endereço........:" + pj.endereco);
                Console.WriteLine("CNPJ.............:" + pj.CNPJ);
                Console.WriteLine("IE..............:" + pj.IE);
                Console.WriteLine("Valor de Compra.:" + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.........:"+ pj.valor_imposto);
                Console.WriteLine("A PAGAR.........:" + pj.total.ToString("C"));
            }
            }
             
        }
}

