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
                session = DataLayer.GetSession();//ovde baca exception

                if (session != null)
                {
                    AngazovanSaDelomNorme? p = await session.LoadAsync<AngazovanSaDelomNorme>("4567890123456");//jmbg nastavnika
                                                                                                  // MessageBox.Show($"Angazovanje sa delom norme sa ID: 61 \"{p.NazivPredmeta}\" je pronađena.");

                    
                    MessageBox.Show($"Angazovanje sa delom norme sa ID: 4567890123456 \"{p.NazivPredmeta}\" je pronađeno.");
                    
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                session?.Close();//ovo i finally blok sam ja dodao
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
                        NazivPredmeta = "Matematika",
                        JMBGNastavnika = "2102000436511",
                        DatumAngazovanja = DateTime.Now  
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
    
    
