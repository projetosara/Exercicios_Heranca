namespace EXE2;
class Program
{
    static void Main(string[] args)
    {
        PessoaFisica n1 = new PessoaFisica();
        PessoaJuridica n2 = new PessoaJuridica();

       n1.Nome = "Sara";
       n1.Email = "sara.basso@etec.sp.gov.br";
       n1.Telefone = "949184748";
       n1.Cpf = "000000000-00";
       n1.Idade = "16";

       n2.Nome = "Sara";
       n2.Email = "sara.basso@etec.sp.gov.br";
       n2.Telefone = "949184748";
       n2.Cnpj = "XX.XXX.XXX/0001-XX";
       n2.IE = "00000000";
       n2.NomeEmpresa = "Empresa SBPV";

       Console.WriteLine(n1.MostrarDados());
       Console.WriteLine(n2.MostrarDados());

    }
}
