using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynConSurveys.Models
{
    public class AvailableSurveyModel
    {
        public AvailableSurveyModel()
        {
            Definitions.Add(new SurveyDefinitionModel(1, "Survey A"));
            Definitions.Add(new SurveyDefinitionModel(2, "Survey B"));
            Definitions.Add(new SurveyDefinitionModel(3, "Survey C"));
            Definitions.Add(new SurveyDefinitionModel(4, "Survey D"));
        }

        internal SurveyDefinitionModel FindById(int id)
        {
            foreach (var definition in Definitions)
            {
                if (definition.Id == id)
                    return definition;
            }
            return null;
        }

        public List<SurveyDefinitionModel> Definitions { get; } = new List<SurveyDefinitionModel>();
    }
}
