namespace EXE03;
class Contratos
{
    public string? nome {get;set;}
    public string? email {get;set;}
    public int prazo {get;set;}

    public virtual string MostraDados(){
         return "nome: " + this.nome + " - email: " + this.email;
    }

    public virtual double calcularPrestacao(){
        return 1000;
    }
}
