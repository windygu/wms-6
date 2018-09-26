﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBK.ECService.WMSLog.Model.Models.Mapping
{
    public class warehouseMap : EntityTypeConfiguration<warehouse>
    {
        public warehouseMap()
        {
            // Primary Key
            this.HasKey(t => t.SysId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Contacts)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.Telephone)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.OtherId)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.UpdateUserName)
            .HasMaxLength(32);

            this.Property(t => t.WareHouseArea)
            this.Property(t => t.WareHouseProperty)
            this.Property(t => t.ConnectionString)
            this.Property(t => t.ConnectionStringRead)




            // Table & Column Mappings
            this.ToTable("warehouse", "nbk_wms");
            this.Property(t => t.SysId).HasColumnName("SysId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Contacts).HasColumnName("Contacts");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OtherId).HasColumnName("OtherId");
            this.Property(t => t.UpdateUserName).HasColumnName("UpdateUserName");
            this.Property(t => t.ConnectionString).HasColumnName("ConnectionString");
            this.Property(t => t.ConnectionStringRead).HasColumnName("ConnectionStringRead");
            this.Property(t => t.WareHouseArea).HasColumnName("WareHouseArea");
            this.Property(t => t.WareHouseProperty).HasColumnName("WareHouseProperty");
        }
    }
}