namespace EXE03;
class Program
{
    static void Main(string[] args)
    {
        ContratoFisica n1 = new ContratoFisica();
        ContratoJuridico n2 = new ContratoJuridico();

        n1.nome = "Sara";
        n1.email = "sara.basso@etec.sp.gov.br";
        n1.CPF = "123.456.789-10";
        n1.Idade = 16;
        n1.prazo = 4;

        n2.nome = "Nicole";
        n2.email = "nicole@gmail.com";
        n2.CNPJ = "00.000.000/0000-00";
        n2.IE = "111.222.333.444";
        n2.NomeEmpresa = "Empresa Nic";
        n2.prazo = 10;
        

        Console.WriteLine("Os dados do contrato da pessoa física é: " + n1.MostraDados());
        Console.WriteLine("Os dados do contrato da pessoa Juridica é: " + n2.MostraDados());
        Console.WriteLine("O valor de cada prestação da pessoa física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor de cada prestação da Pessoa jurídica é de: " + n2.calcularPrestacao());
    }
}
