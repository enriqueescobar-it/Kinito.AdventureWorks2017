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
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // TransactionHistoryArchive
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_TransactionHistoryArchiveConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_TransactionHistoryArchive>
    {
        public Production_TransactionHistoryArchiveConfiguration()
            : this("Production")
        {
        }

        public Production_TransactionHistoryArchiveConfiguration(string schema)
        {
            Property(x => x.TransactionType).IsFixedLength();
            Property(x => x.ActualCost).HasPrecision(19,4);
        }
    }

}
// </auto-generated>
