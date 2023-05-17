namespace EXE2;
class PessoaFisica: Contrato
{
   public string? Cpf {get;set;}
   public string? Idade {get;set;}

    public override string MostrarDados(){
        return base.MostrarDados() +"\nCpf: "+ this.Cpf +"\nIdade: "+ this.Idade;
    }
}
