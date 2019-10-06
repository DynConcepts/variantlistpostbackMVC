using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public class QuestionTextFieldModel : QuestionBaseModel
    {
        public string Answer { get; set; }

        public override string QuestionType => "QuestionTextFieldModel";
    }
}
