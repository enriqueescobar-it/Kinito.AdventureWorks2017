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

namespace Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // SalesPerson
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_SalesPersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_SalesPerson>
    {
        public Sales_SalesPersonConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesPersonConfiguration(string schema)
        {
            Property(x => x.TerritoryId).IsOptional();
            Property(x => x.SalesQuota).IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasPrecision(19,4);
            Property(x => x.CommissionPct).HasPrecision(10,4);
            Property(x => x.SalesYtd).HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasPrecision(19,4);

        }
    }

}
// </auto-generated>
