using System.Collections.Generic;

namespace _Command._Alexa
{
    public class AlexaAI
    {
        private Dictionary<string, List<string>> associations;

        public AlexaAI()
        {
            associations = new Dictionary<string, List<string>>();
        }

        public void AddAssociation(string key, List<string> association)
        {
            associations.Add(key, association);
        }

        public string GetFindAssociations(string request)
        {
            var keywords = request.Split(' ');

            foreach (var association in associations)
            {
                int count = 0;

                for (int i = 0; i < association.Value.Count; i++)
                {
                    foreach (var keyword in keywords)
                    {
                        if (keyword.ToLower() == association.Value[i].ToLower())
                            count += 1;
                    }                   
                }

                if (count == 3)
                {
                    return association.Key;
                }
            }

            return null;
        }
    }
}