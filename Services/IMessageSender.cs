using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;
        public MessageMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, MessageService messageService)
        {
            await context.Response.WriteAsync(messageService.Send());
        }
    }

    public class MessageService
    {
        IMessageSender _sender;
        public MessageService(IMessageSender sender)
        {
            _sender = sender;
        }
        public string Send()
        {
            return _sender.Send();
        }

    }

    public interface IMessageSender
    {
        string Send();
    }
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send by Email";
        }
    }
    public class SMSMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send by SMS";
        }
    }

}
