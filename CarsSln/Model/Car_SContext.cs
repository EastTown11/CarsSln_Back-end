using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CarsSln.Model
{
    public partial class Car_SContext : DbContext
    {
        public Car_SContext()
        {
        }

        public Car_SContext(DbContextOptions<Car_SContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarAccident> CarAccidents { get; set; }
        public virtual DbSet<CarAccidentDet> CarAccidentDets { get; set; }
        public virtual DbSet<CarCheckupItemDaily> CarCheckupItemDailies { get; set; }
        public virtual DbSet<CarColor> CarColors { get; set; }
        public virtual DbSet<CarCompany> CarCompanies { get; set; }
        public virtual DbSet<CarComponent> CarComponents { get; set; }
        public virtual DbSet<CarDailyCheckUp> CarDailyCheckUps { get; set; }
        public virtual DbSet<CarDailyCheckUpDet> CarDailyCheckUpDets { get; set; }
        public virtual DbSet<CarExpense> CarExpenses { get; set; }
        public virtual DbSet<CarInfo> CarInfos { get; set; }
        public virtual DbSet<CarInfoComponent> CarInfoComponents { get; set; }
        public virtual DbSet<CarInfoFile> CarInfoFiles { get; set; }
        public virtual DbSet<CarInfoPhoto> CarInfoPhotos { get; set; }
        public virtual DbSet<CarInsuranceComp> CarInsuranceComps { get; set; }
        public virtual DbSet<CarMaintDirection> CarMaintDirections { get; set; }
        public virtual DbSet<CarMaintenance> CarMaintenances { get; set; }
        public virtual DbSet<CarMaintenanceDet> CarMaintenanceDets { get; set; }
        public virtual DbSet<CarMaintenanceExpensesPeriodic> CarMaintenanceExpensesPeriodics { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }
        public virtual DbSet<CarPenalety> CarPenaleties { get; set; }
        public virtual DbSet<CarPenaletyDet> CarPenaletyDets { get; set; }
        public virtual DbSet<CarTask> CarTasks { get; set; }
        public virtual DbSet<CarTransaction> CarTransactions { get; set; }
        public virtual DbSet<CarTransactionsCompanion> CarTransactionsCompanions { get; set; }
        public virtual DbSet<CarType> CarTypes { get; set; }
        public virtual DbSet<ClMenu> ClMenus { get; set; }
        public virtual DbSet<ClPageMenu> ClPageMenus { get; set; }
        public virtual DbSet<HrEmployee> HrEmployees { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PagesInRole> PagesInRoles { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<CarAccident>(entity =>
            {
                entity.HasKey(e => e.AccidentId);

                entity.ToTable("CarAccident");

                entity.Property(e => e.AccidentId)
                    .HasColumnName("accidentID")
                    .HasComment("مسلسل الحادثة");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السياره");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ");

                entity.Property(e => e.Descrption)
                    .IsRequired()
                    .HasColumnName("descrption");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("Is_Closed")
                    .HasComment("0- لم يستخدم هذا المحضر فى الصيانه\r\n1- تم استخدام هذا المحضر فى الصيانه و اغلق");

                entity.Property(e => e.MaintenanceReq)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الصيانه المطلوبه");

                entity.Property(e => e.PlacesAccidnt)
                    .HasMaxLength(250)
                    .HasComment("مكان الحادثه");

                entity.Property(e => e.Time)
                    .HasMaxLength(150)
                    .HasColumnName("time")
                    .HasComment("وقت الحاثه");

                entity.Property(e => e.TimeReq)
                    .HasMaxLength(150)
                    .HasComment("الوقت المطلوب لليانه");

                entity.Property(e => e.TotalCost).HasComment("التكلفه الاجماليه");

                entity.Property(e => e.TypeFlg)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-تسجيل الحوادث\r\n2- طلب صيانه");
            });

            modelBuilder.Entity<CarAccidentDet>(entity =>
            {
                entity.HasKey(e => e.AccidentDetId);

                entity.ToTable("CarAccidentDet");

                entity.Property(e => e.AccidentDetId).HasColumnName("AccidentDetID");

                entity.Property(e => e.AccidentId).HasColumnName("accidentID");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("-صيانه اجزاء\r\n2- تركيب اجزاء جديدة");
            });

            modelBuilder.Entity<CarCheckupItemDaily>(entity =>
            {
                entity.HasKey(e => e.CheckupItemId);

                entity.ToTable("CarCheckupItemDaily");

                entity.Property(e => e.CheckupItemId)
                    .HasColumnName("CheckupItemID")
                    .HasComment("مسلسل بنود الفحص اليومى");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasComment("اسم البند");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes")
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarColor>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.ToTable("CarColor");

                entity.Property(e => e.ColorId)
                    .HasColumnName("ColorID")
                    .HasComment("مسلسل اللون");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("color")
                    .HasComment("اللون");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes")
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasComment("مسلسل الشركه المنتجه للسياره");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الشركه");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarComponent>(entity =>
            {
                entity.HasKey(e => e.ComponentId);

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("مسلسل مكونات السياره");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("اسم الجزء");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Type).HasComment("النوع\r\n1- مكونات رئيسيه\r\n2- مكونات ضافية");
            });

            modelBuilder.Entity<CarDailyCheckUp>(entity =>
            {
                entity.HasKey(e => e.DailyChkupdId);

                entity.ToTable("CarDailyCheckUp");

                entity.Property(e => e.DailyChkupdId)
                    .HasColumnName("dailyChkupdID")
                    .HasComment("مسلسل الكشف اليومى");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarDailyCheckUpDet>(entity =>
            {
                entity.HasKey(e => e.DailyChkupdDetId);

                entity.ToTable("CarDailyCheckUpDet");

                entity.Property(e => e.DailyChkupdDetId)
                    .HasColumnName("dailyChkupdDetID")
                    .HasComment("مسلسل تفاصيل الكشف اليومى");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السيارة");

                entity.Property(e => e.CheckupItemId).HasColumnName("CheckupItemID");

                entity.Property(e => e.DailyChkupdId)
                    .HasColumnName("dailyChkupdID")
                    .HasComment("مسلسل الكشف اليومى");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Status).HasComment("0- لم يتم\r\n1- تم بنجاح\r\n2- تم و تحول الى الصيانة");
            });

            modelBuilder.Entity<CarExpense>(entity =>
            {
                entity.HasKey(e => e.ExpensesId);

                entity.Property(e => e.ExpensesId)
                    .HasColumnName("ExpensesID")
                    .HasComment("مسلسل المصاريف الدوريه");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasComment("المصاريف الدوريه الاسم");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarInfo>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("CarInfo");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السياره");

                entity.Property(e => e.CapMotors)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasComment("سعه الموتور");

                entity.Property(e => e.ChaseNo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("chaseNo")
                    .HasComment("رقم الشاسيه");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("كود السياره_رقمها");

                entity.Property(e => e.CodeGps)
                    .HasMaxLength(350)
                    .HasColumnName("CodeGPS")
                    .HasComment("كود الجى بى اس");

                entity.Property(e => e.ColorId)
                    .HasColumnName("ColorID")
                    .HasComment("مسلسل اللون");

                entity.Property(e => e.DateBuy)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ الشراء");

                entity.Property(e => e.DateEndInsurance)
                    .HasColumnType("smalldatetime")
                    .HasComment("نهايه فترة الضمان");

                entity.Property(e => e.DateEndLicens)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ نهايه الرخصه");

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("InsuranceID")
                    .HasComment("مسلسل شركه التامين");

                entity.Property(e => e.LicenseNo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("licenseNO")
                    .HasComment("رقم رخصه السياره");

                entity.Property(e => e.LinkGps)
                    .HasMaxLength(350)
                    .HasColumnName("LinkGPS")
                    .HasComment("لينك ال جى بى اس");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasComment("مسلسل الموديل");

                entity.Property(e => e.MotorsNo)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasComment("رقم الماتور");

                entity.Property(e => e.Notes)
                    .HasMaxLength(350)
                    .HasComment("ملاحظات");

                entity.Property(e => e.PeriodOfInsurance)
                    .HasMaxLength(300)
                    .HasComment("فترة الضمان");

                entity.Property(e => e.Photo)
                    .HasMaxLength(200)
                    .HasColumnName("photo")
                    .HasComment("الصوره");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("حاله السياره\r\n1- متاحه\r\n2- غير متاحه\r\n3- فى الصيانه\r\n4- خارج الخدمه");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.CarInfos)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarInfo_CarColor");

                entity.HasOne(d => d.Insurance)
                    .WithMany(p => p.CarInfos)
                    .HasForeignKey(d => d.InsuranceId)
                    .HasConstraintName("FK_CarInfo_CarInsuranceComp");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.CarInfos)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarInfo_CarModels");
            });

            modelBuilder.Entity<CarInfoComponent>(entity =>
            {
                entity.HasKey(e => e.ComponentCarId);

                entity.Property(e => e.ComponentCarId).HasColumnName("ComponentCarID");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السيارات");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("مسلسل المكونلت");

                entity.Property(e => e.IsHave)
                    .HasColumnName("Is_have")
                    .HasComment("0- لا يوجد هذا المكون من مكونات السياره\r\n1- تمتلك السياره هذا الجزء");

                entity.Property(e => e.Notes).HasMaxLength(250);
            });

            modelBuilder.Entity<CarInfoFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .HasComment("مسلسل الملف");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل الجدول الاب لهذه الملفات");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("اسم الملف على القرص الصلب");

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(50)
                    .HasComment("عنوان الملف الذي يظهر في التعامل داخل البرنامج");
            });

            modelBuilder.Entity<CarInfoPhoto>(entity =>
            {
                entity.HasKey(e => e.CarImageId);

                entity.Property(e => e.CarImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("CarImageID")
                    .HasComment("مسلسل صورة السيارة");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السيارة");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("image")
                    .HasComment("الصورة");
            });

            modelBuilder.Entity<CarInsuranceComp>(entity =>
            {
                entity.HasKey(e => e.InsuranceId);

                entity.ToTable("CarInsuranceComp");

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("InsuranceID")
                    .HasComment("مسلسل شركه التأمين");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasComment("شركه التأمين");

                entity.Property(e => e.Notes).HasMaxLength(250);
            });

            modelBuilder.Entity<CarMaintDirection>(entity =>
            {
                entity.HasKey(e => e.MaintDirectionId);

                entity.ToTable("CarMaintDirection");

                entity.Property(e => e.MaintDirectionId)
                    .HasColumnName("MaintDirectionID")
                    .HasComment("مسلسل جهات الصيانه");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الاسم");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarMaintenance>(entity =>
            {
                entity.HasKey(e => e.MaintenanceId);

                entity.ToTable("CarMaintenance");

                entity.Property(e => e.MaintenanceId)
                    .HasColumnName("MaintenanceID")
                    .HasComment("مسلسل الصيانه");

                entity.Property(e => e.AccidentId)
                    .HasColumnName("accidentID")
                    .HasComment("مسلسل محضر الحوادث او طلب صيانه\r\nفى حاله التسجيل من محضر الحوادث او طلب الصيانة");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السياره");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("مسلسل الموظف");

                entity.Property(e => e.Notes)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ReasonReqMaintenance)
                    .HasMaxLength(350)
                    .HasComment("السبب من طلب الصيانه");

                entity.Property(e => e.ReportMaintenance)
                    .HasMaxLength(350)
                    .HasComment("الصيانه اللازمة للسيارة");

                entity.Property(e => e.TotalCost).HasComment("التكلفه الكليه");

                entity.Property(e => e.TypeFlg).HasComment("النوع\r\n1- صيانه\r\n2- تسجيل المصروفات الدورية");
            });

            modelBuilder.Entity<CarMaintenanceDet>(entity =>
            {
                entity.HasKey(e => e.MaintenanceDetId);

                entity.ToTable("CarMaintenanceDet");

                entity.Property(e => e.MaintenanceDetId)
                    .HasColumnName("MaintenanceDetID")
                    .HasComment("مسلسل تفاصيل الصيانه");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasComment("مسلسل المكونات");

                entity.Property(e => e.Cost).HasComment("التكلفه");

                entity.Property(e => e.MaintDirectionId)
                    .HasColumnName("MaintDirectionID")
                    .HasComment("مسلسل جهه الصيانه - فى حاله الصيانه");

                entity.Property(e => e.MaintenanceId)
                    .HasColumnName("MaintenanceID")
                    .HasComment("مسلسل الصيانه");

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .HasComment("ملاحظات");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(150)
                    .HasComment("رقم الفاتوره");

                entity.Property(e => e.SuppId)
                    .HasColumnName("Supp_Id")
                    .HasComment("مسلسل المورد- فى حاله قطع الغيار");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1-صيانه اجزاء\r\n2- تركيب اجزاء جديدة\r\nصيانه - المروفات الدورية-3");
            });

            modelBuilder.Entity<CarMaintenanceExpensesPeriodic>(entity =>
            {
                entity.HasKey(e => e.ExpensesPeriodId)
                    .HasName("PK_CarExpensesPeriodic");

                entity.ToTable("CarMaintenanceExpensesPeriodic");

                entity.Property(e => e.ExpensesPeriodId)
                    .HasColumnName("ExpensesPeriodID")
                    .HasComment("مسلسل صيانه الماريف الدوريه");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل اسياره - فى حاله ان الكشف الدورى منفصل عن الصيانه");

                entity.Property(e => e.Cost).HasComment("التكلفه");

                entity.Property(e => e.ExpensesId)
                    .HasColumnName("ExpensesID")
                    .HasComment("مسلسل المصاريف الدوريه");

                entity.Property(e => e.MaintenanceId)
                    .HasColumnName("MaintenanceID")
                    .HasComment("مسلسل الصيانه- فى حاله انها تتبع كشف الصيانه");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasComment("مسلسل موديل السيارة");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("الموديل");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasComment("مسلسل نوع السياره");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CarModels)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CarModels_CarCompanies");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CarModels)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CarModels_CarTypes");
            });

            modelBuilder.Entity<CarPenalety>(entity =>
            {
                entity.HasKey(e => e.PenaletyId);

                entity.ToTable("CarPenalety");

                entity.Property(e => e.PenaletyId)
                    .HasColumnName("PenaletyID")
                    .HasComment("مسلسل محضر المخالفات");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");
            });

            modelBuilder.Entity<CarPenaletyDet>(entity =>
            {
                entity.HasKey(e => e.PenaletyDetId);

                entity.ToTable("CarPenaletyDet");

                entity.Property(e => e.PenaletyDetId)
                    .HasColumnName("PenaletyDetID")
                    .HasComment("مسلسل تفاصيل المخالفات");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.Cost).HasComment("قيمه الغرامة");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ المخالفه");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("السائق المسئول");

                entity.Property(e => e.FilePath).HasMaxLength(250);

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(250)
                    .HasComment("ملف المخالفة");

                entity.Property(e => e.NoPenalety).HasComment("رقم المخالفة");

                entity.Property(e => e.PenaletyId)
                    .HasColumnName("PenaletyID")
                    .HasComment("مسلسل محضر المخالفات");

                entity.Property(e => e.Time)
                    .HasMaxLength(150)
                    .HasComment("وقت المخالفة");
            });

            modelBuilder.Entity<CarTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasComment("مسلس المهمه");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Task)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("المهمه");
            });

            modelBuilder.Entity<CarTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasComment("مسلسل الحركه");

                entity.Property(e => e.BackDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ العودة للسياره");

                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .HasComment("مسلسل السياره");

                entity.Property(e => e.CurrentMeter)
                    .HasMaxLength(150)
                    .HasColumnName("Current_meter")
                    .HasComment("قرائه العداد الحالى قبل الخروج");

                entity.Property(e => e.CurrentMoterBack)
                    .HasMaxLength(10)
                    .HasColumnName("CurrentMoter_Back")
                    .IsFixedLength(true)
                    .HasComment("قرائه العداد بعد العوده");

                entity.Property(e => e.EmployeeIdDriver)
                    .HasColumnName("EmployeeID_driver")
                    .HasComment("السائق");

                entity.Property(e => e.EmployeeIdRecived)
                    .HasColumnName("EmployeeID_Recived")
                    .HasComment("مسلسل الموظف المستلم");

                entity.Property(e => e.Notes)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("ملاحظات");

                entity.Property(e => e.OtherDirection)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("مشاوير اخرى");

                entity.Property(e => e.OutDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ الخروج");

                entity.Property(e => e.PathCar)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("مسار السياره");

                entity.Property(e => e.ProtectionLongDate)
                    .HasColumnType("smalldatetime")
                    .HasComment("التاريخ للعهدة طويله الاجل");

                entity.Property(e => e.ProtectionShortTime).HasComment("الوقت (الساعه) للعهدة قيرة الاجل ");

                entity.Property(e => e.ProtectionType).HasComment("نوع العهدة\r\n0- قيصيره الاجل\r\n1- طويله الاجل");
            });

            modelBuilder.Entity<CarTransactionsCompanion>(entity =>
            {
                entity.HasKey(e => e.TransEmployeeId);

                entity.ToTable("CarTransactionsCompanion");

                entity.Property(e => e.TransEmployeeId)
                    .HasColumnName("TransEmployeeID")
                    .HasComment("مسلسل المرافقين بالسياره");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("مسلسل الموظف");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasComment("مسلسل الحركه");
            });

            modelBuilder.Entity<CarType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasComment("مسلسل نوع السياره");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasComment("النوع");
            });

            modelBuilder.Entity<ClMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("clMenus");

                entity.HasComment("قوائم الاسعار المختلفة للشركات");

                entity.HasIndex(e => e.MenuName, "IX_clMenus")
                    .IsUnique();

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.DiscountRatio).HasComment("نسبة الخصم الافتراضية");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("اسم القائمة");

                entity.Property(e => e.Notes).HasComment("ملاحظات");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("النوع \r\n1- خصم\r\n2- زياده \r\nمعنى زياده  انه ممكن تستخدم الشركه نظام اجل فيتم زياده للاسعار لها ");
            });

            modelBuilder.Entity<ClPageMenu>(entity =>
            {
                entity.HasKey(e => e.MenuItemId)
                    .HasName("PK_cl_Menus");

                entity.ToTable("cl_Page_Menus");

                entity.Property(e => e.MenuItemId).HasColumnName("Menu_ItemID");

                entity.Property(e => e.ItemNameAr)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Item_Name_Ar");

                entity.Property(e => e.ItemNameEg)
                    .HasMaxLength(150)
                    .HasColumnName("Item_Name_Eg");

                entity.Property(e => e.ItemPage)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Item_Page");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.PageId).HasColumnName("PageID");
            });

            modelBuilder.Entity<HrEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("hrEmployees");

                entity.HasComment("جدول بيانات الموظفين - بيانات أساسية");

                entity.HasIndex(e => e.EmployeeCode, "IX_hrEmployees_1")
                    .IsUnique();

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("رقم مسلسل للجدول");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ التعيين");

                entity.Property(e => e.BankAccount).HasMaxLength(200);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BusinessCardNo).HasMaxLength(50);

                entity.Property(e => e.BusinessEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasComment("رقم مسلسل الفئة");

                entity.Property(e => e.CheckFinger).HasComment("له توقيع حضور فى دفتر الحضور (البصمه)");

                entity.Property(e => e.ContractNo).HasMaxLength(200);

                entity.Property(e => e.ContractType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateEndContract)
                    .HasColumnType("smalldatetime")
                    .HasComment("تاريخ نهاية التعاقد");

                entity.Property(e => e.DepId)
                    .HasColumnName("DepID")
                    .HasComment("رقم مسلسل القسم");

                entity.Property(e => e.DocSalaryType).HasComment("نوع الاجر في حالة الاطباء\r\n===============\r\n1 اجر يومي ثابت\r\n2 اجر شهري ثابت\r\n3 نسبة من الايراد الشهري\r\n4 قيمة ثابتة للحالة\r\n5 متطوع مجاني");

                entity.Property(e => e.DocSalaryValue).HasComment("قيمة اجر الطبيب حسب نوعه\r\n=====================\r\nقيمة يوم الاجر اليومي\r\nقيمة شهر الاجر الشهري\r\nنسبة الايراد\r\nقيمة الحالة");

                entity.Property(e => e.DriveLicenseEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DriveLicenseIssuePlace).HasMaxLength(50);

                entity.Property(e => e.DriveLicenseNo).HasMaxLength(50);

                entity.Property(e => e.DriveLicenseStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DutyPositionType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("الموقف من الخدمة فى الشركة : 1 - داخل الخدمة   &   2 - خارج الخدمة");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.EmployeeAddress)
                    .HasMaxLength(250)
                    .HasComment("العنوان");

                entity.Property(e => e.EmployeeBirthDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ الميلاد");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("كود الموظف - لابد من الإدخال - لا يكرر");

                entity.Property(e => e.EmployeeHireType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("نوع عمل الموظف  \r\n1- FullTime \r\n2- PartTime");

                entity.Property(e => e.EmployeeMoble).HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("اسم الموظف - لابد من الإدخال - لا يكرر");

                entity.Property(e => e.EmployeeNotes)
                    .HasMaxLength(200)
                    .HasComment("ملاحظات");

                entity.Property(e => e.EmployeePhoto)
                    .HasMaxLength(100)
                    .HasComment("صورة الموظف");

                entity.Property(e => e.EmployeeSexType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("نوع الجنس : 1 - ذكر   &   2 - أنثى");

                entity.Property(e => e.EmployeeTelephones)
                    .HasMaxLength(150)
                    .HasComment("التليفونات");

                entity.Property(e => e.ExPerianceHist)
                    .HasMaxLength(500)
                    .HasComment("الخبرات السابقة");

                entity.Property(e => e.ExperianceNo)
                    .HasMaxLength(150)
                    .HasColumnName("ExperianceNO")
                    .HasComment("عدد سنوات الخبرة");

                entity.Property(e => e.HealthEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HealthId)
                    .HasMaxLength(50)
                    .HasColumnName("HealthID");

                entity.Property(e => e.HealthcardNo)
                    .HasMaxLength(50)
                    .HasColumnName("healthcardNo");

                entity.Property(e => e.IdentityCardDate)
                    .HasColumnType("datetime")
                    .HasComment("تاريخ صدور تحقيق الشخصية");

                entity.Property(e => e.IdentityCardNo)
                    .HasMaxLength(50)
                    .HasComment("رقم تحقيق الشخصية");

                entity.Property(e => e.IdentityCardPlace)
                    .HasMaxLength(250)
                    .HasComment("مكان صدور تحقيق الشخصية");

                entity.Property(e => e.IdentityCardTypeId)
                    .HasColumnName("IdentityCardTypeID")
                    .HasComment("رقم مسلسل نوع تحقيق الشخصية");

                entity.Property(e => e.IsWork)
                    .HasColumnName("Is_work")
                    .HasComment("1- لا يزال يعمل بالمؤسسة\r\n2- ترك المؤسسة");

                entity.Property(e => e.NameEmpByenglish)
                    .HasMaxLength(250)
                    .HasColumnName("NameEmpBYEnglish");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OutDutyDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OutDutyReason).HasMaxLength(200);

                entity.Property(e => e.PassportEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PassportIssuePlace).HasMaxLength(50);

                entity.Property(e => e.PassportNo).HasMaxLength(50);

                entity.Property(e => e.PassportStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PayedTypeSalary).HasComment("طريقة دفع المرتب\r\n1- نقدى\r\n2- بنكى\r\n");

                entity.Property(e => e.PersonalId)
                    .HasMaxLength(50)
                    .HasColumnName("PersonalID");

                entity.Property(e => e.PersonalNo).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Qualification).HasMaxLength(250);

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ResidenceEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ResidenceIssuePlace).HasMaxLength(50);

                entity.Property(e => e.ResidenceNo).HasMaxLength(50);

                entity.Property(e => e.ResidenceStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SocialSecurityNo).HasMaxLength(50);

                entity.Property(e => e.SocialStatusTypeId)
                    .HasColumnName("SocialStatusTypeID")
                    .HasComment("رقم مسلسل نوع الحالة الإجتماعية");

                entity.Property(e => e.Validity).HasMaxLength(50);

                entity.Property(e => e.WorkOfficeRegDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOfficeRegistration)
                    .HasMaxLength(50)
                    .HasComment("قيد مكتب العمل");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Order).HasComment("ترتيب الظهور في الجريدات");

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .HasComment("اسم الصفحة");

                entity.Property(e => e.PageProjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("اسم الصفحة في المشروع");

                entity.Property(e => e.PageType).HasComment("نوعها\r\n1 صفحة عادية \r\n2 صفحة صلاحيتها نعم او لا ولا يوجد صلاحية للحذف او التعديل او الاضافة");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasComment("المشروع التابعه له الصفة");
            });

            modelBuilder.Entity<PagesInRole>(entity =>
            {
                entity.HasKey(e => e.UserPageId)
                    .HasName("PK_UserPages");

                entity.ToTable("PagesInRole");

                entity.Property(e => e.UserPageId).HasColumnName("UserPageID");

                entity.Property(e => e.PageId)
                    .HasColumnName("PageID")
                    .HasComment("الصفحة");

                entity.Property(e => e.PagePer).HasComment("0 Not Allow\r\n1 Read only\r\n2 Modify\r\n3 Modify And Delete");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("المجموعة");

                entity.Property(e => e.UserStampPer).HasComment("صلاحية رؤية اضافات المستخدمين");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.PagesInRoles)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_PagesInRole_Pages");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PagesInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_PagesInRole_Roles");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProjectID");

                entity.Property(e => e.ProjectLink).HasMaxLength(250);

                entity.Property(e => e.ProjectName).HasMaxLength(250);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasComment("صلاحيات المستخدمين\r\n================\r\nيوجد بعض المجموعات ثابته بالاكواد التالية\r\n0 الميدرون العموميون\r\n1 المحسنين\r\n2 المكاتب التنفيذية\r\n3 المتطوعين و الجمعيات المتعاونة\r\n=================\r\nوهذه المجموعات لا يمكن حذفها");

                entity.HasIndex(e => e.RoleName, "IX_Roles")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("مجموعة الصلاحيات");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Deleted).HasComment("تم حذفه\r\nو هذا لمنع حذف اي مستخدم لما له من تأثير على طابع المستخدم");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasComment("ملاحظات");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("كلمة السر");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("مجموعة الصلاحيات");

                entity.Property(e => e.UserAllow).HasComment("السماح بالدخول");

                entity.Property(e => e.UserFullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("الاسم بالكامل");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("اسم الدخول");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Users_hrEmployees");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
