using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using oval.models;

namespace ovalspace.Migrations
{
    [DbContext(typeof(OvalContext))]
    [Migration("20160723220010_AddedMoreFieldsToSpace")]
    partial class AddedMoreFieldsToSpace
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("oval.models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("SpaceID");

                    b.Property<DateTime>("When");

                    b.HasKey("ID");

                    b.HasIndex("SpaceID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("oval.models.Space", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("oval.models.Event", b =>
                {
                    b.HasOne("oval.models.Space")
                        .WithMany("Events")
                        .HasForeignKey("SpaceID");
                });
        }
    }
}
