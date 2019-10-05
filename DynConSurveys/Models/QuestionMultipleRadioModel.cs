using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public class QuestionMultipleRadioModel : QuestionMultipleChoiceModel
    {
        public override string QuestionType => "QuestionMultipleRadio";

        public string Selection { get; set; }
    }
}
