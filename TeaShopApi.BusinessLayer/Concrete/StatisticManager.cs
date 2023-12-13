using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public decimal TDrinkAvargePrice()
        {
           return _statisticDal.DrinkAvargePrice();
            
        }

        public int TDrinkCount()
        {
            return _statisticDal.DrinkCount();
        }

        public string TLastDrinkName()
        {
          return  _statisticDal.LastDrinkName();
        }

        public string TLastMessage()
        {
            return _statisticDal.LastMessage();
        }

        public string TMaxPriceDrink()
        {
            return _statisticDal.MaxPriceDrink();
        }

        public int TMessageCount()
        {
           return _statisticDal.MessageCount();
        }

        public int TQuestionCount()
        {
            return _statisticDal.QuestionCount();
        }

        public int TTestimonialCount()
        {
           return _statisticDal.TestimonialCount();
        }
    }
}
