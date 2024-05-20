using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    struct UserInput
    {
        public TypeOil OilType;

        public double BuySumOfOil;
        public readonly double BuySumOfCofe =>   CountHotDog * Settings.hotDogPrice
                                                + CountFrenchFry * Settings.frenchFriesPrice
                                                + CountBurger * Settings.hamburgerPrice
                                                + CountCocaCola * Settings.cocaColaPrice;


        public int CountHotDog = 0;
        public int CountFrenchFry = 0;
        public int CountBurger = 0;
        public int CountCocaCola = 0;
        public readonly double TotalBuySum { get => BuySumOfCofe + BuySumOfOil; }

        public UserInput()
        {
        }
    }
}
