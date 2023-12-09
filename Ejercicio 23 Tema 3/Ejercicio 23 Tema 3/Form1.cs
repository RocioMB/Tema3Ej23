using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Ejercicio_23_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pesosBtn_Click(object sender, EventArgs e)
        {
            int peso;
            int personas_menor_50 = 0;
            int personas_entre_50_65 = 0;
            int personas_entre_65_80 = 0;
            int personas_mayor_80 = 0;
            int total_personas = 0;
            int suma_total_pesos = 0;
            int porcentaje_personas_menor_50 = 0;
            int porcentaje_personas_entre_50_65 = 0;
            int porcentaje_personas_entre_65_80 = 0;
            int porcentaje_personas_mayor_80 = 0;
            int peso_medio = 0;

            try
            {
                peso = int.Parse(Interaction.InputBox("Introduzca un peso:", "Ejercicio 23"));

                if (peso >= 0)
                {
                    while (peso >= 0)
                    {
                        if (peso <= 50)
                        {
                            personas_menor_50++;
                        }
                        if (peso > 50 && peso <= 65)
                        {
                            personas_entre_50_65++;
                        }
                        if (peso > 65 && peso <= 80)
                        {
                            personas_entre_65_80++;
                        }
                        if (peso >= 80)
                        {
                            personas_mayor_80++;
                        }

                        suma_total_pesos += peso;

                        peso = int.Parse(Interaction.InputBox("Introduzca un peso:", "Ejercicio 23"));
                    }
                    total_personas = personas_menor_50 + personas_entre_50_65 + personas_entre_65_80 + personas_mayor_80;

                    porcentaje_personas_menor_50 = (personas_menor_50 * 100) / total_personas;
                    porcentaje_personas_entre_50_65 = (personas_entre_50_65 * 100) / total_personas;
                    porcentaje_personas_entre_65_80 = (personas_entre_65_80 * 100) / total_personas;
                    porcentaje_personas_mayor_80 = (personas_mayor_80 * 100) / total_personas;

                    peso_medio = suma_total_pesos / total_personas;

                    cuantosAlumnosLabel.Text = "Alumnos con peso menor de 50kg: " + personas_menor_50.ToString() + "\n";
                    cuantosAlumnosLabel.Text = cuantosAlumnosLabel.Text + "Alumnos con peso mayor de 50kg y menor o igual de 65kg: " + personas_entre_50_65.ToString() + "\n";
                    cuantosAlumnosLabel.Text = cuantosAlumnosLabel.Text + "Alumnos con peso mayor de 65 y menor o igual de 80kg: " + personas_entre_65_80.ToString() + "\n";
                    cuantosAlumnosLabel.Text = cuantosAlumnosLabel.Text + "Alumnos con peso mayor de 80kg: " + personas_mayor_80.ToString() + "\n";

                    porcentajeLabel.Text = "Los alumnos con peso menor de 50kg representan el " + porcentaje_personas_menor_50.ToString() + "% del total. \n";
                    porcentajeLabel.Text = porcentajeLabel.Text + "Los alumnos con peso mayor de 50kg y menor o igual de 65kg representa el " + porcentaje_personas_entre_50_65.ToString() + "% del total. \n";
                    porcentajeLabel.Text = porcentajeLabel.Text + "Los alumnos con peso mayor de 65kg y menor o igual de 80kg representa el " + porcentaje_personas_entre_65_80.ToString() + "% del total. \n";
                    porcentajeLabel.Text = porcentajeLabel.Text + "Los alumnos con peso mayor de 80kg representan el " + porcentaje_personas_mayor_80.ToString() + "% del total. \n";

                    pesoMedioLabel.Text = "El peso medio de toda la clase es " + peso_medio.ToString() + " kilos.";
                }
                else
                {
                    MessageBox.Show("Ha introducido un peso negativo.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}