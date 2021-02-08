using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.ApplicationService.Common
{
    public abstract class IServiceResult<TData>
    {
        public abstract TData Data { get; set; }
        public abstract string ErrorMessage { get; set; }
        public abstract bool IsSuccess { get; set; }

        public abstract IServiceResult<TData> Ok(TData data);
        public abstract IServiceResult<TData> Fail(string errorMessage);

    }
}
