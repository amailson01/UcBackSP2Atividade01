namespace Atividade01
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;} 
        public string ie {get; set;} 

        public override void Pagar_Imposto(float v)
        {
            //Mudança do imposto Pessoa Juridica para 20%
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }

}