using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BidManager : IBidService
	{
		IBidDal _bidDal;

		public BidManager(IBidDal bidDal)
		{
			_bidDal = bidDal;
		}

		public void Add(Bid entity)
		{
			_bidDal.Insert(entity);
		}

		public void Delete(Bid entity)
		{
			_bidDal.Delete(entity);
		}

		public Bid GetById(int id)
		{
			return new Bid();
		}

		public List<Bid> GetList()
		{
			return _bidDal.GetList();
		}

		public void Update(Bid entity)
		{
			_bidDal.Update(entity);
		}
	}
}
