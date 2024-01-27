namespace AkarSoftware.Parking.MVC
{
    public class Middleware2
    {
        private readonly RequestDelegate _requestDelegate;
        public Middleware2(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {

            _requestDelegate.Invoke(context);


        }
    }
}
