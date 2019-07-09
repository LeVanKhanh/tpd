using System;
using System.Collections.Generic;
using System.Text;

namespace Tpd.Language.Data.Configurations
{
    //public partial class DatabaseContext : DatabaseContextBase
    //{
    //    public void ConfigureApplication(EntityTypeBuilder<EttApplication> builder)
    //    {
    //        builder.Property(p => p.ShortName).HasMaxLength(50);
    //        builder.Property(p => p.FullName).HasMaxLength(200);
    //    }

    //    public void ConfigureLanguage(EntityTypeBuilder<EttCulture> builder)
    //    {
    //        builder.Property(p => p.Code).HasMaxLength(50);
    //        builder.Property(p => p.Description).HasMaxLength(100);
    //    }

    //    public void ConfigureLanguageBaseLine(EntityTypeBuilder<EttResourceDefault> builder)
    //    {
    //        builder.Property(p => p.Name).HasMaxLength(500);
    //    }

    //    public void ConfigureModule(EntityTypeBuilder<EttModule> builder)
    //    {
    //        builder.Property(p => p.Name).HasMaxLength(200);
    //        builder.HasOne(o => o.Application).WithMany().HasForeignKey(f => f.ApplicationId);
    //    }

    //    public void ConfigureModuleMapLanguage(EntityTypeBuilder<EttModuleResource> builder)
    //    {
    //        builder.HasOne(o => o.Module).WithMany().HasForeignKey(f => f.ModuleId);
    //        builder.HasOne(o => o.Baseline).WithMany().HasForeignKey(f => f.ResourceDefaultId);
    //    }

    //    public void ConfigureTranslation(EntityTypeBuilder<EttTranslation> builder)
    //    {
    //        builder.HasOne(o => o.ResourceDefault).WithMany().HasForeignKey(f => f.ResourceDefaultId);
    //        builder.HasOne(o => o.Culture).WithMany().HasForeignKey(f => f.CultureId);
    //    }
    //}
}
