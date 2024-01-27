using AkarSoftware.Parking.DataAccess.EntityFramework.Abstract;
using AutoMapper;

namespace AkarSoftware.Parking.Business.Abstract
{
    public abstract class BaseManager
    {
        protected readonly IMapper mapper;
        protected readonly IUnitOfWork unitOfWork;
        public BaseManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

    }
}
