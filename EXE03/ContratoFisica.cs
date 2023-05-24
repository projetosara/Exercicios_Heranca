namespace EXE03;
class ContratoFisica:Contratos
{
   public string? CPF {get;set;}
   public int? Idade {get;set;}

    public override string MostraDados(){
        return base.MostraDados() + " - CPF:" + this.CPF + " - Idade:" + this.Idade;
    }

    public override double calcularPrestacao(){
        if (Idade <= 30)
        {
            return ((base.calcularPrestacao()/prazo)+1);
        } else if (Idade <= 40)
        {
            return ((base.calcularPrestacao()/prazo)+2);
        } else if (Idade <= 50)
        {
            return ((base.calcularPrestacao()/prazo)+3);
        } else 
        {
            return ((base.calcularPrestacao()/prazo)+4);
        } 
    }
}  

