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

    // ProductPhoto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductPhotoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration()
            : this("Production")
        {
        }

        public Production_ProductPhotoConfiguration(string schema)
        {
            Property(x => x.ThumbNailPhoto).IsOptional();
            Property(x => x.ThumbnailPhotoFileName).IsOptional();
            Property(x => x.LargePhoto).IsOptional();
            Property(x => x.LargePhotoFileName).IsOptional();
        }
    }

}
// </auto-generated>
