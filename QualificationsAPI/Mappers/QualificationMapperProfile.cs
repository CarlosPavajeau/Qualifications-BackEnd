using AutoMapper;
using QualificationsAPI.Model;
using QualificationsAPI.Model.ViewModel.Activity;
using QualificationsAPI.Model.ViewModel.Qualification;
using QualificationsAPI.Model.ViewModel.Subject;

namespace QualificationsAPI.Mappers
{
    public class QualificationMapperProfile : Profile
    {
        public QualificationMapperProfile()
        {
            CreateMap<SubjectInputModel, Subject>();
            CreateMap<SubjectEditModel, Subject>();
            CreateMap<Subject, SubjectViewModel>();

            CreateMap<Qualification, QualificationViewModel>();

            CreateMap<ActivityInputModel, Activity>();
            CreateMap<ActivityEditModel, Activity>();
            CreateMap<Activity, ActivityViewModel>();
        }
    }
}
