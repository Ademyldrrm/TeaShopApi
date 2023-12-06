using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int TDrinkCount();
        decimal TDrinkAvargePrice();
        string TLastDrinkName();
        string TMaxPriceDrink();
    }
}
