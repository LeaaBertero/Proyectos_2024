namespace Proyecto_LaGranSiete.Client.Servicios
{
    public class HTTPRespuesta<T>
    {
        public T Respuesta { get; }
        public bool Error { get; } 
        //informacion que viene del cliente y el server
        public HttpResponseMessage HttpResponseMessage { get; set; }
        
        
        public HTTPRespuesta(T respuesta, bool error, HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        


    }
}
