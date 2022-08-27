using Barbut.Models;

namespace Barbut
{
    public partial class Form1 : Form
    {
        //Barbut.Models.Zar _zar = new Barbut.Models.Zar(); //Bu namespacedeki Zar a ulaþtýk

        Zar _zar = new Zar();

        string dosyaYolu = Application.StartupPath.Replace(@"bin\Debug\net6.0-windows", @"zarlar\");

        //C:\Users\User\source\repos\Barbut\Barbut\bin\Debug\net6.0-windowsC:\Users\Administrator\source\repos\Barbut8438\Barbut8438\bin\Debug\net6.0-windows
        // C:\Users\Administrator\source\repos\Barbut8438\Barbut8438\zarlar

        const string DICE = "dice-"; // const bir deðerin sabit olduðunu ifade eder
        const string EXTENSION = ".png"; // zarlarýn resimlerinin uzantýsý .png
        public Form1()
        {
            InitializeComponent();
        }

        byte sonuc1 = 0;
        byte sonuc2 = 0;


        private void Topla(byte x, byte y)
        {
             
            sonuc1 += x;
            sonuc2 += y;
 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bZarAt_Click(object sender, EventArgs e)
        {
            ZarAt();
        }

        private void ZarAt()
        {
            _zar.At();
            byte sayi1 = _zar.Sayi;
            lbZar1.Text = sayi1.ToString();
            _zar.At();
            byte sayi2 = _zar.Sayi;
            lbZar2.Text = sayi2.ToString();
            Topla(sayi1, sayi2);
           

            lbZar1.Visible = true;
            lbZar2.Visible = true;

            pbZar1.ImageLocation = dosyaYolu + DICE + sayi1 + EXTENSION;
            pbZar2.ImageLocation = dosyaYolu + DICE + sayi2 + EXTENSION;

            //if sayi1 > sayi2 ? MessageBox.Show("Zar 1 kazandý.") : MessageBox.Show("Zar 2 kazandý.");

            if (sayi1 > sayi2)
            { //MessageBox.Show("Zar 1 kazandý.");
                lbSonuc.Items.Add("Zar 1 kazandý."); // listbox a ýtems deyip add fonksiyonuyla "Zar 1 kazandý." ekliyoruz
            }

            else if (sayi2 > sayi1)
            { //MessageBox.Show("Zar 2 kazandý.");
                lbSonuc.Items.Add("Zar 2 kazandý.");
            }

            else
            { //MessageBox.Show("Berabere kaldýnýz.");
                //lbSonuc.Items.Add("Berabere kaldýnýz.");
                ZarAt(); // recursive method, kendi kendini çaðýran
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bSonucgoster_Click(object sender, EventArgs e)
        {
            if (sonuc1 > sonuc2)
                MessageBox.Show("Birinci oyuncu kazandý." + "\nBirinci oyuncunun toplamý: " + sonuc1 + "\nÝkinci oyuncunun toplamý: " + sonuc2);
            else if (sonuc2 > sonuc1)
                MessageBox.Show("Ýkinci oyuncu kazandý." + "\nBirinci oyuncunun toplamý: " + sonuc1 + "\nÝkinci oyuncunun toplamý: " + sonuc2);
            else
                MessageBox.Show("Berabere kaldý." + "\nBirinci oyuncunun toplamý: " + sonuc1 + "\nÝkinci oyuncunun toplamý: " + sonuc2);
        }
    }
        
    
}