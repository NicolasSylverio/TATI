namespace Proeficiencia.CrossCutting.Models
{
    /// <summary>
    ///     Objeto para retornar uma bag de validação.
    /// </summary>
    /// <typeparam name="T">Objeto Generico de retorno</typeparam>
    public class ResponseBag<T>
    {
        public bool IsOk { get; set; }
        public string Mensagem { get; set; }
        public T ObjetoRetorno { get; set; }
    }
}