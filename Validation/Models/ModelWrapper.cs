using FluentValidation;
using FluentValidation.Results;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Validation.Models
{
    public class ModelWrapper : AbstractValidator<ModelWrapper>
    {
        public List<Update> Updates { get; set; }
        public List<Delete> Deletes { get; set; }
        public List<Insert> Inserts { get; set; }
    }
}