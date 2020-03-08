using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string operacao = null, aparecer_no_visor = "";

        double memoria_de_calculo_pre_operacao = 0.0;
        double memoria_de_calculo_pos_operacao = 0.0;

        private void remover_sinais_visor()
        {
            if(aparecer_no_visor == "+" || aparecer_no_visor == "-" || aparecer_no_visor == "*" || aparecer_no_visor == "/")
            {
                aparecer_no_visor = "";
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }


        private void num7_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num7.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num8.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }


        private void num9_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num9.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

                aparecer_no_visor = "*";
                operacao = "*";
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num4_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num4.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num5.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num6_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num6.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void subtrair_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

                aparecer_no_visor = "-";
                operacao = "-";
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num1_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num1.Text;
                visor.Text = aparecer_no_visor;
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num2_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num2.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num3_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num3.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void somar_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

                aparecer_no_visor = "+";
                operacao = "+";
                visor.Text = aparecer_no_visor;
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void num0_Clicked(object sender, EventArgs e)
        {
            try
            {
                remover_sinais_visor();
                aparecer_no_visor += num0.Text;
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void ponto_Clicked(object sender, EventArgs e)
        {
            try
            {
                aparecer_no_visor += ponto.Text;
                visor.Text = aparecer_no_visor;
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pos_operacao = Convert.ToDouble(visor.Text);
                double resultado = 0;
                switch (operacao)
                {
                    case "+":
                        resultado = memoria_de_calculo_pre_operacao + memoria_de_calculo_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_de_calculo_pre_operacao - memoria_de_calculo_pos_operacao;
                        break;

                    case "*":
                        resultado = memoria_de_calculo_pre_operacao * memoria_de_calculo_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_de_calculo_pre_operacao / memoria_de_calculo_pos_operacao;
                        break;
                }

                visor.Text = resultado.ToString();
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {
            try
            {
                visor.Text = "0";
                aparecer_no_visor = "";
                memoria_de_calculo_pre_operacao = 0.0;
                memoria_de_calculo_pos_operacao = 0.0;
                operacao = null;
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);

                valor_visor = valor_visor * -1;
                visor.Text = valor_visor.ToString();
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }

        }

        private void porcento_Clicked(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);

                valor_visor = valor_visor / 100;
                visor.Text = valor_visor.ToString();
            }catch(Exception err)
            {
                visor.Text = err.Message;
            }
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

                aparecer_no_visor = "/";
                operacao = "/";
                visor.Text = aparecer_no_visor;
            }
            catch (Exception err)
            {
                visor.Text = err.Message;
            }
        }
    }
}
