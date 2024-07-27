using Microsoft.AspNetCore.Mvc;
using Proyecto_LaGranSiete.BD.Data;

namespace Proyecto_LaGranSiete.Server.Controllers
{
    public class ReservasControllers : ControllerBase
    {
        private readonly Context context;

        public ReservasControllers(Context Context)
        {
            context = Context;
        }
    }
}
