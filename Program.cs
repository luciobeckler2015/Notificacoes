using Notificacoes.Classes;
using Notificacoes.Interface;

public class Program
{
    public static void Main()
    {
        List<Alerta> fila = new List<Alerta>();

        IServicoEnvio motorEmail = new ServicoSmtpEmail();
        IServicoEnvio motorSms = new ServicoSms();

        fila.Add(new Alerta("cliente@gmail.ag", "Fatura", "Pague o boleto.", motorEmail));
        fila.Add(new Alerta("31999999999", "", "Seu token é 123.", motorSms));

        foreach (Alerta item in fila)
        {
            item.Enviar();
        }
    }
}
