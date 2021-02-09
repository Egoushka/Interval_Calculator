using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using Microsoft.VisualBasic;
namespace FirstLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var view = new PlotView();
            view.Model = new PlotModel{Title ="Graphic" };
            view.Size = groupBox5.Size;
            view.Name = "graph";
            groupBox5.Controls.Add(view);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton rb)) return;
            switch (rb.TabIndex)
                {
                    case 7:
                    {
                        addToaNUD.Enabled = !addToaNUD.Enabled;
                        break;
                    }
                    case 8:
                    {
                        subFromBNUD.Enabled = !subFromBNUD.Enabled;
                        break;
                    }
                    case 9:
                    {
                        multANUD.Enabled = !multANUD.Enabled;
                        break;
                    }
                    case 10:
                    {
                        divBNUD.Enabled = !divBNUD.Enabled;
                        break;
                    }
                    default:
                        break;
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rb = controllPanel.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked);

           if (rb != null)
           {
              
               PlotModel pm = new PlotModel {Title = "Graphic"};
               var view = groupBox5.Controls.Find("graph", false)[0] as PlotView;
               if (view == null) throw new ArgumentNullException(nameof(view));
               
               pm.Series.Add(Utils.CalculateLineSeries(aBeg.Value, aEnd.Value));
               pm.Series.Add(Utils.CalculateLineSeries(bBeg.Value, bEnd.Value));
               Tuple<decimal, decimal> startEnd = new Tuple<decimal, decimal>(0,0);
               switch (rb.TabIndex)
               {
                   case 0:
                   {
                       startEnd = Methods.Adding( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                      
                       break;
                   }
                   case 1:
                   {
                       
                       startEnd = Methods.Subtraction( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                      
                       break;
                   }
                   case 2:
                   {
                       startEnd =Methods.Multiply( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                      
                       break;
                   }
                   case 3:
                   {
                       startEnd =Methods.Division( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                      
                       break;
                   }
                   case 4:
                   {
                      
                       startEnd =Methods.DivisionH( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                       break;
                   }
                   case 5:
                   {
                       startEnd =Methods.MapA( aBeg.Value,  aEnd.Value);
                       break;
                   }
                   case 6:
                   {
                       startEnd =Methods.Maximum( aBeg.Value,  aEnd.Value,  bBeg.Value,
                            bEnd.Value);
                       break;
                   }
                   case 7:
                   {
                       startEnd =Methods.AddingToA( aBeg.Value,  aEnd.Value, addToaNUD.Value);
                       break;
                   }
                   case 8:
                   {
                       startEnd =Methods.SubtractionFromB( aBeg.Value,  aEnd.Value, subFromBNUD.Value);
                       break;
                   }
                   case 9:
                   {
                       startEnd =Methods.MultiplyAByNum( aBeg.Value,  aEnd.Value, multANUD.Value);
                       break;
                   }
                   case 10:
                   {
                       startEnd = Methods.DivisionBByNum( aBeg.Value,  aEnd.Value, divBNUD.Value);
                       break;
                   }
                   case 11:
                   {

                       string answer = Interaction.InputBox("Enter the count of intervals", "Task", "2");
                       if (!Utils.IsDigitsOnly(answer)) return;
                       int beg, end;
                       for (int counter = 0, count = Int32.Parse(answer); counter < count; ++counter)
                       {
                           answer = Interaction.InputBox($"Enter the beg of {counter+1} interval", "Task", "2");
                           if (!Utils.IsDigitsOnly(answer)) return;
                           beg = Int32.Parse(answer);
                           answer = Interaction.InputBox("Enter the end of {counter+1} interval", "Task", "2");
                           if (!Utils.IsDigitsOnly(answer)) return;
                           end = Int32.Parse(answer);

                           pm.Series.Add(Utils.CalculateLineSeries(beg, end));
                       }
                       break;
                   }
                   case 12:
                   {
                       startEnd =Methods.InverseB( bBeg.Value,  bEnd.Value);
                      
                       break;
                   }
                   case 13:
                   {
                       startEnd =Methods.Minimum( aBeg.Value,  aEnd.Value,  bBeg.Value, bEnd.Value);
                       break;
                   }
                   default:
                       break;
               }

               if (toA.Checked)
               {
                   aBeg.Value = startEnd.Item1;
                   aEnd.Value = startEnd.Item2;
               }
               else if (toB.Checked)
               {
                   bBeg.Value = startEnd.Item1;
                   bEnd.Value = startEnd.Item2;
               }
               pm.Series.Add(Utils.CalculateLineSeries(startEnd.Item1, startEnd.Item2));
               view.Model = pm;
               Utils.height = 0;
           }

        }

        private void aBeg_ValueChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}