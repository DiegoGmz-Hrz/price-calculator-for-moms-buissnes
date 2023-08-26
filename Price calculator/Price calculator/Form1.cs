using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Price_calculator
{
    public partial class Form1 : Form
    {
        int stablilizantePrecio = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateOutPut()
        {
            if (Minutes_TextBox.Text!=""&& Pago_por_Hora_TextBox.Text!=""&& Item_Count_TextBox.Text!=""&& Precio_De_Articulo_TextBox.Text!="")
            {
                stablilizantePrecio = 0;
                if (Stabilizante_Chico_RadioButton.Checked)
                {
                    stablilizantePrecio = 3;
                }
                else if (Stabilizante_Grande_RadioButton.Checked)
                {
                    stablilizantePrecio = 6;
                }
                OutPut_lable.Text=Convert.ToString(Math.Round((float.Parse(Minutes_TextBox.Text)/60*(2.79+float.Parse(Pago_por_Hora_TextBox.Text)) +1.22+.40+1+ stablilizantePrecio + float.Parse(Precio_De_Articulo_TextBox.Text))*float.Parse(Item_Count_TextBox.Text) * 100) / 100);
                OutPut_lable.Text = OutPut_lable.Text + "$ es el total     " + Convert.ToString(Math.Round((float.Parse(Minutes_TextBox.Text) / 60 * 2.79 + 1.22 + .40 + 1+ stablilizantePrecio + float.Parse(Precio_De_Articulo_TextBox.Text)) * float.Parse(Item_Count_TextBox.Text) * 100)/100) + "$ son para los gastos       " + Convert.ToString(Math.Round(float.Parse(Minutes_TextBox.Text) / 60 * float.Parse(Pago_por_Hora_TextBox.Text)* float.Parse(Item_Count_TextBox.Text)*100)/100)+"$ son la ganacia";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Minutes_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }

        private void Pago_por_Hora_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }

        private void Item_Count_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }

        private void Precio_De_Articulo_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }

        private void Stabilizante_Chico_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOutPut();
        }
    }
}
