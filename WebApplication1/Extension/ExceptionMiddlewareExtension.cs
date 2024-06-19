
public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError => {
                appError.Run(async conext =>
                {
                    conext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    conext.Response.ContentType = "application/json";

                    var contextFeature = conext.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {

                        // error.Message "Hola ";
                        await conext.Response.WriteAsync(JsonConvert.SerializeObject(new ErrorDetails(conext.Response.StatusCode)));
                    }
                });
            });
        }
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {

            app.UseMiddleware(typeof(RequestResponseLoggingMiddleware));
            //app.UseMiddleware<RequestResponseLoggingMiddleware>();
        }

    }
