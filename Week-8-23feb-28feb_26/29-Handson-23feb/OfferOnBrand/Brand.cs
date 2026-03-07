using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfferOnBrand
{
        public class Model
        {
            public string ModelName { get; set; }
            public int CarSpeed { get; set; }
        }

        public class Implementation
        {
            public List<string> GetModelName(List<Model> models)
            {
                return models.Select(m => m.ModelName).ToList();
            }

            public Model GetModelInfo(List<Model> models, string name, int speed)
            {
                return models
                    .Where(m => m.ModelName == name && m.CarSpeed == speed)
                    .FirstOrDefault();
            }
        }
    }
}
