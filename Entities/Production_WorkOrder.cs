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

    // WorkOrder
    ///<summary>
    /// Manufacturing work orders.
    ///</summary>
    [Table("WorkOrder", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_WorkOrder
    {

        ///<summary>
        /// Primary key for WorkOrder records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"WorkOrderID", Order = 1, TypeName = "int")]
        [Index(@"PK_WorkOrder_WorkOrderID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Work order ID")]
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key)

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        [Column(@"ProductID", Order = 2, TypeName = "int")]
        [Index(@"IX_WorkOrder_ProductID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Product quantity to build.
        ///</summary>
        [Column(@"OrderQty", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Order qty")]
        public int OrderQty { get; set; } // OrderQty

        ///<summary>
        /// Quantity built and put in inventory.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(@"StockedQty", Order = 4, TypeName = "int")]
        [Display(Name = "Stocked qty")]
        public int StockedQty { get; private set; } // StockedQty

        ///<summary>
        /// Quantity that failed inspection.
        ///</summary>
        [Column(@"ScrappedQty", Order = 5, TypeName = "smallint")]
        [Required]
        [Display(Name = "Scrapped qty")]
        public short ScrappedQty { get; set; } // ScrappedQty

        ///<summary>
        /// Work order start date.
        ///</summary>
        [Column(@"StartDate", Order = 6, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start date")]
        public System.DateTime StartDate { get; set; } // StartDate

        ///<summary>
        /// Work order end date.
        ///</summary>
        [Column(@"EndDate", Order = 7, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "End date")]
        public System.DateTime? EndDate { get; set; } // EndDate

        ///<summary>
        /// Work order due date.
        ///</summary>
        [Column(@"DueDate", Order = 8, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Due date")]
        public System.DateTime DueDate { get; set; } // DueDate

        ///<summary>
        /// Reason for inspection failure.
        ///</summary>
        [Column(@"ScrapReasonID", Order = 9, TypeName = "smallint")]
        [Index(@"IX_WorkOrder_ScrapReasonID", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Scrap reason ID")]
        public short? ScrapReasonId { get; set; } // ScrapReasonID

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 10, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_WorkOrderRoutings where [WorkOrderRouting].[WorkOrderID] point to this entity (FK_WorkOrderRouting_WorkOrder_WorkOrderID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_WorkOrder_WorkOrderID

        // Foreign keys

        /// <summary>
        /// Parent Production_Product pointed by [WorkOrder].([ProductId]) (FK_WorkOrder_Product_ProductID)
        /// </summary>
        [ForeignKey("ProductId"), Required] public virtual Production_Product Production_Product { get; set; } // FK_WorkOrder_Product_ProductID

        /// <summary>
        /// Parent Production_ScrapReason pointed by [WorkOrder].([ScrapReasonId]) (FK_WorkOrder_ScrapReason_ScrapReasonID)
        /// </summary>
        [ForeignKey("ScrapReasonId")] public virtual Production_ScrapReason Production_ScrapReason { get; set; } // FK_WorkOrder_ScrapReason_ScrapReasonID

        public Production_WorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            Production_WorkOrderRoutings = new System.Collections.Generic.List<Production_WorkOrderRouting>();
        }
    }

}
// </auto-generated>