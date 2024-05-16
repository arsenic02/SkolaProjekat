/*using NHibernate;
using SkolaProjekat.Entiteti;*/
//ovde je nepotrebno valjda
using NHibernate;
using ProjekatSkola.Entiteti;

namespace SkolaProjekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnUcitavanje_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    AngazovanSaDelomNorme? p = await session.LoadAsync<AngazovanSaDelomNorme>(61);//??
                    MessageBox.Show($"Angazovanje sa delom norme sa ID: 61 \"{p.NazivPredmeta}\" je pronađena.");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    AngazovanSaDelomNorme angSaDelomNorme = new()
                    {
                        JMBGNastavnika = "2102000436511",
                        NazivPredmeta = "Matematika",
                        DatumAngazovanja = DateTime.Now
                        /*
                        Naziv = "Emmi Shop 15",
                        Adresa = "Mačvanska 5",
                        BrojTelefona = "018/999-999",
                        RadniDan = "09-17",
                        Subota = "10-15",
                        Nedelja = "Ne radi" 
                        Id(p => p.JMBGNastavnika, "JMBG_NASTAVNIKA").GeneratedBy.Assigned();

                         Map(p => p.NazivPredmeta, "NAZIV_PREDMETA");
                            Map(p => p.DatumAngazovanja, "DATUM_ANGAZOVANJA");
                         */
                    };

                    //await session.SaveAsync(p);
                    await session.SaveOrUpdateAsync(angSaDelomNorme);
                    await session.FlushAsync();//sve modifikacije koje imamo budu prosledjene bazi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
    
    
