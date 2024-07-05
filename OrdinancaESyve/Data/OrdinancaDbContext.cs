using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrdinancaESyve.Model;

namespace OrdinancaESyve.Data
{
    public class OrdinancaDbContext : DbContext
    {
        public OrdinancaDbContext(DbContextOptions<OrdinancaDbContext> options) : base(options)
        {
        }

        public DbSet<Doktori> Doktori { get; set; }
        public DbSet<Klinika> Klinika { get; set; }
        public DbSet<Pacienti> Pacienti { get; set; }
        public DbSet<Raporti> Raporti { get; set; }
        public DbSet<Rradha> Rradha { get; set; }
        public DbSet<Administrata> Administrata { get; set; }
        public DbSet<Historia> Historia { get; set; }

        public Pacienti AddPatient(Pacienti pacienti)
        {
            try
            {
                this.Pacienti.Add(pacienti);
                SaveChanges();
                return pacienti;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.InnerException);
                return null;
            }
        }

        public Administrata AddAdmin(Administrata admin)
        {
            try
            {
                this.Administrata.Add(admin);
                SaveChanges();
                return admin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.InnerException);
                return null;
            }
        }

        public Doktori AddDoctor(Doktori doktori)
        {
            try
            {
                this.Doktori.Add(doktori);
                SaveChanges();
                return doktori;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.InnerException);
                return null;
            }
        }

        public Historia AddHistory(Historia historia)
        {
            try
            {
                this.Historia.Add(historia);
                SaveChanges();
                return historia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.InnerException);
                return null;
            }
        }
    }


}
