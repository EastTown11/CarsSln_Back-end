using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class HrEmployee
    {
        public HrEmployee()
        {
            Users = new HashSet<User>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoto { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeTelephones { get; set; }
        public byte? EmployeeSexType { get; set; }
        public DateTime? EmployeeBirthDate { get; set; }
        public string IdentityCardNo { get; set; }
        public int? IdentityCardTypeId { get; set; }
        public DateTime? IdentityCardDate { get; set; }
        public string IdentityCardPlace { get; set; }
        public int? SocialStatusTypeId { get; set; }
        public int? ChildrenNo { get; set; }
        public byte? DutyPositionType { get; set; }
        public DateTime? OutDutyDate { get; set; }
        public string OutDutyReason { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public byte? ContractType { get; set; }
        public string ContractNo { get; set; }
        public int? DepId { get; set; }
        public int? CategoryId { get; set; }
        public string WorkOfficeRegistration { get; set; }
        public DateTime? WorkOfficeRegDate { get; set; }
        public string SocialSecurityNo { get; set; }
        public byte? EmployeeHireType { get; set; }
        public string EmployeeNotes { get; set; }
        public int? BankId { get; set; }
        public string BankAccount { get; set; }
        public int? ProjectId { get; set; }
        public int? ReligionId { get; set; }
        public int? NationalityId { get; set; }
        public string ResidenceNo { get; set; }
        public string ResidenceIssuePlace { get; set; }
        public DateTime? ResidenceStartDate { get; set; }
        public DateTime? ResidenceEndDate { get; set; }
        public string PassportNo { get; set; }
        public string PassportIssuePlace { get; set; }
        public DateTime? PassportStartDate { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public string DriveLicenseNo { get; set; }
        public string DriveLicenseIssuePlace { get; set; }
        public DateTime? DriveLicenseStartDate { get; set; }
        public DateTime? DriveLicenseEndDate { get; set; }
        public byte? DocSalaryType { get; set; }
        public float? DocSalaryValue { get; set; }
        public string EmployeeMoble { get; set; }
        public string Email { get; set; }
        public string BusinessCardNo { get; set; }
        public DateTime? BusinessEndDate { get; set; }
        public string PersonalNo { get; set; }
        public string PersonalId { get; set; }
        public string Validity { get; set; }
        public string HealthcardNo { get; set; }
        public string HealthId { get; set; }
        public DateTime? HealthEndDate { get; set; }
        public string Qualification { get; set; }
        public byte? CheckFinger { get; set; }
        public byte? IsWork { get; set; }
        public DateTime? DateEndContract { get; set; }
        public string ExperianceNo { get; set; }
        public string ExPerianceHist { get; set; }
        public string NameEmpByenglish { get; set; }
        public byte? PayedTypeSalary { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
