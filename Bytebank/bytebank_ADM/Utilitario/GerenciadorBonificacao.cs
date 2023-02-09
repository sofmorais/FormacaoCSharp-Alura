using bytebank_ADM.Colaboradores;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Colaborador colaborador)
        {
            this.TotalBonificacao += colaborador.GetBonificacao();
        }
    }
}
