﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationWeb.Client.RegistrationServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RegistrationServiceReference.IRegistrationService")]
    public interface IRegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetCoursesResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetCoursesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPeople", ReplyAction="http://tempuri.org/IRegistrationService/GetPeopleResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPeople", ReplyAction="http://tempuri.org/IRegistrationService/GetPeopleResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetPeopleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPersonTypes", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonTypesResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO[] GetPersonTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPersonTypes", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonTypesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO[]> GetPersonTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetSchedules", ReplyAction="http://tempuri.org/IRegistrationService/GetSchedulesResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO[] GetSchedules();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetSchedules", ReplyAction="http://tempuri.org/IRegistrationService/GetSchedulesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO[]> GetSchedulesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetCourse", ReplyAction="http://tempuri.org/IRegistrationService/GetCourseResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO GetCourse(int cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetCourse", ReplyAction="http://tempuri.org/IRegistrationService/GetCourseResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO> GetCourseAsync(int cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPerson", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO GetPerson(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPerson", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO> GetPersonAsync(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPersonType", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonTypeResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO GetPersonType(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetPersonType", ReplyAction="http://tempuri.org/IRegistrationService/GetPersonTypeResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO> GetPersonTypeAsync(int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetSchedule", ReplyAction="http://tempuri.org/IRegistrationService/GetScheduleResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO GetSchedule(int cid, int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetSchedule", ReplyAction="http://tempuri.org/IRegistrationService/GetScheduleResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO> GetScheduleAsync(int cid, int pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllFullCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetAllFullCoursesResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetAllFullCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllFullCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetAllFullCoursesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetAllFullCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllOpenCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetAllOpenCoursesResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetAllOpenCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllOpenCourses", ReplyAction="http://tempuri.org/IRegistrationService/GetAllOpenCoursesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetAllOpenCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetEnrolledStudentsByCourse", ReplyAction="http://tempuri.org/IRegistrationService/GetEnrolledStudentsByCourseResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetEnrolledStudentsByCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetEnrolledStudentsByCourse", ReplyAction="http://tempuri.org/IRegistrationService/GetEnrolledStudentsByCourseResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetEnrolledStudentsByCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllActiveStudents", ReplyAction="http://tempuri.org/IRegistrationService/GetAllActiveStudentsResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetAllActiveStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetAllActiveStudents", ReplyAction="http://tempuri.org/IRegistrationService/GetAllActiveStudentsResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetAllActiveStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetStudentSchedule", ReplyAction="http://tempuri.org/IRegistrationService/GetStudentScheduleResponse")]
        RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetStudentSchedule(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/GetStudentSchedule", ReplyAction="http://tempuri.org/IRegistrationService/GetStudentScheduleResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetStudentScheduleAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddCourse", ReplyAction="http://tempuri.org/IRegistrationService/AddCourseResponse")]
        bool AddCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddCourse", ReplyAction="http://tempuri.org/IRegistrationService/AddCourseResponse")]
        System.Threading.Tasks.Task<bool> AddCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddPerson", ReplyAction="http://tempuri.org/IRegistrationService/AddPersonResponse")]
        bool AddPerson(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddPerson", ReplyAction="http://tempuri.org/IRegistrationService/AddPersonResponse")]
        System.Threading.Tasks.Task<bool> AddPersonAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddPersonType", ReplyAction="http://tempuri.org/IRegistrationService/AddPersonTypeResponse")]
        bool AddPersonType(RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/AddPersonType", ReplyAction="http://tempuri.org/IRegistrationService/AddPersonTypeResponse")]
        System.Threading.Tasks.Task<bool> AddPersonTypeAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RegisterCourse", ReplyAction="http://tempuri.org/IRegistrationService/RegisterCourseResponse")]
        bool RegisterCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RegisterCourse", ReplyAction="http://tempuri.org/IRegistrationService/RegisterCourseResponse")]
        System.Threading.Tasks.Task<bool> RegisterCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/CartCourse", ReplyAction="http://tempuri.org/IRegistrationService/CartCourseResponse")]
        bool CartCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/CartCourse", ReplyAction="http://tempuri.org/IRegistrationService/CartCourseResponse")]
        System.Threading.Tasks.Task<bool> CartCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/DropCourse", ReplyAction="http://tempuri.org/IRegistrationService/DropCourseResponse")]
        bool DropCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/DropCourse", ReplyAction="http://tempuri.org/IRegistrationService/DropCourseResponse")]
        System.Threading.Tasks.Task<bool> DropCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/CancelCourse", ReplyAction="http://tempuri.org/IRegistrationService/CancelCourseResponse")]
        bool CancelCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/CancelCourse", ReplyAction="http://tempuri.org/IRegistrationService/CancelCourseResponse")]
        System.Threading.Tasks.Task<bool> CancelCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/ModifyCourse", ReplyAction="http://tempuri.org/IRegistrationService/ModifyCourseResponse")]
        bool ModifyCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, int newCapacity, int newStart, int newEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/ModifyCourse", ReplyAction="http://tempuri.org/IRegistrationService/ModifyCourseResponse")]
        System.Threading.Tasks.Task<bool> ModifyCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, int newCapacity, int newStart, int newEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RemoveStudent", ReplyAction="http://tempuri.org/IRegistrationService/RemoveStudentResponse")]
        bool RemoveStudent(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RemoveStudent", ReplyAction="http://tempuri.org/IRegistrationService/RemoveStudentResponse")]
        System.Threading.Tasks.Task<bool> RemoveStudentAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO student);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistrationServiceChannel : RegistrationWeb.Client.RegistrationServiceReference.IRegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrationServiceClient : System.ServiceModel.ClientBase<RegistrationWeb.Client.RegistrationServiceReference.IRegistrationService>, RegistrationWeb.Client.RegistrationServiceReference.IRegistrationService {
        
        public RegistrationServiceClient() {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetCourses() {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetCoursesAsync() {
            return base.Channel.GetCoursesAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO[] GetPersonTypes() {
            return base.Channel.GetPersonTypes();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO[]> GetPersonTypesAsync() {
            return base.Channel.GetPersonTypesAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO[] GetSchedules() {
            return base.Channel.GetSchedules();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO[]> GetSchedulesAsync() {
            return base.Channel.GetSchedulesAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO GetCourse(int cid) {
            return base.Channel.GetCourse(cid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO> GetCourseAsync(int cid) {
            return base.Channel.GetCourseAsync(cid);
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO GetPerson(int pid) {
            return base.Channel.GetPerson(pid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO> GetPersonAsync(int pid) {
            return base.Channel.GetPersonAsync(pid);
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO GetPersonType(int pid) {
            return base.Channel.GetPersonType(pid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO> GetPersonTypeAsync(int pid) {
            return base.Channel.GetPersonTypeAsync(pid);
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO GetSchedule(int cid, int pid) {
            return base.Channel.GetSchedule(cid, pid);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.ScheduleDAO> GetScheduleAsync(int cid, int pid) {
            return base.Channel.GetScheduleAsync(cid, pid);
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetAllFullCourses() {
            return base.Channel.GetAllFullCourses();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetAllFullCoursesAsync() {
            return base.Channel.GetAllFullCoursesAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetAllOpenCourses() {
            return base.Channel.GetAllOpenCourses();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetAllOpenCoursesAsync() {
            return base.Channel.GetAllOpenCoursesAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetEnrolledStudentsByCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.GetEnrolledStudentsByCourse(course);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetEnrolledStudentsByCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.GetEnrolledStudentsByCourseAsync(course);
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[] GetAllActiveStudents() {
            return base.Channel.GetAllActiveStudents();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO[]> GetAllActiveStudentsAsync() {
            return base.Channel.GetAllActiveStudentsAsync();
        }
        
        public RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[] GetStudentSchedule(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.GetStudentSchedule(person);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO[]> GetStudentScheduleAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.GetStudentScheduleAsync(person);
        }
        
        public bool AddCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.AddCourse(course);
        }
        
        public System.Threading.Tasks.Task<bool> AddCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.AddCourseAsync(course);
        }
        
        public bool AddPerson(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.AddPerson(person);
        }
        
        public System.Threading.Tasks.Task<bool> AddPersonAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.AddPersonAsync(person);
        }
        
        public bool AddPersonType(RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO personType) {
            return base.Channel.AddPersonType(personType);
        }
        
        public System.Threading.Tasks.Task<bool> AddPersonTypeAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonTypeDAO personType) {
            return base.Channel.AddPersonTypeAsync(personType);
        }
        
        public bool RegisterCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.RegisterCourse(course, person);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.RegisterCourseAsync(course, person);
        }
        
        public bool CartCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.CartCourse(course, person);
        }
        
        public System.Threading.Tasks.Task<bool> CartCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.CartCourseAsync(course, person);
        }
        
        public bool DropCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.DropCourse(course, person);
        }
        
        public System.Threading.Tasks.Task<bool> DropCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO person) {
            return base.Channel.DropCourseAsync(course, person);
        }
        
        public bool CancelCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.CancelCourse(course);
        }
        
        public System.Threading.Tasks.Task<bool> CancelCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course) {
            return base.Channel.CancelCourseAsync(course);
        }
        
        public bool ModifyCourse(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, int newCapacity, int newStart, int newEnd) {
            return base.Channel.ModifyCourse(course, newCapacity, newStart, newEnd);
        }
        
        public System.Threading.Tasks.Task<bool> ModifyCourseAsync(RegistrationWeb.Logic.RegistrationServiceReference.CourseDAO course, int newCapacity, int newStart, int newEnd) {
            return base.Channel.ModifyCourseAsync(course, newCapacity, newStart, newEnd);
        }
        
        public bool RemoveStudent(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO student) {
            return base.Channel.RemoveStudent(student);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveStudentAsync(RegistrationWeb.Logic.RegistrationServiceReference.PersonDAO student) {
            return base.Channel.RemoveStudentAsync(student);
        }
    }
}
