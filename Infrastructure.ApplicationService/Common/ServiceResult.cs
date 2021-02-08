using Core.Abstraction.ApplicationService.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.ApplicationService.Common
{
    public class ServiceResult<TData> : IServiceResult<TData>
    {
        public override TData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool IsSuccess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override IServiceResult<TData> Fail(string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsSuccess = false;
            return this;
        }

        public override IServiceResult<TData> Ok(TData data)
        {
            Data = data;
            IsSuccess = true;
            return this;
        }
    }
}
