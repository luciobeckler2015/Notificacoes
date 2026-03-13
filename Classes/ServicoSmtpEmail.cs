using Notificacoes.Interface;

namespace Notificacoes.Classes
{
    public class ServicoSmtpEmail : IServicoEnvio
    {
        public bool ProcessaEnvio(string destinatario, string titulo, string conteudo)
        {
            Console.WriteLine($"[EMAIL] {titulo} -> Para: {destinatario}. Msg: {conteudo}");
            return true;
        }
    }
}
