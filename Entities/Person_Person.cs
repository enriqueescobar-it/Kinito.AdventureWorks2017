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

namespace Entities
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // Person
    ///<summary>
    /// Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.
    ///</summary>
    [Table("Person", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_Person
    {

        ///<summary>
        /// Primary key for Person records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_Person_BusinessEntityID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        [ForeignKey("Person_BusinessEntity")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        ///</summary>
        [Column(@"PersonType", Order = 2, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Person type")]
        public string PersonType { get; set; } // PersonType (length: 2)

        ///<summary>
        /// 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        ///</summary>
        [Column(@"NameStyle", Order = 3, TypeName = "bit")]
        [Required]
        [Display(Name = "Name style")]
        public bool NameStyle { get; set; } // NameStyle

        ///<summary>
        /// A courtesy title. For example, Mr. or Ms.
        ///</summary>
        [Column(@"Title", Order = 4, TypeName = "nvarchar")]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 8)

        ///<summary>
        /// First name of the person.
        ///</summary>
        [Column(@"FirstName", Order = 5, TypeName = "nvarchar")]
        [Index(@"IX_Person_LastName_FirstName_MiddleName", 2, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 50)

        ///<summary>
        /// Middle name or middle initial of the person.
        ///</summary>
        [Column(@"MiddleName", Order = 6, TypeName = "nvarchar")]
        [Index(@"IX_Person_LastName_FirstName_MiddleName", 3, IsUnique = false, IsClustered = false)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        ///<summary>
        /// Last name of the person.
        ///</summary>
        [Column(@"LastName", Order = 7, TypeName = "nvarchar")]
        [Index(@"IX_Person_LastName_FirstName_MiddleName", 1, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 50)

        ///<summary>
        /// Surname suffix. For example, Sr. or Jr.
        ///</summary>
        [Column(@"Suffix", Order = 8, TypeName = "nvarchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Suffix")]
        public string Suffix { get; set; } // Suffix (length: 10)

        ///<summary>
        /// 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        ///</summary>
        [Column(@"EmailPromotion", Order = 9, TypeName = "int")]
        [Required]
        [Display(Name = "Email promotion")]
        public int EmailPromotion { get; set; } // EmailPromotion

        ///<summary>
        /// Additional contact information about the person stored in xml format.
        ///</summary>
        [Column(@"AdditionalContactInfo", Order = 10, TypeName = "xml")]
        [Display(Name = "Additional contact info")]
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo

        ///<summary>
        /// Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        ///</summary>
        [Column(@"Demographics", Order = 11, TypeName = "xml")]
        [Display(Name = "Demographics")]
        public string Demographics { get; set; } // Demographics

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 12, TypeName = "uniqueidentifier")]
        [Index(@"AK_Person_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 13, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) Person_Person pointed by [Employee].[BusinessEntityID] (FK_Employee_Person_BusinessEntityID)
        /// </summary>
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        /// <summary>
        /// Parent (One-to-One) Person_Person pointed by [Password].[BusinessEntityID] (FK_Password_Person_BusinessEntityID)
        /// </summary>
        public virtual Person_Password Person_Password { get; set; } // Password.FK_Password_Person_BusinessEntityID
        /// <summary>
        /// Child Person_BusinessEntityContacts where [BusinessEntityContact].[PersonID] point to this entity (FK_BusinessEntityContact_Person_PersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } // BusinessEntityContact.FK_BusinessEntityContact_Person_PersonID
        /// <summary>
        /// Child Person_EmailAddresses where [EmailAddress].[BusinessEntityID] point to this entity (FK_EmailAddress_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_EmailAddress> Person_EmailAddresses { get; set; } // EmailAddress.FK_EmailAddress_Person_BusinessEntityID
        /// <summary>
        /// Child Person_PersonPhones where [PersonPhone].[BusinessEntityID] point to this entity (FK_PersonPhone_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_PersonPhone> Person_PersonPhones { get; set; } // PersonPhone.FK_PersonPhone_Person_BusinessEntityID
        /// <summary>
        /// Child Sales_Customers where [Customer].[PersonID] point to this entity (FK_Customer_Person_PersonID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customers { get; set; } // Customer.FK_Customer_Person_PersonID
        /// <summary>
        /// Child Sales_PersonCreditCards where [PersonCreditCard].[BusinessEntityID] point to this entity (FK_PersonCreditCard_Person_BusinessEntityID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } // PersonCreditCard.FK_PersonCreditCard_Person_BusinessEntityID

        // Foreign keys

        /// <summary>
        /// Parent Person_BusinessEntity pointed by [Person].([BusinessEntityId]) (FK_Person_BusinessEntity_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID

        public Person_Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContacts = new System.Collections.Generic.List<Person_BusinessEntityContact>();
            Sales_Customers = new System.Collections.Generic.List<Sales_Customer>();
            Person_EmailAddresses = new System.Collections.Generic.List<Person_EmailAddress>();
            Sales_PersonCreditCards = new System.Collections.Generic.List<Sales_PersonCreditCard>();
            Person_PersonPhones = new System.Collections.Generic.List<Person_PersonPhone>();
        }
    }

}
// </auto-generated>
