// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context
{

    // vSalesPerson
    [Table("vSalesPerson", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_VSalesPerson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [Column(@"Title", Order = 2, TypeName = "nvarchar")]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 8)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FirstName", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (Primary key) (length: 50)

        [Column(@"MiddleName", Order = 4, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LastName", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (Primary key) (length: 50)

        [Column(@"Suffix", Order = 6, TypeName = "nvarchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Suffix")]
        public string Suffix { get; set; } // Suffix (length: 10)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"JobTitle", Order = 7, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Job title")]
        public string JobTitle { get; set; } // JobTitle (Primary key) (length: 50)

        [Column(@"PhoneNumber", Order = 8, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } // PhoneNumber (length: 25)

        [Column(@"PhoneNumberType", Order = 9, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Phone number type")]
        public string PhoneNumberType { get; set; } // PhoneNumberType (length: 50)

        [Column(@"EmailAddress", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"EmailPromotion", Order = 11, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Email promotion")]
        public int EmailPromotion { get; set; } // EmailPromotion (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"AddressLine1", Order = 12, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Key]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; } // AddressLine1 (Primary key) (length: 60)

        [Column(@"AddressLine2", Order = 13, TypeName = "nvarchar")]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; } // AddressLine2 (length: 60)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"City", Order = 14, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Key]
        [Display(Name = "City")]
        public string City { get; set; } // City (Primary key) (length: 30)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"StateProvinceName", Order = 15, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "State province name")]
        public string StateProvinceName { get; set; } // StateProvinceName (Primary key) (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PostalCode", Order = 16, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Key]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (Primary key) (length: 15)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CountryRegionName", Order = 17, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Country region name")]
        public string CountryRegionName { get; set; } // CountryRegionName (Primary key) (length: 50)

        [Column(@"TerritoryName", Order = 18, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Territory name")]
        public string TerritoryName { get; set; } // TerritoryName (length: 50)

        [Column(@"TerritoryGroup", Order = 19, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Territory group")]
        public string TerritoryGroup { get; set; } // TerritoryGroup (length: 50)

        [Column(@"SalesQuota", Order = 20, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales quota")]
        public decimal? SalesQuota { get; set; } // SalesQuota

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesYTD", Order = 21, TypeName = "money")]
        [Required]
        [Key]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales ytd")]
        public decimal SalesYtd { get; set; } // SalesYTD (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesLastYear", Order = 22, TypeName = "money")]
        [Required]
        [Key]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales last year")]
        public decimal SalesLastYear { get; set; } // SalesLastYear (Primary key)
    }

}
// </auto-generated>
