using DynConSurveys.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Binders
{
    public class SurveyDefinitionBinder : IModelBinder
    {
        public SurveyDefinitionBinder()
        {
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelType = bindingContext.ModelType;
            var modelInstance = Activator.CreateInstance(modelType);

            bindingContext.Result = ModelBindingResult.Success(modelInstance);
            return Task.CompletedTask;

        }
    }
}
