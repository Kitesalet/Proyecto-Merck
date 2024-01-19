using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.Interfaces
{
    public interface IEmailSendeer
    {
        public Task<bool> EmailAsync(string email, string subject, string htmlMessage);
    }
}