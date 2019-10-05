using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public abstract class QuestionBaseModel
    {
        public string Question { get; set; }

        public abstract string QuestionType { get; }
    }
}
