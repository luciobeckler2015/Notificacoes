using Notificacoes.Interface;

namespace Notificacoes.Classes
{
    public class ServicoSms : IServicoEnvio
    {
        public bool ProcessarEnvio(string destinatario, string titulo, string conteudo)
        {
            Console.WriteLine($"[SMS] -> Para: {destinatario}. Msg: {conteudo}");
            return true;
        }
    }
}
