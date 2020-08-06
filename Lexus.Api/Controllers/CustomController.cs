using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lexus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CustomController : ControllerBase
    {
        public readonly ICollection<string> errors = new List<string>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (this.IsOperationValid())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]> {
                { "Messages", this.errors.ToArray() }
            }));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in errors)
            {
                this.AddError(error.ErrorMessage);
            }

            return this.CustomResponse();
        }

        protected void AddError(string errorMessage)
        {
            this.errors.Add(errorMessage);
        }

        protected bool IsOperationValid()
        {
            return !this.errors.Any();
        }

    }
}