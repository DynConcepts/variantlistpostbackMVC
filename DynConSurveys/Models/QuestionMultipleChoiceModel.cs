using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public class ChoiceList
    {
        public string this[string index]
        {
            get { return "You want an " + index; }
        }
    }

    public abstract class QuestionMultipleChoiceModel : QuestionBaseModel
    {

        public ChoiceList Choices { get; } = new ChoiceList();

     }
}
