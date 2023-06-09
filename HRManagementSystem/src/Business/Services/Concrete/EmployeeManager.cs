using AutoMapper;
using HRManagementSystem.Business.DTO_s.EmployeeDto_s;
using HRManagementSystem.Business.Services.Abstract;
using HRManagementSystem.Data.Entities;
using WebApp.Repositories.Abstract;

namespace HRManagementSystem.Business.Services.Concrete;

public class EmployeeManager : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EmployeeManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Create(EmployeePostDto employeePostDto)
    {
        if (employeePostDto == null) throw new Exception("Error");
        await _unitOfWork.EmployeeRepository.Create(_mapper.Map<Employee>(employeePostDto));
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<EmployeeGetDto> Get(int id)
    {
        return _mapper.Map<EmployeeGetDto>(await _unitOfWork.EmployeeRepository.GetAsync(x => x.Id == id));
    }

    public async Task<List<EmployeeGetDto>> GetAll()
    {
        return _mapper.Map<List<EmployeeGetDto>>(await _unitOfWork.EmployeeRepository.GetAllAsync(x => !x.IsDeleted));
    }

    public async Task Remove(Employee employee)
    {
        var emp = await _unitOfWork.EmployeeRepository.GetAsync(x => x.Id == employee.Id);
        emp.IsDeleted = true;
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task Update(Employee employee)
    {
        var emp = await Get(employee.Id);
        _unitOfWork.EmployeeRepository.Update(_mapper.Map<Employee>(emp));
        await _unitOfWork.SaveChangesAsync();
    }
}
