using System.Web.Http;

namespace HelloAlexa
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //route using RouteAttributes set on controllers/actions
            config.MapHttpAttributeRoutes();
        }
    }
}
