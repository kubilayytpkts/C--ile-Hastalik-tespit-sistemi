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
            
            string kullan�c�Tc = giri�Tckimlik.Text;
            string kullan�c�Yas = giri�Ya�.Text;
            
            

            Kullan�c� dneme = Kullan�c�Sanaldatabase.Kullan�c�DB.Find(i => i.Tckimlik == kullan�c�Tc & i.ya� == kullan�c�Yas);

            if(dneme==null)
            {
                foreach (var item in Kullan�c�Sanaldatabase.Kullan�c�DB)
                {
                    item.Tckimlik = kullan�c�Tc;
                    item.ya� = kullan�c�Yas;
                    
                }
            }
            else
            {

            }

            Hastal�k_Semptomlar�_tespit formgiris = new Hastal�k_Semptomlar�_tespit();

            formgiris.ShowDialog();
            


        }

        private void giri�Cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox deger = (ComboBox)sender;
            string denemecinsiyet = deger.Text;
            Kullan�c� deneme = Kullan�c�Sanaldatabase.Kullan�c�DB.Find(i => i.Cinsiyet == denemecinsiyet);
            if(deneme==null)
            {
                foreach (var item in Kullan�c�Sanaldatabase.Kullan�c�DB)
                {
                    item.Cinsiyet = denemecinsiyet;
                }
            }
            
        }
        private void metot()
        {
            foreach (var item in Kullan�c�Sanaldatabase.Kullan�c�cinsiyet)
            {
                giri�Cinsiyet.Items.Add(item);
            }
        }
    }
}