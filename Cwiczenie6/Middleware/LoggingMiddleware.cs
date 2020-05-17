using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie6.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
    }
}
