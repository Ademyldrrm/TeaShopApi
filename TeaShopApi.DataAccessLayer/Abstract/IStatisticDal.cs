using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DataAccessLayer.Abstract
{
    public interface IStatisticDal
    {
        int DrinkCount();
        decimal DrinkAvargePrice();
        string LastDrinkName();
        string MaxPriceDrink();
        int QuestionCount();
        int TestimonialCount();
        int MessageCount();
        string LastMessage();
    }
}
