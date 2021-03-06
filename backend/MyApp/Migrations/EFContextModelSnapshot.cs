﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Database;

namespace MyApp.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyApp.Logic.Entities.Approver", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApprovalComments")
                        .HasColumnName("approval_comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovalStatus")
                        .HasColumnName("approval_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApproverName")
                        .HasColumnName("approver_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedBy")
                        .HasColumnName("assigned_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnName("assigned_to")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckedoutBy")
                        .HasColumnName("checkedout_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Deadline")
                        .HasColumnName("deadline")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DepartmentArea")
                        .HasColumnName("department_area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentStatus")
                        .HasColumnName("document_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("bit");

                    b.Property<long?>("MDCId")
                        .HasColumnName("mdc_id")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("RemovedAt")
                        .HasColumnName("removed_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RemovedBy")
                        .HasColumnName("removed_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevisionMessage")
                        .HasColumnName("revision_message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("RowVersion")
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UsedAt")
                        .HasColumnName("used_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_approvers");

                    b.HasIndex("MDCId")
                        .HasName("ix_approvers_mdc_id");

                    b.ToTable("approver");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.AttachmentFileComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApproverName")
                        .HasColumnName("approver_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnName("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MdcAttachmentFileId")
                        .HasColumnName("mdc_attachment_file_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_attachment_file_comments");

                    b.HasIndex("MdcAttachmentFileId")
                        .HasName("ix_attachment_file_comments_mdc_attachment_file_id");

                    b.ToTable("attachment_file_comment");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Catalog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CatalogDefinitionId")
                        .HasColumnName("catalog_definition_id")
                        .HasColumnType("bigint");

                    b.Property<bool>("Hidden")
                        .HasColumnName("hidden")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_catalogs");

                    b.HasIndex("CatalogDefinitionId")
                        .HasName("ix_catalogs_catalog_definition_id");

                    b.ToTable("catalog");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.CatalogDefinition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_catalog_definitions");

                    b.ToTable("catalog_definition");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.CatalogFieldValue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CatalogId")
                        .HasColumnName("catalog_id")
                        .HasColumnType("bigint");

                    b.Property<long?>("FieldId")
                        .HasColumnName("field_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Ids")
                        .HasColumnName("ids")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_catalog_field_values");

                    b.HasIndex("CatalogId")
                        .HasName("ix_catalog_field_values_catalog_id");

                    b.HasIndex("FieldId")
                        .HasName("ix_catalog_field_values_field_id");

                    b.ToTable("catalog_field_value");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Field", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CatalogDefinitionId")
                        .HasColumnName("catalog_definition_id")
                        .HasColumnType("bigint");

                    b.Property<string>("FieldName")
                        .HasColumnName("field_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldType")
                        .HasColumnName("field_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ForeignId")
                        .HasColumnName("foreign_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_catalog_fields");

                    b.HasIndex("ForeignId")
                        .HasName("ix_catalog_fields_foreign_id");

                    b.ToTable("catalog_field");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.MDC", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovalStatus")
                        .HasColumnName("approval_status")
                        .HasColumnType("int");

                    b.Property<string>("AssignedBy")
                        .HasColumnName("assigned_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnName("assigned_to")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckedoutBy")
                        .HasColumnName("checkedout_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnName("comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControlNumber")
                        .HasColumnName("control_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentArea")
                        .HasColumnName("department_area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentStatus")
                        .HasColumnName("document_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentTitle")
                        .HasColumnName("document_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNeedTraining")
                        .HasColumnName("is_need_training")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("MDCDeadLine")
                        .HasColumnName("mdc_dead_line")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Owner")
                        .HasColumnName("owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessType")
                        .HasColumnName("process_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("RemovedAt")
                        .HasColumnName("removed_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RemovedBy")
                        .HasColumnName("removed_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevisionMessage")
                        .HasColumnName("revision_message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("RowVersion")
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UsedAt")
                        .HasColumnName("used_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_mdcs");

                    b.ToTable("mdc");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.MdcAttachmentFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApprovalFileStatus")
                        .HasColumnName("approval_file_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedBy")
                        .HasColumnName("assigned_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnName("assigned_to")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentsFolder")
                        .HasColumnName("attachments_folder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckedoutBy")
                        .HasColumnName("checkedout_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentStatus")
                        .HasColumnName("document_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileVersion")
                        .HasColumnName("file_version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("bit");

                    b.Property<long?>("MDCId")
                        .HasColumnName("mdc_id")
                        .HasColumnType("bigint");

                    b.Property<string>("MdcAttachment")
                        .HasColumnName("mdc_attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PeriodicReview")
                        .HasColumnName("periodic_review")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ReleaseDate")
                        .HasColumnName("release_date")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("RemovedAt")
                        .HasColumnName("removed_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RemovedBy")
                        .HasColumnName("removed_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevisionMessage")
                        .HasColumnName("revision_message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("RowVersion")
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UsedAt")
                        .HasColumnName("used_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_mdc_attachment_files");

                    b.HasIndex("MDCId")
                        .HasName("ix_mdc_attachment_files_mdc_id");

                    b.ToTable("mdc_attachment_file");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Token", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("ExpiresAt")
                        .HasColumnName("expires_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<long>("ForeignKey")
                        .HasColumnName("foreign_key")
                        .HasColumnType("bigint");

                    b.Property<string>("ForeignType")
                        .HasColumnName("foreign_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_tokens");

                    b.ToTable("token");
                });

            modelBuilder.Entity("Reusable.CRUD.Entities.Revision", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignedBy")
                        .HasColumnName("assigned_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnName("assigned_to")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckedoutBy")
                        .HasColumnName("checkedout_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentStatus")
                        .HasColumnName("document_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ForeignKey")
                        .HasColumnName("foreign_key")
                        .HasColumnType("bigint");

                    b.Property<string>("ForeignType")
                        .HasColumnName("foreign_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("RemovedAt")
                        .HasColumnName("removed_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RemovedBy")
                        .HasColumnName("removed_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RevisionMessage")
                        .HasColumnName("revision_message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("RowVersion")
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UsedAt")
                        .HasColumnName("used_at")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("pk_revisions");

                    b.ToTable("revision");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Approver", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.MDC", "MDC")
                        .WithMany("Approvers")
                        .HasForeignKey("MDCId")
                        .HasConstraintName("fk_approvers_mdcs_mdc_id");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.AttachmentFileComment", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.MdcAttachmentFile", "MdcAttachmentFile")
                        .WithMany("AttachmentFileComments")
                        .HasForeignKey("MdcAttachmentFileId")
                        .HasConstraintName("fk_attachment_file_comments_mdc_attachment_files_mdc_attachment_file_id");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Catalog", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.CatalogDefinition", "CatalogDefinition")
                        .WithMany()
                        .HasForeignKey("CatalogDefinitionId")
                        .HasConstraintName("fk_catalogs_catalog_definitions_catalog_definition_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Logic.Entities.CatalogFieldValue", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.Catalog", null)
                        .WithMany("Values")
                        .HasForeignKey("CatalogId")
                        .HasConstraintName("fk_catalog_field_values_catalogs_catalog_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyApp.Logic.Entities.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .HasConstraintName("fk_catalog_field_values_catalog_fields_field_id");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.Field", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.CatalogDefinition", "Foreign")
                        .WithMany("Fields")
                        .HasForeignKey("ForeignId")
                        .HasConstraintName("fk_catalog_fields_catalog_definitions_foreign_id");
                });

            modelBuilder.Entity("MyApp.Logic.Entities.MdcAttachmentFile", b =>
                {
                    b.HasOne("MyApp.Logic.Entities.MDC", "MDC")
                        .WithMany("MdcAttachmentFiles")
                        .HasForeignKey("MDCId")
                        .HasConstraintName("fk_mdc_attachment_files_mdcs_mdc_id");
                });
#pragma warning restore 612, 618
        }
    }
}
