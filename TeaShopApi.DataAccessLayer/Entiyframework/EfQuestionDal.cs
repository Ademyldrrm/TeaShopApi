using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Concrete;
using TeaShopApi.DataAccessLayer.Context;
using TeaShopApi.EntiyLayer.Concrete;

namespace TeaShopApi.DataAccessLayer.Entiyframework
{
	public class EfQuestionDal : GenericRepository<Question>, IQuestionDal
	{
		public EfQuestionDal(TeaContext context) : base(context)
		{
		}
	}
}
