using Newtonsoft.Json;

namespace WebApplication1.Domain
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ErrorDetails(int _status)
        {
            StatusCode = _status;
            Message = GetDefaultMessage(_status);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        private string GetDefaultMessage(int statusCode)
        {
            string v = statusCode switch
            {
                400 => "Has realizado una petición incorrecta.",
                401 => "Usuario no autorizado.",
                404 => "El recurso que has intentado solicitar no existe.",
                405 => "Este método HTTP no está permitido en el servidor.",
                500 => "Error en el servidor. No eres tú, soy yo. Comunícate con el administrador XD.",
                0 => "Error no controlado en el servidor. No eres tú, soy yo. Comunícate con el administrador XD.",
                _ => "Error no controlado",
            };
            return v;
        }
    }

}