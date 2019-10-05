using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public class QuestionMultipleCheckBoxModel : QuestionMultipleChoiceModel
    {
        public override string QuestionType => "QuestionMultipleCheckBox";

        public bool Choice_A { get; set; }
        public bool Choice_B { get; set; }
        public bool Choice_C { get; set; }
        public bool Choice_D { get; set; }
    }
}
