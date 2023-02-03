using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Shopping.Models
{
    public partial class ShoponlContext : DbContext
    {
        public ShoponlContext()
        {
        }

        public ShoponlContext(string connectionString)
        {
        }

        public ShoponlContext(DbContextOptions<ShoponlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Catelogy> Catelogies { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<View1> View1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=ADMIN; UID=SA;PASSWORD=12345;DATABASE=Shoponl");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AdminPassword).HasMaxLength(50);
            });

            modelBuilder.Entity<Catelogy>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Catelogy");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdparent).HasColumnName("CategoryIDParent");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.HasOne(d => d.CategoryIdparentNavigation)
                    .WithMany(p => p.InverseCategoryIdparentNavigation)
                    .HasForeignKey(d => d.CategoryIdparent)
                    .HasConstraintName("FK_Catelogy_Catelogy");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Payment).HasMaxLength(50);

                entity.Property(e => e.Phivc).HasColumnType("money");

                entity.Property(e => e.PhoneNum).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CatelogyId).HasColumnName("CatelogyID");

                entity.Property(e => e.ProductDiscount).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.Property(e => e.ProductStatus).HasMaxLength(50);

                entity.Property(e => e.ProductUnit).HasMaxLength(50);

                entity.Property(e => e.ProductUrlvideo)
                    .HasMaxLength(50)
                    .HasColumnName("ProductURLVideo");

                entity.Property(e => e.RatingAvg).HasColumnName("RatingAVG");

                entity.HasOne(d => d.Catelogy)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatelogyId)
                    .HasConstraintName("FK_Product_Catelogy");
            });

            modelBuilder.Entity<ProductComment>(entity =>
            {
                entity.ToTable("ProductComment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RatingDate).HasColumnType("date");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductComments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductComment_Product");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.ProductFk).HasColumnName("ProductFK");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNum).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Expr1).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
