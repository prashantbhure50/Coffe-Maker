using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMaker
{
    public interface IMakeACoffee
    {
        bool CheckIngredientAvailability();
        string CoffeeMaking(int sugerPerSpoon, int CoffeePack);
    }

}
