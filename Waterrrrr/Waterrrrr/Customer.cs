using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterrrrr
{
    public partial class Customer : UserControl
    {

        public Customer()
        {
            InitializeComponent();
        }

        void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        public string FirstN;
        public string LastN;
        public string PlotNum;
        public string userType;
        public string geographicalLocation;
        public double waterUsed;
        public double waterCost;
        public double wasteWater;
        public double totalAmount;
 

        private void button1_Click(object sender, EventArgs e)
        {
            //Inputs getting assigned 
            FirstN = txtfname.Text;
            LastN = txtlname.Text;
            geographicalLocation = txtgeographical.Text;
            PlotNum = txtyerrrr.Text;
            userType = txtutype.Text;
            waterUsed = int.Parse(txtpwu.Text);





            //if and else statements            
            { 
                if (userType == "domestic" || userType == "Domestic")

                    if (5 >= waterUsed)
                    {
                        waterCost = Math.Round((waterUsed * 3.60), 2);
                        wasteWater =Math.Round((waterUsed * 0.65), 2);
                        totalAmount =Math.Round((waterUsed * 0.65) + (waterUsed * 3.60), 2);

                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");
                    }
              

                else if (5 < waterUsed && 15 > waterUsed)
                {
                    waterCost =Math.Round(((5 * 3.60) + ((waterUsed - 5) * 13.43)), 2);
                    wasteWater =Math.Round(((5 * 0.65) + ((waterUsed - 5) * 3.36)), 2);
                        totalAmount = waterCost + wasteWater;
                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");




                    }





                


                else if (15 < waterUsed && 25 > waterUsed)
                {
                    waterCost =Math.Round(((5 * 3.60) + (10 * 13.43) + ((waterUsed - 25) * 23.51)), 2);
                    wasteWater =Math.Round(((5 * 0.65) + (10 * 3.36) + ((waterUsed - 25) * 5.03)), 2);
                    totalAmount = wasteWater+ waterCost;
                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");
                    }
                else if (25 < waterUsed && 40 > waterUsed)
                {
                    waterCost =Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + ((waterUsed - 25) * 36.16)), 2);
                    wasteWater =Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + ((waterUsed - 25) * 6.71)), 2);
                    totalAmount=waterCost+ waterCost;
                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");





                    }
                else if (40 < waterUsed)
                {
                    waterCost =Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + ((waterUsed - 40) * 45.21)), 2);
                    wasteWater =Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((waterUsed - 40) * 8.39)), 2);
                    totalAmount =wasteWater+ waterCost;
                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");




                    }
                if (userType == "commercial" && userType == "Commercial" || userType == "Indusrial" || userType == "industrial" || userType == "business" && userType =="Business")
                { 
                    if (5 >= waterUsed)
                    {
                      
                        waterCost =Math.Round((waterUsed * 4.92), 2);
                        wasteWater =Math.Round((waterUsed * 0.74), 2);
                        totalAmount = wasteWater+ waterCost;

                        MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");
                    }

              



                }
                else if (5 < waterUsed && 15 > waterUsed)
                {
                    
                    waterCost =Math.Round(((5 * 4.92) + ((waterUsed - 5) * 14.61)), 2);
                    wasteWater = Math.Round(((5 * 0.74) + ((waterUsed - 5) * 3.36)), 2);
                    totalAmount = wasteWater+ waterCost;
                    MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");

                }






                else if (15 < waterUsed && 25 > waterUsed)
                {
                   
                    waterCost =Math.Round(((5 * 4.92) + (10 * 14.61) + ((waterUsed - 25) * 25.58)), 2);
                    wasteWater =Math.Round(((5 * 0.74) + (10 * 3.36) + ((waterUsed - 25) * 5.03)), 2);
                    totalAmount = wasteWater+ waterCost;
                    


                }
                else if (25 < waterUsed && 40 > waterUsed)
                {
                  
                    waterCost =Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + ((waterUsed - 25) * 39.35)), 2);
                    wasteWater =Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + ((waterUsed - 25) * 6.71)), 2);
                    totalAmount = wasteWater+ waterCost;

                    MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");


                }
                else if (40 < waterUsed)
                {
                   
                    waterCost =Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + (15 * 39.35) + ((waterUsed - 40) * 49.20)), 2);
                    wasteWater =Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((waterUsed - 40) * 8.39)), 2);
                    totalAmount = wasteWater+ waterCost;

                    MessageBox.Show($"Name :{FirstN} {LastN}\nPotable Water Used:{waterUsed}KL\nPotable Water Cost :{wasteWater}BWP\nPlotNo :{PlotNum} {geographicalLocation}\ntotalAmount :{totalAmount}BWP");





                }
                {
                    
                    }
                }


            }

        private void txtlocation_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
        


        }
    



    
                
           
