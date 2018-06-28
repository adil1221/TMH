using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMH.Api.Models
{
    public class ValidationResultModel
    {
        public string Message { get; }

        public List<ValidationError> Errors { get; }

        public ValidationResultModel(ModelStateDictionary modelState)
        {
            this.Message = "Validation Failed";
            this.Errors = modelState.Keys
                    .SelectMany(key => modelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                    .ToList();
        }

        public ValidationResultModel(Exception ex)
        {
            this.Message = "Failed";

            var listOfExceptionMessage = new List<ValidationError>();
            Exception currentException = ex;
            while (currentException != null)
            {
                listOfExceptionMessage.Add(new ValidationError("", currentException.Message));
                currentException = currentException.InnerException;
            }
            this.Errors = listOfExceptionMessage;
        }
    }
}
