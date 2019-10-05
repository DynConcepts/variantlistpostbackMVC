using System;
using System.Collections.Generic;

namespace DynConSurveys.Models
{
    public class SurveyDefinitionModel
    {
        public SurveyDefinitionModel()
        { }


        public SurveyDefinitionModel(int id, string title)
        {
            Id = id;
            Title = title;
            Questions.Add(new QuestionMultipleRadioModel());
            Questions.Add(new QuestionMultipleRadioModel());
            Questions.Add(new QuestionMultipleCheckBoxModel());
            Questions.Add(new QuestionMultipleCheckBoxModel());
        }
        public int Id { get; set; }
        public String Title { get; set; }
        public List<QuestionBaseModel> Questions { get; set; } = new List<QuestionBaseModel>();

    }
}
