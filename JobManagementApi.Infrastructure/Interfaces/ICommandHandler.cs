using JobManagementApi.Infrastructure.Commands;
using JobManagementApi.Infrastructure.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementApi.Infrastructure.Interfaces
{
    public interface ICommandHandler<TResult, TCommand>
        where TResult : Response<Entity>
        where TCommand : Command
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        Task<TResult> HandleAsync(TCommand command, ILogger logger);
    }
}
