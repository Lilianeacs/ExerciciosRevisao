using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Varejo : Empresa, IEmpresa
    {
        private readonly EnviarNotificacaoWhatsApp enviarNotificacaoWhatsApp;

        public Varejo()
        {
            enviarNotificacaoWhatsApp = new EnviarNotificacaoWhatsApp();
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Vende Produto!");
            enviarNotificacaoWhatsApp.EnviarMensagemCliente();
        }
    }
}
