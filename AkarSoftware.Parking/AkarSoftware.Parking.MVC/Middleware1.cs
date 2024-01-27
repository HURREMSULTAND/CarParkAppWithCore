namespace AkarSoftware.Parking.MVC
{
    public class Middleware1
    {
        private readonly RequestDelegate _requestDelegate;
        public Middleware1(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString().ToUpper().Contains("/HURREM"))
            {
                context.Response.WriteAsync("Hosgeldin kral");
            }
            else
            {

                _requestDelegate.Invoke(context);


            }




        }


    }
}
