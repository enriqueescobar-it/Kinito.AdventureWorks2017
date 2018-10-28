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

    // ErrorLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ErrorLogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogConfiguration()
            : this("dbo")
        {
        }

        public ErrorLogConfiguration(string schema)
        {
            Property(x => x.ErrorSeverity).IsOptional();
            Property(x => x.ErrorState).IsOptional();
            Property(x => x.ErrorProcedure).IsOptional();
            Property(x => x.ErrorLine).IsOptional();
        }
    }

}
// </auto-generated>