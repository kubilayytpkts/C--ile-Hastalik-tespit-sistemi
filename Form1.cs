namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            metot();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string kullanıcıTc = girişTckimlik.Text;
            string kullanıcıYas = girişYaş.Text;
            
            

            Kullanıcı dneme = KullanıcıSanaldatabase.KullanıcıDB.Find(i => i.Tckimlik == kullanıcıTc & i.yaş == kullanıcıYas);

            if(dneme==null)
            {
                foreach (var item in KullanıcıSanaldatabase.KullanıcıDB)
                {
                    item.Tckimlik = kullanıcıTc;
                    item.yaş = kullanıcıYas;
                    
                }
            }
            else
            {

            }

            Hastalık_Semptomları_tespit formgiris = new Hastalık_Semptomları_tespit();

            formgiris.ShowDialog();
            


        }

        private void girişCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox deger = (ComboBox)sender;
            string denemecinsiyet = deger.Text;
            Kullanıcı deneme = KullanıcıSanaldatabase.KullanıcıDB.Find(i => i.Cinsiyet == denemecinsiyet);
            if(deneme==null)
            {
                foreach (var item in KullanıcıSanaldatabase.KullanıcıDB)
                {
                    item.Cinsiyet = denemecinsiyet;
                }
            }
            
        }
        private void metot()
        {
            foreach (var item in KullanıcıSanaldatabase.Kullanıcıcinsiyet)
            {
                girişCinsiyet.Items.Add(item);
            }
        }
    }
}