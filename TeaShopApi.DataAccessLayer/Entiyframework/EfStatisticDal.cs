using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Context;

namespace TeaShopApi.DataAccessLayer.Entiyframework
{
    public class EfStatisticDal : IStatisticDal
    {
        private readonly TeaContext _context;

        public EfStatisticDal(TeaContext context)
        {
            _context = context;
        }

        public decimal DrinkAvargePrice()
        {
            decimal value = _context.Drinks.Average(x=>x.DrinkPrice);
            return value;
        }

        public int DrinkCount()
        {
            int value=_context.Drinks.Count();  
            return value;
        }

        public string LastDrinkName()
        {
           string value=_context.Drinks.OrderByDescending(x=>x.DrinkID).Select(y=>y.DrinkName).Take(3).FirstOrDefault();
            return value;
        }

        public string LastMessage()
        {
           string values=_context.Messages.OrderByDescending(x=>x.MessageID).Select(y=>y.MessageSubject).Take(1).FirstOrDefault();
            return values;
        }

        public string MaxPriceDrink()
        {
            decimal price=_context.Drinks.Max(x=>x.DrinkPrice);
            string value=_context.Drinks.Where(x=>x.DrinkPrice==price).Select(y=>y.DrinkName).FirstOrDefault();
            return value;
        }

        public int MessageCount()
        {
            int value= _context.Messages.Count();
            return value;
        }

        public int QuestionCount()
        {
            var values = _context.Questions.Count();
            return values;
        }

        public int TestimonialCount()
        {
            var values = _context.Testimonials.Count();
            return values;
        }
    }
}
