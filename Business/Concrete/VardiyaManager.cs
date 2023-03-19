using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class VardiyaManager : IVardiyaService
    {
        IVardiyaDal _vardiyaDal;
        public VardiyaManager(IVardiyaDal vardiyaDal)
        {
            _vardiyaDal = vardiyaDal;
        }

        public IResult Add(Vardiya vardiya)
        {
            _vardiyaDal.Add(vardiya);
            return new SuccessResult();
        }
    }
}