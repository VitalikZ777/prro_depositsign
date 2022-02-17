using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRROLibrary
{
    public class DepositSign
    { 
        public partial class AccountProfileModel
        {
            [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Always)]
           
            public string FirstName { get; set; }

            [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Always)]
           
            public string LastName { get; set; }

            [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string MiddleName { get; set; }

            [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Email { get; set; }

            [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Always)]
           
            public string PhoneNumber { get; set; }

            [Newtonsoft.Json.JsonProperty("TwoFactorEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool TwoFactorEnabled { get; set; }

            [Newtonsoft.Json.JsonProperty("OtpApplicationType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public OtpApplicationType OtpApplicationType { get; set; }

        }

        /// <summary>ChangePasswordModel</summary>
        
        public partial class ChangePasswordModel
        {
            /// <summary>OldPassword</summary>
            [Newtonsoft.Json.JsonProperty("OldPassword", Required = Newtonsoft.Json.Required.Always)]
          
            public string OldPassword { get; set; }

            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
          
            public string Password { get; set; }


        }

       
        public partial class AuthorizationRequestModel
        {
            /// <summary>UserName (phone number)</summary>
            [Newtonsoft.Json.JsonProperty("UserName", Required = Newtonsoft.Json.Required.Always)]
         
            public string UserName { get; set; }

            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
         
            public string Password { get; set; }


        }

       
        public enum OtpApplicationType
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

            _3 = 3,

        }

        /// <summary>CertificateInformationModel</summary>
      
        public partial class CertificateInformationModel
        {
            /// <summary>ExpireDate</summary>
            [Newtonsoft.Json.JsonProperty("ExpireDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset ExpireDate { get; set; }

            /// <summary>StartDate</summary>
            [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset StartDate { get; set; }

            /// <summary>CertificateBinary</summary>
            [Newtonsoft.Json.JsonProperty("CertificateBinary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] CertificateBinary { get; set; }

            /// <summary>KeyUsage</summary>
            [Newtonsoft.Json.JsonProperty("KeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyUsage { get; set; }

            /// <summary>Thumbprint</summary>
            [Newtonsoft.Json.JsonProperty("Thumbprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Thumbprint { get; set; }

            /// <summary>Edrpou</summary>
            [Newtonsoft.Json.JsonProperty("Edrpou", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Edrpou { get; set; }

            /// <summary>Drfo</summary>
            [Newtonsoft.Json.JsonProperty("Drfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Drfo { get; set; }

            /// <summary>FullName</summary>
            [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string FullName { get; set; }

            /// <summary>OrgUnit</summary>
            [Newtonsoft.Json.JsonProperty("OrgUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string OrgUnit { get; set; }

            /// <summary>Org</summary>
            [Newtonsoft.Json.JsonProperty("Org", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Org { get; set; }

            /// <summary>Address</summary>
            [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Address { get; set; }

            /// <summary>Phone</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Phone { get; set; }

            /// <summary>EMail</summary>
            [Newtonsoft.Json.JsonProperty("EMail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string EMail { get; set; }

            /// <summary>SubjectTitle</summary>
            [Newtonsoft.Json.JsonProperty("SubjectTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SubjectTitle { get; set; }

            /// <summary>Issuer</summary>
            [Newtonsoft.Json.JsonProperty("Issuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Issuer { get; set; }

            /// <summary>Issuer CN</summary>
            [Newtonsoft.Json.JsonProperty("IssuerCN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IssuerCN { get; set; }

            /// <summary>Serial number</summary>
            [Newtonsoft.Json.JsonProperty("Serial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Serial { get; set; }

            /// <summary>Ext. key usage</summary>
            [Newtonsoft.Json.JsonProperty("ExtKeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ExtKeyUsage { get; set; }

            /// <summary>Upn</summary>
            [Newtonsoft.Json.JsonProperty("Upn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Upn { get; set; }

            /// <summary>PowerCert</summary>
            [Newtonsoft.Json.JsonProperty("PowerCert", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PowerCert { get; set; }

            /// <summary>QSCD</summary>
            [Newtonsoft.Json.JsonProperty("QSCD", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool QSCD { get; set; }


        }

        /// <summary>TokenResponseKeyInfoModel</summary>
        
        public partial class TokenResponseKeyInfoModel
        {
            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyName { get; set; }

            /// <summary>IsRegistrationAdministratorKey</summary>
            [Newtonsoft.Json.JsonProperty("IsRegistrationAdministratorKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool? IsRegistrationAdministratorKey { get; set; }

            /// <summary>IsVerifierKey</summary>
            [Newtonsoft.Json.JsonProperty("IsVerifierKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool? IsVerifierKey { get; set; }

            /// <summary>CertificatesInformation</summary>
            [Newtonsoft.Json.JsonProperty("CertificatesInformation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public List<CertificateInformationModel> CertificatesInformation { get; set; }


        }

        /// <summary>TokenResponseModel</summary>
      
        public partial class TokenResponseModel
        {
            /// <summary>Token</summary>
            [Newtonsoft.Json.JsonProperty("Token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Token { get; set; }

            /// <summary>KeysInfo</summary>
            [Newtonsoft.Json.JsonProperty("KeysInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<TokenResponseKeyInfoModel> KeysInfo { get; set; }


        }

        /// <summary>ClientExceptionCode</summary>
       
        public enum ClientExceptionCode
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

            _5 = 5,

        }

        /// <summary>ClientExceptionDetailCode</summary>
       
        public enum ClientExceptionDetailCode
        {
            _0 = 0,

            _1001 = 1001,

            _1002 = 1002,

            _1003 = 1003,

            _1004 = 1004,

            _1005 = 1005,

            _1006 = 1006,

            _1007 = 1007,

            _1008 = 1008,

            _1009 = 1009,

            _1050 = 1050,

            _1101 = 1101,

            _1102 = 1102,

            _1103 = 1103,

            _2001 = 2001,

            _2002 = 2002,

            _3001 = 3001,

            _4001 = 4001,

            _5001 = 5001,

            _6001 = 6001,

            _6002 = 6002,

            _6003 = 6003,

            _6004 = 6004,

            _6005 = 6005,

            _6006 = 6006,

            _7001 = 7001,

        }

        /// <summary>Error</summary>
       
        public partial class ResponseErrorModel
        {
            [Newtonsoft.Json.JsonProperty("Code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ClientExceptionCode Code { get; set; }

            /// <summary>ErrorCodeNumber</summary>
            [Newtonsoft.Json.JsonProperty("CodeNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public int CodeNumber { get; set; }

            [Newtonsoft.Json.JsonProperty("DetailCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ClientExceptionDetailCode DetailCode { get; set; }

            /// <summary>ErrorDetailCodeNumber</summary>
            [Newtonsoft.Json.JsonProperty("DetailCodeNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public int DetailCodeNumber { get; set; }

            /// <summary>Message</summary>
            [Newtonsoft.Json.JsonProperty("Message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Message { get; set; }

            /// <summary>Source</summary>
            [Newtonsoft.Json.JsonProperty("Source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Source { get; set; }


        }

       
        public partial class BankContractorCheck
        {
            [Newtonsoft.Json.JsonProperty("HelsiUserId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid HelsiUserId { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid ApplicationId { get; set; }

            [Newtonsoft.Json.JsonProperty("CounterPartyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid CounterPartyId { get; set; }

            [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Status { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicationStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ApplicationStatus { get; set; }


        }

        
        public partial class FileData
        {
            [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] Data { get; set; }

            [Newtonsoft.Json.JsonProperty("FileName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string FileName { get; set; }

            [Newtonsoft.Json.JsonProperty("Extension", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Extension { get; set; }


        }

        
        public partial class Passport
        {
            [Newtonsoft.Json.JsonProperty("FirstPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData FirstPage { get; set; }

            [Newtonsoft.Json.JsonProperty("SecondThirdPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData SecondThirdPage { get; set; }

            [Newtonsoft.Json.JsonProperty("FourthFifthPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData FourthFifthPage { get; set; }

            [Newtonsoft.Json.JsonProperty("SixthSeventhPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData SixthSeventhPage { get; set; }


        }

       
        public partial class IdCard
        {
            [Newtonsoft.Json.JsonProperty("FrontSide", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData FrontSide { get; set; }

            [Newtonsoft.Json.JsonProperty("BackSide", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData BackSide { get; set; }


        }

       
        public partial class InternationalPassport
        {
            [Newtonsoft.Json.JsonProperty("FirstPage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData FirstPage { get; set; }


        }

        /// <summary>Тип документа, що посвідчує особу: 1 - Паспорт, 2 - ID картка, 3 - Закордонний паспорт, 4 - Водійське посвідчення, 5 - Посвідка на проживання (тимчасове або постійне)</summary>
       
        public enum IdentificationDocumentType
        {
            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

            _5 = 5,

        }

        /// <summary>Модель завантаження та оновлення документів заяви</summary>
        
        public partial class KeyApplicationDocumentsModel
        {
            [Newtonsoft.Json.JsonProperty("Passport", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Passport Passport { get; set; }

            [Newtonsoft.Json.JsonProperty("IdCard", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public IdCard IdCard { get; set; }

            [Newtonsoft.Json.JsonProperty("DriverLicense", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData DriverLicense { get; set; }

            [Newtonsoft.Json.JsonProperty("InternationalPassport", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public InternationalPassport InternationalPassport { get; set; }

            [Newtonsoft.Json.JsonProperty("ResidencePermit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData ResidencePermit { get; set; }

            [Newtonsoft.Json.JsonProperty("TIN", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData TIN { get; set; }

            [Newtonsoft.Json.JsonProperty("EmploymentRelationship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData EmploymentRelationship { get; set; }

            [Newtonsoft.Json.JsonProperty("KeyApplicationRequest", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public FileData KeyApplicationRequest { get; set; }

            [Newtonsoft.Json.JsonProperty("AdditionalDocuments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<FileData> AdditionalDocuments { get; set; }

            [Newtonsoft.Json.JsonProperty("IdentificationDocumentType", Required = Newtonsoft.Json.Required.Always)]
            public IdentificationDocumentType IdentificationDocumentType { get; set; }

            [Newtonsoft.Json.JsonProperty("IdentificationDocumentNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IdentificationDocumentNumber { get; set; }


        }

        /// <summary>Тип заявки: 1 - Генерація файлового ключа, 2 - Генерація ключа на гряді, 3 - Відкладена генерація на гряді, 4 - Відкладена генерація файлового ключа</summary>
       
        public enum ApplicationType
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

        }

        /// <summary>Тип заявника: 1 - Фізична особа, 2 - Юридична особа</summary>
      
        public enum ApplicantType
        {
            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

        }

        /// <summary>Термін дії сертифіката: 1 - 1 рік, 2 - 2 роки</summary>
       
        public enum ValidityPeriod
        {
            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

            _5 = 5,

        }

        /// <summary>Acsk</summary>
       
        public enum Acsk
        {
            _1 = 1,

            _2 = 2,

        }

        /// <summary>Тип сертифіката: 0 - Підпис, 1 - Печатка, 2 - Печатка для РРО</summary>
       
        public enum CertificateType
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

        }

        /// <summary>KeyApplicationRequestModel</summary>
        
        public partial class KeyApplicationRequestModel
        {
            [Newtonsoft.Json.JsonProperty("ApplicationType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicationType ApplicationType { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicantType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicantType ApplicantType { get; set; }

            /// <summary>Повна назва компанії (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("CompanyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyName { get; set; }

            /// <summary>Код ЄДРПОУ компанії (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("CompanyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
           
            public string CompanyCode { get; set; }

            /// <summary>Скорочена назва компанії (якщо довжина повної назви перевищує 64 символи (для сертифікації))</summary>
            [Newtonsoft.Json.JsonProperty("CompanyShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyShortName { get; set; }

            /// <summary>RegionId</summary>
            [Newtonsoft.Json.JsonProperty("RegionId", Required = Newtonsoft.Json.Required.Always)]
            public int RegionId { get; set; }

            /// <summary>Місто (необов'язкове, якщо Область - м.Київ)</summary>
            [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string City { get; set; }

            /// <summary>Ім'я заявника</summary>
            [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Always)]
          
            public string Name { get; set; }

            /// <summary>Прізвище заявника</summary>
            [Newtonsoft.Json.JsonProperty("Surname", Required = Newtonsoft.Json.Required.Always)]
           
            public string Surname { get; set; }

            /// <summary>По-батькові заявника</summary>
            [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string MiddleName { get; set; }

            /// <summary>РНОКПП заявника</summary>
            [Newtonsoft.Json.JsonProperty("PersonalCode", Required = Newtonsoft.Json.Required.Always)]
         
            public string PersonalCode { get; set; }

            /// <summary>Посада заявника</summary>
            [Newtonsoft.Json.JsonProperty("Position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
          
            public string Position { get; set; }

            /// <summary>УНЗР</summary>
            [Newtonsoft.Json.JsonProperty("UniqueNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
          
            public string UniqueNumber { get; set; }

            /// <summary>Номер телефону заявника (також логін в кабінет)</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Always)]
        
            public string Phone { get; set; }

            /// <summary>E-mail заявника</summary>
            [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Email { get; set; }

            /// <summary>AccountPassword</summary>
            [Newtonsoft.Json.JsonProperty("AccountPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AccountPassword { get; set; }

            [Newtonsoft.Json.JsonProperty("ValidityPeriod", Required = Newtonsoft.Json.Required.Always)]
            public ValidityPeriod ValidityPeriod { get; set; }

            /// <summary>Посада директора (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("DirectorPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorPosition { get; set; }

            /// <summary>ПІБ директора (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("DirectorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorName { get; set; }

            /// <summary>Пароль до ключа</summary>
            [Newtonsoft.Json.JsonProperty("KeyPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyPassword { get; set; }

            /// <summary>Кодове слово для блокування/розблокування ключа</summary>
            [Newtonsoft.Json.JsonProperty("CodeWord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CodeWord { get; set; }

            [Newtonsoft.Json.JsonProperty("CertificateType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public CertificateType CertificateType { get; set; }

            /// <summary>Ідентифікатор НБУ</summary>
            [Newtonsoft.Json.JsonProperty("NbuCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string NbuCode { get; set; }

            /// <summary>Код СПФМ</summary>
            [Newtonsoft.Json.JsonProperty("SpfmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SpfmCode { get; set; }

            /// <summary>Публікувати сертифікат на сайті</summary>
            [Newtonsoft.Json.JsonProperty("PublishCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PublishCertificate { get; set; }

            /// <summary>Питання, що допоможе згадати фразу голосової автентифікації</summary>
            [Newtonsoft.Json.JsonProperty("Question", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Question { get; set; }

            /// <summary>Ключова фраза голосової автентифікації</summary>
            [Newtonsoft.Json.JsonProperty("Answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Answer { get; set; }

            /// <summary>Унікальний номер РРО</summary>
            [Newtonsoft.Json.JsonProperty("RroNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string RroNumber { get; set; }


        }

       
        public partial class GenerateKeyForKeyAppModel
        {
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Password { get; set; }

            [Newtonsoft.Json.JsonProperty("CodeWord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CodeWord { get; set; }

            [Newtonsoft.Json.JsonProperty("KeyApplicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid KeyApplicationId { get; set; }


        }

        /// <summary>ValidationPasswordModel</summary>
        
        public partial class ValidationPasswordModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Password { get; set; }

            /// <summary>TwoFactorCode</summary>
            [Newtonsoft.Json.JsonProperty("TwoFactorCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public object TwoFactorCode { get; set; }


        }

        /// <summary>ValidationResponseModel</summary>
       
        public partial class ValidationResponseModel
        {
            /// <summary>IsValid</summary>
            [Newtonsoft.Json.JsonProperty("IsValid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsValid { get; set; }


        }

        /// <summary>CertificateInformationExtendModel</summary>
        
        public partial class CertificateInformationExtendModel
        {
            /// <summary>ExpireDate</summary>
            [Newtonsoft.Json.JsonProperty("ExpireDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset ExpireDate { get; set; }

            /// <summary>StartDate</summary>
            [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset StartDate { get; set; }

            /// <summary>CertificateBinary</summary>
            [Newtonsoft.Json.JsonProperty("CertificateBinary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] CertificateBinary { get; set; }

            /// <summary>KeyUsage</summary>
            [Newtonsoft.Json.JsonProperty("KeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyUsage { get; set; }

            /// <summary>Thumbprint</summary>
            [Newtonsoft.Json.JsonProperty("Thumbprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Thumbprint { get; set; }

            /// <summary>Edrpou</summary>
            [Newtonsoft.Json.JsonProperty("Edrpou", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Edrpou { get; set; }

            /// <summary>Drfo</summary>
            [Newtonsoft.Json.JsonProperty("Drfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Drfo { get; set; }

            /// <summary>FullName</summary>
            [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string FullName { get; set; }

            /// <summary>OrgUnit</summary>
            [Newtonsoft.Json.JsonProperty("OrgUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string OrgUnit { get; set; }

            /// <summary>Org</summary>
            [Newtonsoft.Json.JsonProperty("Org", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Org { get; set; }

            /// <summary>Address</summary>
            [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Address { get; set; }

            /// <summary>Phone</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Phone { get; set; }

            /// <summary>EMail</summary>
            [Newtonsoft.Json.JsonProperty("EMail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string EMail { get; set; }

            /// <summary>SubjectTitle</summary>
            [Newtonsoft.Json.JsonProperty("SubjectTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SubjectTitle { get; set; }

            /// <summary>Issuer</summary>
            [Newtonsoft.Json.JsonProperty("Issuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Issuer { get; set; }

            /// <summary>Issuer CN</summary>
            [Newtonsoft.Json.JsonProperty("IssuerCN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IssuerCN { get; set; }

            /// <summary>Serial number</summary>
            [Newtonsoft.Json.JsonProperty("Serial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Serial { get; set; }

            /// <summary>Ext. key usage</summary>
            [Newtonsoft.Json.JsonProperty("ExtKeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ExtKeyUsage { get; set; }

            /// <summary>Upn</summary>
            [Newtonsoft.Json.JsonProperty("Upn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Upn { get; set; }

            /// <summary>PowerCert</summary>
            [Newtonsoft.Json.JsonProperty("PowerCert", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PowerCert { get; set; }

            /// <summary>QSCD</summary>
            [Newtonsoft.Json.JsonProperty("QSCD", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool QSCD { get; set; }

            /// <summary>PublicKeyId</summary>
            [Newtonsoft.Json.JsonProperty("PublicKeyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string PublicKeyId { get; set; }

            /// <summary>KeyUsageType</summary>
            [Newtonsoft.Json.JsonProperty("KeyUsageType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public int KeyUsageType { get; set; }

            /// <summary>IssuerPublicKeyId</summary>
            [Newtonsoft.Json.JsonProperty("IssuerPublicKeyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IssuerPublicKeyId { get; set; }


        }

        /// <summary>IssuePointModel</summary>
       
        public partial class IssuePointModel
        {
            /// <summary>Id</summary>
            [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid Id { get; set; }

            /// <summary>Region</summary>
            [Newtonsoft.Json.JsonProperty("Region", Required = Newtonsoft.Json.Required.Always)]
           
            public string Region { get; set; }

            /// <summary>City</summary>
            [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string City { get; set; }

            /// <summary>Street</summary>
            [Newtonsoft.Json.JsonProperty("Street", Required = Newtonsoft.Json.Required.Always)]
          
            public string Street { get; set; }

            /// <summary>House</summary>
            [Newtonsoft.Json.JsonProperty("House", Required = Newtonsoft.Json.Required.Always)]
       
            public string House { get; set; }

            /// <summary>Flat</summary>
            [Newtonsoft.Json.JsonProperty("Flat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Flat { get; set; }

            /// <summary>PhoneNumber</summary>
            [Newtonsoft.Json.JsonProperty("PhoneNumber", Required = Newtonsoft.Json.Required.Always)]
           
            public string PhoneNumber { get; set; }

            /// <summary>IsActive</summary>
            [Newtonsoft.Json.JsonProperty("IsActive", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsActive { get; set; }

            /// <summary>DealerUserId</summary>
            [Newtonsoft.Json.JsonProperty("DealerUserId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid DealerUserId { get; set; }

            /// <summary>DealerName</summary>
            [Newtonsoft.Json.JsonProperty("DealerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DealerName { get; set; }

            /// <summary>DistributorName</summary>
            [Newtonsoft.Json.JsonProperty("DistributorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DistributorName { get; set; }

            /// <summary>Address</summary>
            [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Address { get; set; }

            /// <summary>IsVisible</summary>
            [Newtonsoft.Json.JsonProperty("IsVisible", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsVisible { get; set; }

            /// <summary>IsVisibleInvoiceAndPayment</summary>
            [Newtonsoft.Json.JsonProperty("IsVisibleInvoiceAndPayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsVisibleInvoiceAndPayment { get; set; }

            /// <summary>ShowAllAcsk</summary>
            [Newtonsoft.Json.JsonProperty("ShowAllAcsk", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool ShowAllAcsk { get; set; }


        }

        /// <summary>ApplicationStatus</summary>
       
        public enum ApplicationStatus
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

            _3 = 3,

            _4 = 4,

            _5 = 5,

            _6 = 6,

            _7 = 7,

            _8 = 8,

            _9 = 9,

            _10 = 10,

            _11 = 11,

        }

        
        public enum KeyLockSource
        {
            _1 = 1,

            _2 = 2,

            _10 = 10,

        }

        /// <summary>ApplicationKeyModel</summary>
       
        public partial class KeyApplicationModel
        {
            /// <summary>Id</summary>
            [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid Id { get; set; }

            /// <summary>Email</summary>
            [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Email { get; set; }

            /// <summary>PersonalCode</summary>
            [Newtonsoft.Json.JsonProperty("PersonalCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string PersonalCode { get; set; }

            /// <summary>Phone</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Phone { get; set; }

            /// <summary>ValidityPeriod</summary>
            [Newtonsoft.Json.JsonProperty("ValidityPeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public int ValidityPeriod { get; set; }

            /// <summary>Comment</summary>
            [Newtonsoft.Json.JsonProperty("Comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Comment { get; set; }

            /// <summary>CreationDate</summary>
            [Newtonsoft.Json.JsonProperty("CreationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset CreationDate { get; set; }

            [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ApplicationStatus Status { get; set; }

            /// <summary>CompanyName</summary>
            [Newtonsoft.Json.JsonProperty("CompanyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyName { get; set; }

            /// <summary>CompanyShortName</summary>
            [Newtonsoft.Json.JsonProperty("CompanyShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyShortName { get; set; }

            /// <summary>AuthorFullName</summary>
            [Newtonsoft.Json.JsonProperty("AuthorFullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthorFullName { get; set; }

            /// <summary>IsKeyGenerated</summary>
            [Newtonsoft.Json.JsonProperty("IsKeyGenerated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsKeyGenerated { get; set; }

            /// <summary>IsPayed</summary>
            [Newtonsoft.Json.JsonProperty("IsPayed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsPayed { get; set; }

            /// <summary>City</summary>
            [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string City { get; set; }

            /// <summary>AuthorName</summary>
            [Newtonsoft.Json.JsonProperty("AuthorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthorName { get; set; }

            /// <summary>AuthorSurname</summary>
            [Newtonsoft.Json.JsonProperty("AuthorSurname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthorSurname { get; set; }

            /// <summary>AuthorMiddleName</summary>
            [Newtonsoft.Json.JsonProperty("AuthorMiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthorMiddleName { get; set; }

            /// <summary>AuthorPosition</summary>
            [Newtonsoft.Json.JsonProperty("AuthorPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthorPosition { get; set; }

            /// <summary>CompanyCode</summary>
            [Newtonsoft.Json.JsonProperty("CompanyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyCode { get; set; }

            /// <summary>DirectorSurname</summary>
            [Newtonsoft.Json.JsonProperty("DirectorSurname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorSurname { get; set; }

            /// <summary>DirectorPosition</summary>
            [Newtonsoft.Json.JsonProperty("DirectorPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorPosition { get; set; }

            /// <summary>UniqueNumber</summary>
            [Newtonsoft.Json.JsonProperty("UniqueNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string UniqueNumber { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicantType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ApplicantType ApplicantType { get; set; }

            [Newtonsoft.Json.JsonProperty("CertificateType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public CertificateType CertificateType { get; set; }

            /// <summary>TempData</summary>
            [Newtonsoft.Json.JsonProperty("TempData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool TempData { get; set; }

            [Newtonsoft.Json.JsonProperty("ServiceType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ApplicationType ServiceType { get; set; }

            /// <summary>Number</summary>
            [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Number { get; set; }

            /// <summary>RegionId</summary>
            [Newtonsoft.Json.JsonProperty("RegionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public int? RegionId { get; set; }

            /// <summary>Username</summary>
            [Newtonsoft.Json.JsonProperty("Username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Username { get; set; }

            /// <summary>IssuePointId</summary>
            [Newtonsoft.Json.JsonProperty("IssuePointId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid? IssuePointId { get; set; }

            [Newtonsoft.Json.JsonProperty("Acsk", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public Acsk Acsk { get; set; }

            /// <summary>PublishCertificate</summary>
            [Newtonsoft.Json.JsonProperty("PublishCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PublishCertificate { get; set; }

            /// <summary>NbuCode</summary>
            [Newtonsoft.Json.JsonProperty("NbuCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string NbuCode { get; set; }

            /// <summary>SpfmCode</summary>
            [Newtonsoft.Json.JsonProperty("SpfmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SpfmCode { get; set; }

            /// <summary>Question</summary>
            [Newtonsoft.Json.JsonProperty("Question", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Question { get; set; }

            /// <summary>Answer</summary>
            [Newtonsoft.Json.JsonProperty("Answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Answer { get; set; }

            /// <summary>SerialNumbers</summary>
            [Newtonsoft.Json.JsonProperty("SerialNumbers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<string> SerialNumbers { get; set; }

            /// <summary>CertificateStartDate</summary>
            [Newtonsoft.Json.JsonProperty("CertificateStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset? CertificateStartDate { get; set; }

            /// <summary>CertificateExpireDate</summary>
            [Newtonsoft.Json.JsonProperty("CertificateExpireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset? CertificateExpireDate { get; set; }

            /// <summary>IsKeyLocked</summary>
            [Newtonsoft.Json.JsonProperty("IsKeyLocked", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsKeyLocked { get; set; }

            /// <summary>IsCertificateValid</summary>
            [Newtonsoft.Json.JsonProperty("IsCertificateValid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsCertificateValid { get; set; }

            /// <summary>IsRequestsExists</summary>
            [Newtonsoft.Json.JsonProperty("IsRequestsExists", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsRequestsExists { get; set; }

            /// <summary>RroNumber</summary>
            [Newtonsoft.Json.JsonProperty("RroNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string RroNumber { get; set; }

            /// <summary>IsVisibleInvoiceAndPayment</summary>
            [Newtonsoft.Json.JsonProperty("IsVisibleInvoiceAndPayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsVisibleInvoiceAndPayment { get; set; }

            [Newtonsoft.Json.JsonProperty("DistributorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DistributorName { get; set; }

            [Newtonsoft.Json.JsonProperty("DealerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DealerName { get; set; }

            [Newtonsoft.Json.JsonProperty("IssuedPointName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IssuedPointName { get; set; }

            [Newtonsoft.Json.JsonProperty("RegistrationAdministratorId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid? RegistrationAdministratorId { get; set; }

            [Newtonsoft.Json.JsonProperty("RegistrationAdministratorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string RegistrationAdministratorName { get; set; }

            [Newtonsoft.Json.JsonProperty("IsFree", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsFree { get; set; }

            [Newtonsoft.Json.JsonProperty("LockedBy", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public KeyLockSource LockedBy { get; set; }


        }

        /// <summary>ManagementKeyApplicationRequestModel</summary>
        
        public partial class ManagementKeyApplicationRequestModel
        {
            [Newtonsoft.Json.JsonProperty("ApplicationType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicationType ApplicationType { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicantType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicantType ApplicantType { get; set; }

            /// <summary>Повна назва компанії (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("CompanyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyName { get; set; }

            /// <summary>Код ЄДРПОУ компанії (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("CompanyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
           
            public string CompanyCode { get; set; }

            /// <summary>Скорочена назва компанії (якщо довжина повної назви перевищує 64 символи (для сертифікації))</summary>
            [Newtonsoft.Json.JsonProperty("CompanyShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CompanyShortName { get; set; }

            /// <summary>RegionId</summary>
            [Newtonsoft.Json.JsonProperty("RegionId", Required = Newtonsoft.Json.Required.Always)]
            public int RegionId { get; set; }

            /// <summary>Місто (необов'язкове, якщо Область - м.Київ)</summary>
            [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string City { get; set; }

            /// <summary>Ім'я заявника</summary>
            [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Always)]
          
            public string Name { get; set; }

            /// <summary>Прізвище заявника</summary>
            [Newtonsoft.Json.JsonProperty("Surname", Required = Newtonsoft.Json.Required.Always)]
         
            public string Surname { get; set; }

            /// <summary>По-батькові заявника</summary>
            [Newtonsoft.Json.JsonProperty("MiddleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string MiddleName { get; set; }

            /// <summary>РНОКПП заявника</summary>
            [Newtonsoft.Json.JsonProperty("PersonalCode", Required = Newtonsoft.Json.Required.Always)]
          
            public string PersonalCode { get; set; }

            /// <summary>Посада заявника</summary>
            [Newtonsoft.Json.JsonProperty("Position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
           
            public string Position { get; set; }

            /// <summary>УНЗР</summary>
            [Newtonsoft.Json.JsonProperty("UniqueNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
           
            public string UniqueNumber { get; set; }

            /// <summary>E-mail заявника</summary>
            [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Email { get; set; }

            [Newtonsoft.Json.JsonProperty("ValidityPeriod", Required = Newtonsoft.Json.Required.Always)]
            public ValidityPeriod ValidityPeriod { get; set; }

            /// <summary>Посада директора (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("DirectorPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorPosition { get; set; }

            /// <summary>ПІБ директора (обов'язково якщо обрано юридичну особу)</summary>
            [Newtonsoft.Json.JsonProperty("DirectorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string DirectorName { get; set; }

            /// <summary>Пароль до ключа</summary>
            [Newtonsoft.Json.JsonProperty("KeyPassword", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyPassword { get; set; }

            /// <summary>Кодове слово для блокування/розблокування ключа</summary>
            [Newtonsoft.Json.JsonProperty("CodeWord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CodeWord { get; set; }

            [Newtonsoft.Json.JsonProperty("CertificateType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public CertificateType CertificateType { get; set; }

            /// <summary>Ідентифікатор НБУ</summary>
            [Newtonsoft.Json.JsonProperty("NbuCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string NbuCode { get; set; }

            /// <summary>Код СПФМ</summary>
            [Newtonsoft.Json.JsonProperty("SpfmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SpfmCode { get; set; }

            /// <summary>Публікувати сертифікат на сайті</summary>
            [Newtonsoft.Json.JsonProperty("PublishCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PublishCertificate { get; set; }

            /// <summary>Питання, що допоможе згадати фразу голосової автентифікації</summary>
            [Newtonsoft.Json.JsonProperty("Question", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Question { get; set; }

            /// <summary>Ключова фраза голосової автентифікації</summary>
            [Newtonsoft.Json.JsonProperty("Answer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Answer { get; set; }

            /// <summary>Унікальний номер РРО</summary>
            [Newtonsoft.Json.JsonProperty("RroNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string RroNumber { get; set; }

            /// <summary>Номер телефону заявника (також логін в кабінет)</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Always)]
           
            public string Phone { get; set; }


        }

        /// <summary>KeyApplicationCreatedModel</summary>
        
        public partial class KeyApplicationCreatedModel
        {
            /// <summary>KeyApplicationId</summary>
            [Newtonsoft.Json.JsonProperty("KeyApplicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Guid KeyApplicationId { get; set; }

            /// <summary>KeyData</summary>
            [Newtonsoft.Json.JsonProperty("KeyData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] KeyData { get; set; }

            /// <summary>KeyApplication number</summary>
            [Newtonsoft.Json.JsonProperty("Number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Number { get; set; }


        }

        /// <summary>KeyRequestsModel</summary>
        
        public partial class KeyRequestsModel
        {
            /// <summary>Request</summary>
            [Newtonsoft.Json.JsonProperty("Request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] Request { get; set; }

            /// <summary>KepRequest</summary>
            [Newtonsoft.Json.JsonProperty("KepRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] KepRequest { get; set; }


        }

        /// <summary>KeyApplicationSearchInfoModel</summary>
        
        public partial class KeyApplicationSearchInfoModel
        {
            [Newtonsoft.Json.JsonProperty("ApplicantType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicantType ApplicantType { get; set; }

            [Newtonsoft.Json.JsonProperty("ApplicationType", Required = Newtonsoft.Json.Required.Always)]
            public ApplicationType ApplicationType { get; set; }

            [Newtonsoft.Json.JsonProperty("Acsk", Required = Newtonsoft.Json.Required.Always)]
            public Acsk Acsk { get; set; }

            /// <summary>CompanyCode</summary>
            [Newtonsoft.Json.JsonProperty("CompanyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
           
            public string CompanyCode { get; set; }

            /// <summary>PersonalCode</summary>
            [Newtonsoft.Json.JsonProperty("PersonalCode", Required = Newtonsoft.Json.Required.Always)]
          
            public string PersonalCode { get; set; }


        }

        /// <summary>CertificationChangeStatusModel</summary>
       
        public partial class CertificationChangeStatusModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
           
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
            public string KeyName { get; set; }

            [Newtonsoft.Json.JsonProperty("Status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public ApplicationStatus Status { get; set; }


        }

        /// <summary>NamedKeyModel</summary>
       
        public partial class NamedKeyModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
           
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
           
            public string KeyName { get; set; }


        }

        /// <summary>Формат підпису: 1 - CADES_BES, 4 - CADES_T, 8 - CADES_C, 16 - CADES_X_LONG, 128 - CADES_X_LONG_TRUSTED</summary>
       
        public enum SignType
        {
            _1 = 1,

            _4 = 4,

            _8 = 8,

            _16 = 16,

            _128 = 128,

        }

        /// <summary>Sign type options</summary>
       
        public partial class NamedSignOpitionsModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
          
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
          
            public string KeyName { get; set; }

            [Newtonsoft.Json.JsonProperty("SignType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public SignType SignType { get; set; }

            /// <summary>Add or not data TSP for container. Default - true</summary>
            [Newtonsoft.Json.JsonProperty("AppendDataTsp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool AppendDataTsp { get; set; }


        }

       
        public partial class TransportSectionInfo
        {
            [Newtonsoft.Json.JsonProperty("FileName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string FileName { get; set; }

            [Newtonsoft.Json.JsonProperty("ProgramName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ProgramName { get; set; }

            [Newtonsoft.Json.JsonProperty("ProgramVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ProgramVersion { get; set; }


        }

       
        public partial class SignReportRequestModel
        {
            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }

            [Newtonsoft.Json.JsonProperty("CryptCertificates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<byte[]> CryptCertificates { get; set; }

            [Newtonsoft.Json.JsonProperty("CryptKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public NamedKeyModel CryptKey { get; set; }

            [Newtonsoft.Json.JsonProperty("Keys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<NamedKeyModel> Keys { get; set; }

            [Newtonsoft.Json.JsonProperty("SignSectionHeader", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SignSectionHeader { get; set; }

            [Newtonsoft.Json.JsonProperty("CryptSectionHeader", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string CryptSectionHeader { get; set; }

            [Newtonsoft.Json.JsonProperty("AppendCryptCert", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool AppendCryptCert { get; set; }

            [Newtonsoft.Json.JsonProperty("TransportSectionInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public TransportSectionInfo TransportSectionInfo { get; set; }


        }

      
        public partial class DataResponseModel
        {
            [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] Data { get; set; }


        }

       
        public partial class SignOperationRequestModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
           
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
           
            public string KeyName { get; set; }

            [Newtonsoft.Json.JsonProperty("OperationId", Required = Newtonsoft.Json.Required.Always)]
           
            public string OperationId { get; set; }


        }

        
        public partial class CryptFileRequestModel
        {
            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }

            [Newtonsoft.Json.JsonProperty("CryptCertificates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<byte[]> CryptCertificates { get; set; }

            [Newtonsoft.Json.JsonProperty("CryptKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public NamedKeyModel CryptKey { get; set; }


        }

       
        public partial class UnsigningDataRequestModel
        {
            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }

            [Newtonsoft.Json.JsonProperty("SendCertificateBinary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool SendCertificateBinary { get; set; }

            [Newtonsoft.Json.JsonProperty("SendUnsignedData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool SendUnsignedData { get; set; }


        }

        
        public enum TimeStampType
        {
            _0 = 0,

            _1 = 1,

            _2 = 2,

        }

        
        public partial class SignModel
        {
            /// <summary>ExpireDate</summary>
            [Newtonsoft.Json.JsonProperty("ExpireDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset ExpireDate { get; set; }

            /// <summary>StartDate</summary>
            [Newtonsoft.Json.JsonProperty("StartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset StartDate { get; set; }

            /// <summary>CertificateBinary</summary>
            [Newtonsoft.Json.JsonProperty("CertificateBinary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] CertificateBinary { get; set; }

            /// <summary>KeyUsage</summary>
            [Newtonsoft.Json.JsonProperty("KeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string KeyUsage { get; set; }

            /// <summary>Thumbprint</summary>
            [Newtonsoft.Json.JsonProperty("Thumbprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Thumbprint { get; set; }

            /// <summary>Edrpou</summary>
            [Newtonsoft.Json.JsonProperty("Edrpou", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Edrpou { get; set; }

            /// <summary>Drfo</summary>
            [Newtonsoft.Json.JsonProperty("Drfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Drfo { get; set; }

            /// <summary>FullName</summary>
            [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string FullName { get; set; }

            /// <summary>OrgUnit</summary>
            [Newtonsoft.Json.JsonProperty("OrgUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string OrgUnit { get; set; }

            /// <summary>Org</summary>
            [Newtonsoft.Json.JsonProperty("Org", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Org { get; set; }

            /// <summary>Address</summary>
            [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Address { get; set; }

            /// <summary>Phone</summary>
            [Newtonsoft.Json.JsonProperty("Phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Phone { get; set; }

            /// <summary>EMail</summary>
            [Newtonsoft.Json.JsonProperty("EMail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string EMail { get; set; }

            /// <summary>SubjectTitle</summary>
            [Newtonsoft.Json.JsonProperty("SubjectTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string SubjectTitle { get; set; }

            /// <summary>Issuer</summary>
            [Newtonsoft.Json.JsonProperty("Issuer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Issuer { get; set; }

            /// <summary>Issuer CN</summary>
            [Newtonsoft.Json.JsonProperty("IssuerCN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string IssuerCN { get; set; }

            /// <summary>Serial number</summary>
            [Newtonsoft.Json.JsonProperty("Serial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Serial { get; set; }

            /// <summary>Ext. key usage</summary>
            [Newtonsoft.Json.JsonProperty("ExtKeyUsage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string ExtKeyUsage { get; set; }

            /// <summary>Upn</summary>
            [Newtonsoft.Json.JsonProperty("Upn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Upn { get; set; }

            /// <summary>PowerCert</summary>
            [Newtonsoft.Json.JsonProperty("PowerCert", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool PowerCert { get; set; }

            /// <summary>QSCD</summary>
            [Newtonsoft.Json.JsonProperty("QSCD", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool QSCD { get; set; }

            [Newtonsoft.Json.JsonProperty("HasTimeStamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool HasTimeStamp { get; set; }

            [Newtonsoft.Json.JsonProperty("SignDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.DateTimeOffset SignDateTime { get; set; }

            [Newtonsoft.Json.JsonProperty("Error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Error { get; set; }

            [Newtonsoft.Json.JsonProperty("ElapsedMilliseconds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public long ElapsedMilliseconds { get; set; }

            [Newtonsoft.Json.JsonProperty("IsStamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool IsStamp { get; set; }

            [Newtonsoft.Json.JsonProperty("TimeStampType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public TimeStampType TimeStampType { get; set; }


        }

        
        public partial class UnsignedFileModel
        {
            [Newtonsoft.Json.JsonProperty("Signs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<SignModel> Signs { get; set; }

            [Newtonsoft.Json.JsonProperty("Error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string Error { get; set; }

            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }


        }

        
        public partial class DecryptDataRequestModel
        {
            [Newtonsoft.Json.JsonProperty("DecryptKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public NamedKeyModel DecryptKey { get; set; }

            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }

            [Newtonsoft.Json.JsonProperty("Unsign", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool Unsign { get; set; }


        }

        /// <summary>NamedSignFileModel</summary>
        
        public partial class NamedSignFileModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
           
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
          
            public string KeyName { get; set; }

            [Newtonsoft.Json.JsonProperty("SignType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public SignType SignType { get; set; }

            /// <summary>Add or not data TSP for container. Default - true</summary>
            [Newtonsoft.Json.JsonProperty("AppendDataTsp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool AppendDataTsp { get; set; }

            /// <summary>FileData</summary>
            [Newtonsoft.Json.JsonProperty("FileData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] FileData { get; set; }

            /// <summary>AppendData</summary>
            [Newtonsoft.Json.JsonProperty("AppendData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool AppendData { get; set; }


        }

        
        public partial class SignedDataModel
        {
            [Newtonsoft.Json.JsonProperty("SignedData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] SignedData { get; set; }


        }

        /// <summary>NamedSignFileHashModel</summary>
        
        public partial class NamedSignFileHashModel
        {
            /// <summary>Password</summary>
            [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Always)]
            
            public string Password { get; set; }

            /// <summary>KeyName</summary>
            [Newtonsoft.Json.JsonProperty("KeyName", Required = Newtonsoft.Json.Required.Always)]
          
            public string KeyName { get; set; }

            [Newtonsoft.Json.JsonProperty("SignType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public SignType SignType { get; set; }

            /// <summary>Add or not data TSP for container. Default - true</summary>
            [Newtonsoft.Json.JsonProperty("AppendDataTsp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public bool AppendDataTsp { get; set; }

            /// <summary>File hash data or base64 representation</summary>
            [Newtonsoft.Json.JsonProperty("FileHash", Required = Newtonsoft.Json.Required.Always)]
           
            public byte[] FileHash { get; set; }


        }

        
        public partial class SignedHashModel
        {
            [Newtonsoft.Json.JsonProperty("SignedHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public byte[] SignedHash { get; set; }


        }

        /// <summary>SignByNamedKeysModel</summary>
       
        public partial class SignByNamedKeysModel
        {
            /// <summary>Files</summary>
            [Newtonsoft.Json.JsonProperty("Files", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<NamedSignFileModel> Files { get; set; }


        }

       
        public partial class GetCertificatesResponse
        {
            [Newtonsoft.Json.JsonProperty("certificates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public System.Collections.Generic.ICollection<string> Certificates { get; set; }


        }

       
        public partial class SignServerEncryptedRequest
        {
            [Newtonsoft.Json.JsonProperty("encryptedData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string EncryptedData { get; set; }

            [Newtonsoft.Json.JsonProperty("authData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
            public string AuthData { get; set; }


        }
       
        //public partial class ApiException : System.Exception
        //{
        //    public int StatusCode { get; private set; }

        //    public string Response { get; private set; }

        //    public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        //    public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
        //        : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        //    {
        //        StatusCode = statusCode;
        //        Response = response;
        //        Headers = headers;
        //    }

            //public override string ToString()
            // {
            //    return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
            //}
        //}

        // public partial class ApiException<TResult> : ApiException
        //{
        //    public TResult Result { get; private set; }

        //    public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
        //        : base(message, statusCode, response, headers, innerException)
        //    {
        //        Result = result;
        //    }
        //}

    }
}
