using AutoMapper;
using AutoMapper.QueryableExtensions;
using SmartHealthCare.Application.Common.Extensions;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Common.Models;
using SmartHealthCare.Application.ViewModels.FeedBack;
using SmartHealthCare.Application.ViewModels.Medicine;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Exceptions;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;

namespace SmartHealthCare.Application.Services;

public class FeedBackService(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IFeedBackRepository feedBackRepository,
    IRepositoryBase<Student> studentRepository) : BaseService(unitOfWork, mapper, currentUser)
{
    public async Task<PaginatedList<FeedBackResponse>> GetAllFeedBacksAsync(GetFeedBackRequest request)
    {
        var result = await feedBackRepository.Search(request.Search)
            .OrderBy(GetOrderByField(request.SortBy), request.IsDescending)
            .ProjectTo<FeedBackResponse>(Mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
        return result;
    }

    public async Task CreateFeedBackByStudentAsync(int studentId, AddFeedBackRequest request)
    {
        bool studentExists = await studentRepository.AnyAsync(studentId);
        if (studentExists)
        {
            var feedBack = new FeedBack
            {
                StudentId = studentId,
                Rating = request.Rating,
                Comments = request.Comments,
                CommentDate = DateTime.Today
            };
            feedBackRepository.Add(feedBack);
            await unitOfWork.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentException("StudentId doesn't exist");
        }
    }
    public async Task AdminResponseFeedBackAsync(int feedBackId, UpsertFeedBackRequest request)
    {
        var feedBack = await feedBackRepository.GetByIdAsync(feedBackId);
        if (feedBack == null)
            throw new NotFoundException(nameof(FeedBack), feedBackId.ToString());
        feedBack.Response = request.Response;
        feedBack.ResponseDate = DateTime.Today;
        feedBackRepository.Update(feedBack);
        await UnitOfWork.SaveChangesAsync();
    }
    private static IOrderByField GetOrderByField(FeedBackSortByOption? option)
    {
        return option switch
        {
            FeedBackSortByOption.Id
                => new OrderByField<FeedBack, int>(x => x.Id),
            FeedBackSortByOption.Rating
                => new OrderByField<FeedBack, float>(x => x.Rating),
            FeedBackSortByOption.CommentDate
                => new OrderByField<FeedBack, DateTime>(fb => fb.CommentDate),
            _ => throw new ArgumentOutOfRangeException(nameof(option), option, null)
        };
    }
}