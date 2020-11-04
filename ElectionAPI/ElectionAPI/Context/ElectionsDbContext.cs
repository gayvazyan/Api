using System;
using ElectionAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ElectionAPI.Context
{
    public partial class ElectionsDbContext : DbContext
    {
        public ElectionsDbContext()
        {
        }

        public ElectionsDbContext(DbContextOptions<ElectionsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CandidatePersons> CandidatePersons { get; set; }
        public virtual DbSet<CandidateStates> CandidateStates { get; set; }
        public virtual DbSet<CandidateStatesEn> CandidateStatesEn { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<CandidatesResults> CandidatesResults { get; set; }
        public virtual DbSet<CandidatesResults1> CandidatesResults1 { get; set; }
        public virtual DbSet<CandidatesResults2> CandidatesResults2 { get; set; }
        public virtual DbSet<CandidatesResultsElectronic> CandidatesResultsElectronic { get; set; }
        public virtual DbSet<CandidatesResultsForDiagram> CandidatesResultsForDiagram { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CommissionElect> CommissionElect { get; set; }
        public virtual DbSet<CommissionPersonState> CommissionPersonState { get; set; }
        public virtual DbSet<CommissionPersons> CommissionPersons { get; set; }
        public virtual DbSet<Commissions> Commissions { get; set; }
        public virtual DbSet<Communitis> Communitis { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<ElectTypeAccess> ElectTypeAccess { get; set; }
        public virtual DbSet<ElectionDecisions> ElectionDecisions { get; set; }
        public virtual DbSet<ElectionStates> ElectionStates { get; set; }
        public virtual DbSet<ElectionTypes> ElectionTypes { get; set; }
        public virtual DbSet<Elections> Elections { get; set; }
        public virtual DbSet<ElectiveResults> ElectiveResults { get; set; }
        public virtual DbSet<ElectiveResults2> ElectiveResults2 { get; set; }
        public virtual DbSet<ElectiveResultsElectronic> ElectiveResultsElectronic { get; set; }
        public virtual DbSet<ElectiveResultsForDiagram> ElectiveResultsForDiagram { get; set; }
        public virtual DbSet<GridWorking> GridWorking { get; set; }
        public virtual DbSet<IntermediateInfo> IntermediateInfo { get; set; }
        public virtual DbSet<IntermediateResults> IntermediateResults { get; set; }
        public virtual DbSet<Minorities> Minorities { get; set; }
        public virtual DbSet<OrganizationTypes> OrganizationTypes { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<PartieOrParty> PartieOrParty { get; set; }
        public virtual DbSet<PartieOrPartyList> PartieOrPartyList { get; set; }
        public virtual DbSet<PartieOrPartyPersons> PartieOrPartyPersons { get; set; }
        public virtual DbSet<PartieOrPartyPersonsResults> PartieOrPartyPersonsResults { get; set; }
        public virtual DbSet<PartieOrPartyPersonsResults2> PartieOrPartyPersonsResults2 { get; set; }
        public virtual DbSet<PartisInfo> PartisInfo { get; set; }
        public virtual DbSet<PecMember> PecMember { get; set; }
        public virtual DbSet<PecMemberElectResult> PecMemberElectResult { get; set; }
        public virtual DbSet<PecMemberLog> PecMemberLog { get; set; }
        public virtual DbSet<PecMemberPartyResult> PecMemberPartyResult { get; set; }
        public virtual DbSet<PecMemberSertificate> PecMemberSertificate { get; set; }
        public virtual DbSet<Protocols> Protocols { get; set; }
        public virtual DbSet<RecomOrg> RecomOrg { get; set; }
        public virtual DbSet<Recommendations> Recommendations { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<SeesionData> SeesionData { get; set; }
        public virtual DbSet<SubDistricts> SubDistricts { get; set; }
        public virtual DbSet<UmSys> UmSys { get; set; }
        public virtual DbSet<UmSysNonRep> UmSysNonRep { get; set; }
        public virtual DbSet<VCandidate> VCandidate { get; set; }
        public virtual DbSet<VCandidateParty> VCandidateParty { get; set; }
        public virtual DbSet<VCandidatePersons> VCandidatePersons { get; set; }
        public virtual DbSet<VCandidatesResults> VCandidatesResults { get; set; }
        public virtual DbSet<VCandidatesResults2> VCandidatesResults2 { get; set; }
        public virtual DbSet<VCandidatesResultsR> VCandidatesResultsR { get; set; }
        public virtual DbSet<VCommunitis> VCommunitis { get; set; }
        public virtual DbSet<VElections> VElections { get; set; }
        public virtual DbSet<VElectiveResults> VElectiveResults { get; set; }
        public virtual DbSet<VElectiveResults2> VElectiveResults2 { get; set; }
        public virtual DbSet<VElectiveResultsR> VElectiveResultsR { get; set; }
        public virtual DbSet<VExpCandidatePersons> VExpCandidatePersons { get; set; }
        public virtual DbSet<VExpCommissionPersons> VExpCommissionPersons { get; set; }
        public virtual DbSet<VExpEntrustingPersons> VExpEntrustingPersons { get; set; }
        public virtual DbSet<VExpPartieOrParty> VExpPartieOrParty { get; set; }
        public virtual DbSet<VExpPartieOrPartyPersons> VExpPartieOrPartyPersons { get; set; }
        public virtual DbSet<VGeoresults> VGeoresults { get; set; }
        public virtual DbSet<VPartieOrPartyPersons> VPartieOrPartyPersons { get; set; }
        public virtual DbSet<VResulteByDistrict> VResulteByDistrict { get; set; }
        public virtual DbSet<VSubDistricts> VSubDistricts { get; set; }
        public virtual DbSet<WatcherElectTypes> WatcherElectTypes { get; set; }
        public virtual DbSet<Watchers> Watchers { get; set; }
        public virtual DbSet<WebAnnouncement> WebAnnouncement { get; set; }
        public virtual DbSet<WebCec> WebCec { get; set; }
        public virtual DbSet<WebCecEmployee> WebCecEmployee { get; set; }
        public virtual DbSet<WebCecarx> WebCecarx { get; set; }
        public virtual DbSet<WebNews> WebNews { get; set; }
        public virtual DbSet<WebNotifications> WebNotifications { get; set; }
        public virtual DbSet<WebSessions> WebSessions { get; set; }
        public virtual DbSet<WorkPositionTypes> WorkPositionTypes { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-9GM7NOP\\SQLEXPRESS;Database=elections;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidatePersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Passport).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidatePersons)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatePersons_Candidates");
            });

            modelBuilder.Entity<CandidateStates>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CandidateStatesEn>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.Property(e => e.DistrictId).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsElected).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<CandidatesResults>(entity =>
            {
                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidatesResults");

                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_CandidatesResults_1");

                entity.Property(e => e.EnterDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidatesResults)
                    .HasForeignKey(d => d.CandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatesResults_Candidates");

                entity.HasOne(d => d.SubDistrict)
                    .WithMany(p => p.CandidatesResults)
                    .HasForeignKey(d => d.SubDistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatesResults_SubDistricts");
            });

            modelBuilder.Entity<CandidatesResults1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CandidatesResults2>(entity =>
            {
                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidatesResults2");

                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_CandidatesResults2_1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CandidatesResultsElectronic>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<CandidatesResultsForDiagram>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.CandidateId)
                    .HasName("IX_CandidatesResultsForDiagram");

                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_CandidatesResultsForDiagram_1");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pr)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CommissionElect>(entity =>
            {
                entity.Property(e => e.IsValide).HasDefaultValueSql("((1))");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CommissionPersonState>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<CommissionPersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<Commissions>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Communitis>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Consolidated).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Pr).IsFixedLength();

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.RegionCodeNavigation)
                    .WithMany(p => p.Communitis)
                    .HasForeignKey(d => d.RegionCode)
                    .HasConstraintName("FK_Communitis_Regions");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ElectTypeAccess>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ElectionDecisions>(entity =>
            {
                entity.Property(e => e.Additional).IsUnicode(false);

                entity.Property(e => e.ShowWeb).HasDefaultValueSql("((1))");

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ElectionStates>(entity =>
            {
                entity.Property(e => e.StateId).ValueGeneratedNever();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ElectionTypes>(entity =>
            {
                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ukey).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Elections>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.LocalDistrictId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.StateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.VisibleInWeb).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Elections_ElectionStates");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Elections_ElectionTypes");
            });

            modelBuilder.Entity<ElectiveResults>(entity =>
            {
                entity.Property(e => e.SubDistrictId).ValueGeneratedNever();

                entity.Property(e => e.BodyCountId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BodyListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CaughtListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Control).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnterDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NonRegListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCommListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoliceListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecinctListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");

                entity.Property(e => e.StationarListId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ElectiveResults2>(entity =>
            {
                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_ElectiveResults2");

                entity.Property(e => e.BodyCountId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BodyListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CaughtListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Control).HasDefaultValueSql("((0))");

                entity.Property(e => e.NonRegListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCommListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoliceListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecinctListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StationarListId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ElectiveResultsElectronic>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ElectiveResultsForDiagram>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_ElectiveResultsForDiagram");

                entity.Property(e => e.BodyCountId).HasDefaultValueSql("((0))");

                entity.Property(e => e.BodyListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CaughtListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Control).HasDefaultValueSql("((0))");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.NonRegListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherCommListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PoliceListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecinctListId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StationarListId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GridWorking>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IntermediateInfo>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<IntermediateResults>(entity =>
            {
                entity.HasIndex(e => e.InfoId)
                    .HasName("IX_IntermediateResults");

                entity.HasIndex(e => e.SubDistrictId)
                    .HasName("IX_IntermediateResults_1");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Minorities>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<OrganizationTypes>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Organizations>(entity =>
            {
                entity.Property(e => e.Comment).HasDefaultValueSql("(N'')");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.OrgCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sertificate).IsFixedLength();
            });

            modelBuilder.Entity<PartieOrParty>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<PartieOrPartyList>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.PartieOrParty)
                    .WithMany(p => p.PartieOrPartyList)
                    .HasForeignKey(d => d.PartieOrPartyId)
                    .HasConstraintName("FK_PartieOrPartyList_PartieOrParty");
            });

            modelBuilder.Entity<PartieOrPartyPersons>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.ElectedType).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsElected).HasDefaultValueSql("(0)");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<PartieOrPartyPersonsResults>(entity =>
            {
                entity.Property(e => e.EnterDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PartieOrPartyPersonsResults2>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<PartisInfo>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Visible).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PecMember>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<PecMemberElectResult>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<PecMemberLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<PecMemberSertificate>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Protocols>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PROTOCOLS");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<RecomOrg>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Recommendations>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<SeesionData>(entity =>
            {
                entity.Property(e => e.SessionId).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SubDistricts>(entity =>
            {
                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RegionCode).IsUnicode(false);

                entity.Property(e => e.Settlement).IsUnicode(false);

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.SubDistricts)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubDistricts_Elections");
            });

            modelBuilder.Entity<UmSys>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<UmSysNonRep>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<VCandidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidate");

                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidateParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidateParty");

                entity.Property(e => e.OrderNum).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidatePersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatePersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VCandidatesResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResults");
            });

            modelBuilder.Entity<VCandidatesResults2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResults2");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VCandidatesResultsR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCandidatesResultsR");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VCommunitis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCommunitis");

                entity.Property(e => e.CommunityCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VElections>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElections");

                entity.Property(e => e.CommunityCode).IsUnicode(false);
            });

            modelBuilder.Entity<VElectiveResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResults");
            });

            modelBuilder.Entity<VElectiveResults2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResults2");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VElectiveResultsR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElectiveResultsR");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VExpCandidatePersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpCandidatePersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpCommissionPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpCommissionPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpEntrustingPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpEntrustingPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VExpPartieOrParty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpPartieOrParty");
            });

            modelBuilder.Entity<VExpPartieOrPartyPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpPartieOrPartyPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VGeoresults>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGEOResults");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.OrderNum).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<VPartieOrPartyPersons>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPartieOrPartyPersons");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.Pn)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegionCode).IsUnicode(false);
            });

            modelBuilder.Entity<VResulteByDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vResulteByDistrict");
            });

            modelBuilder.Entity<VSubDistricts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSubDistricts");

                entity.Property(e => e.CommunityCode).IsUnicode(false);

                entity.Property(e => e.DistrictCode).IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubDistrictCode).IsUnicode(false);
            });

            modelBuilder.Entity<WatcherElectTypes>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Watchers>(entity =>
            {
                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sertificate)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Org)
                    .WithMany(p => p.Watchers)
                    .HasForeignKey(d => d.OrgId)
                    .HasConstraintName("FK_Watchers_Organizations");
            });

            modelBuilder.Entity<WebAnnouncement>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebCec>(entity =>
            {
                entity.Property(e => e.DecisionId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileEn).IsUnicode(false);
            });

            modelBuilder.Entity<WebCecEmployee>(entity =>
            {
                entity.Property(e => e.CecEmployId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.ImgUrl).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);
            });

            modelBuilder.Entity<WebCecarx>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.File).IsUnicode(false);

                entity.Property(e => e.FileEn).IsUnicode(false);
            });

            modelBuilder.Entity<WebNews>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<WebNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificatinId)
                    .HasName("PK_Notificatins");

                entity.Property(e => e.NotificatinId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.UId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WebSessions>(entity =>
            {
                entity.Property(e => e.FileUrl).IsUnicode(false);

                entity.Property(e => e.FileUrlEn).IsUnicode(false);

                entity.Property(e => e.VideoUrl).IsUnicode(false);
            });

            modelBuilder.Entity<WorkPositionTypes>(entity =>
            {
                entity.Property(e => e.WorkPositionId).ValueGeneratedNever();

                entity.Property(e => e.MsreplTranVersion).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
