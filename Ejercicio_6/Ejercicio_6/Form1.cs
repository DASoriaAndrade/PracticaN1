using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            ListBox_Numeros.Items.Clear();
            int num =Convert.ToInt32(txtvalor.Text);
            string selecionador = comboxoperaciones.Text;
            if(selecionador == "Numeros Primos")
            {
                int acu = 0;
                for (int i = 2; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        int res = i % j;
                        if (res == 0)
                        {
                            acu = acu + 1;
                        }
                    }
                    if (acu == 2)
                    { 
                        ListBox_Numeros.Items.Add(i);
                    }

                    acu = 0;
                }
            }

            if (selecionador=="Numeros Perfectos")
            {
                for (int i=2;i<= num; i++)
                {
                    int b = 0;
                    int s = i / 2;
                    for(int j = 1;j<=s; j++)
                    {
                        int a = i % j;
                        if(a==0)
                        {
                            b= b + j;
                        }
                    }
                    if (b == i)
                    {
                        ListBox_Numeros.Items.Add(i);
                    }
                }
            }

            if (selecionador == "Serie Fibonaci")
            {
                int ant=1, sig=0;

                for(int i=1;i<= num; i++)
                {
                    int ter =  ant + sig;
                    ListBox_Numeros.Items.Add(ter);
                    ant = sig;
                    sig = ter;
                }
            }
        }
    }
}
