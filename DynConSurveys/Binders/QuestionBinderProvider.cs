using DynConSurveys.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Binders
{
    public class QuestionBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(QuestionBaseModel))
            {
                return new QuestionBinder();
            }
            //if (context.Metadata.ModelType == typeof(SurveyDefinitionModel))
            //{
            //    return new SurveyDefinitionBinder();
            //}

            return null;
        }
    }
}