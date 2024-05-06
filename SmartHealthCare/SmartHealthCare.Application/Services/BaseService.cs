using AutoMapper;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public abstract class BaseService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
{
    protected readonly IUnitOfWork UnitOfWork = unitOfWork;
    protected readonly IMapper Mapper = mapper;
    protected readonly ICurrentUser CurrentUser = currentUser;
}
