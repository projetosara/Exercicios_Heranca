namespace EXE2;
class PessoaJuridica:Contrato
{
    public string? Cnpj {get;set;}
    public string? IE {get;set;}
    public string? NomeEmpresa {get;set;}

    public override string MostrarDados(){
        return base.MostrarDados() +"\nCNPJ: "+ this.Cnpj +"\nIE: "+ this.IE +"\nNome da Empresa: "+ this.NomeEmpresa;
    }
}
 