using DutiesAllocation.Entities.Dto;
using DutiesAllocationApp.Entities;

namespace DutiesAllocationApp.Services.Contracts
{
    public interface IStudentService
    {
        void Create(StudentDto request);
        void GetAll();
        void Update(int id, UpdateStudentDto updateStudentDto);
        void Delete(int id);
        void PrintListView(Student student);
        void PrintDetailView(Student student);
        void GetAStudent(int viewId);

       
    }
}