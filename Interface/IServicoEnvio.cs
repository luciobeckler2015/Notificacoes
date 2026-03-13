namespace Notificacoes.Interface
{
    public interface IServicoEnvio
    {
        bool ProcessarEnvio(string destinatario, string titulo, string conteudo);
    }
}
