using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_Management.Infrastructure
{
    public interface IUnitOfWork
    {
        void UploadImageAsync(IFormFile file);
    }
}
