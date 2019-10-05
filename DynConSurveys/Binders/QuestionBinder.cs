using DynConSurveys.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Binders
{
    public class QuestionBinder : IModelBinder
    {
        public QuestionBinder()
        {
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.ModelName + ".ModelType";

            // Try to fetch the value of the argument by name
            var valueProviderResult =
                bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(modelName,
                valueProviderResult);

            var value = valueProviderResult.FirstValue;

            // Check if the argument value is null or empty
            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            //////int id = 0;
            //////if (!int.TryParse(value, out id))
            //////{
            //////    // Non-integer arguments result in model state errors
            //////    bindingContext.ModelState.TryAddModelError(
            //////                            modelName,
            //////                            "Author Id must be an integer.");
            //////    return Task.CompletedTask;
            //////}

            var modelType = Type.GetType(value);
            var modelInstance = Activator.CreateInstance(modelType);

            bindingContext.Result = ModelBindingResult.Success(modelInstance);
            return Task.CompletedTask;
        }
    }
}
