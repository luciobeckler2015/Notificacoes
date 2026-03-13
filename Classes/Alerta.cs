using Notificacoes.Interface;

public class Alerta
{
    public string Destinatario { get; private set; }
    public string Conteudo { get; private set; }
    public string Titulo { get; set; }

    private readonly IServicoEnvio _servicoEnvio;

    public Alerta(string destinatario, string titulo,
        string conteudo, IServicoEnvio servicoEnvio)
    {
        Destinatario = destinatario;
        Conteudo = conteudo;
        Titulo = titulo;
        _servicoEnvio = servicoEnvio;
    }

    public void Enviar()
    {
        _servicoEnvio.ProcessarEnvio(Destinatario, Titulo, Conteudo);
    }
}