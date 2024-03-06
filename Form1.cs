using static System.Net.Mime.MediaTypeNames;

namespace Tema2Seminar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OptLei.Checked = true;
            OptAnuitati.Checked = true;
        }
        private void BtnCalcul_Click(object sender, EventArgs e)
        {
            double imprumut = Convert.ToDouble(txtSuma.Text);
            int perioada = Convert.ToInt32(SpnPerioada.Value);
            double dobanda = Convert.ToDouble(CboDobanda.SelectedItem) / 1200;
            double amortisment, anuitate, valramasa, valdobanda, valimprumut;

            if (OptAnuitati.Checked)
            {
                anuitate = Math.Round((dobanda *imprumut) / (1 - Math.Pow( (1 + dobanda), -perioada)), 1);
                valimprumut = imprumut;
                for (int i = 1; i <= perioada; i++)
                {
                    valdobanda = Math.Round(valimprumut * dobanda,1);
                    amortisment = anuitate - valdobanda;
                    valramasa = Math.Round(valimprumut - amortisment, 0);
                    LstRambursare.Items.Add(@"Pentru luna" + i + "Valoarea imprumutului: " + valimprumut + " Valoarea dobanzii: " + valdobanda + " valoarea amortizata:" + amortisment + " rata:"
                        + anuitate + " valoarea ramasa: " + valramasa);
                    valimprumut -= amortisment;


                }
            }
            else
            {
                amortisment = Math.Round(imprumut / perioada, 1);
                valimprumut = imprumut;
                int i = 1;
                while (i <= perioada)
                {
                    valdobanda = Math.Round(valimprumut * dobanda, 1);
                    anuitate = valdobanda + amortisment;
                    valramasa = Math.Round(valimprumut - amortisment, 0);
                    LstRambursare.Items.Add(@"Pentru luna" + i + "Valoarea imprumutului: " + valimprumut + "Valoarea dobanzii: " + valdobanda + "valoarea amortizata:" + amortisment + " rata:"
                        + anuitate + " valoarea ramasa: " + valramasa);
                    valimprumut -= amortisment; 
                    i++;

                }
            }
        }

        private void BtnIesire_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtSuma.Text = "";
            SpnPerioada.Value = 3;
            CboDobanda.SelectedIndex = -1;
            OptLei.Checked = true;
            OptAnuitati.Checked = true;
            LstRambursare.Items.Clear();
        }
    }
}
        
    

