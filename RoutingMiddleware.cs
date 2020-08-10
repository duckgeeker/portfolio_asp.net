using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
{
    public class RoutingMiddleware
    {

        private readonly RequestDelegate _next;
        public RoutingMiddleware(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if ( path == "/main" || path == "/index" )
            {
                await context.Response.WriteAsync("Home page");
            }
            else if ( path == "/portfolio" )
            {
                await context.Response.WriteAsync("This is portfolio");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }

    }
}
