using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultbox.Text = "1";
            insertvaluebox.Text = "1";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBox.Items.AddRange(new string[] { "Mass","Length","Temperature"});
            mainBox.Text = "Select Vaue";
            resultbox.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (mainBox.SelectedItem.Equals("Mass"))
            {
                convertfrombox.Items.Clear();
                convertfrombox.Items.AddRange(new string[] { "kilogram","gram", "milligram","tonne", "pound","ounce" });
                converttobox.Items.Clear();
                converttobox.Items.AddRange(new string[] { "kilogram", "gram", "milligram", "tonne", "pound","ounce" });
                convertfrombox.SelectedItem = "gram";
                converttobox.SelectedItem = "kilogram";
            }
            if (mainBox.SelectedItem.Equals("Length"))
            {
                convertfrombox.Items.Clear(); 
                convertfrombox.Items.AddRange(new string[] { "meter","centimeter","kilometer","inch","mile","yards" });
                converttobox.Items.Clear();
                converttobox.Items.AddRange(new string[] { "meter", "centimeter", "kilometer", "inch", "mile","yards" });
                convertfrombox.SelectedItem = "meter";
                converttobox.SelectedItem = "kilometer";
            }
            if(mainBox.SelectedItem.Equals("Temperature"))
            {
                convertfrombox.Items.Clear();
                convertfrombox.Items.AddRange(new string[] { "celsius", "fahrenheit","kelvin" });
                converttobox.Items.Clear();
                converttobox.Items.AddRange(new string[] { "celsius", "fahrenheit", "kelvin" });
                convertfrombox.SelectedItem = "celsius";
                converttobox.SelectedItem = "fahrenheit";
            }

        }

        public void Length()
        {
            double n = 0;
            double j = 0;
            if(insertvaluebox.Text == null || insertvaluebox.Text == "") 
            { 
                n = 0;
                insertvaluebox.Text = n.ToString();
                n = Convert.ToDouble(insertvaluebox.Text);
            }
            n = Convert.ToDouble(insertvaluebox.Text);
            string valCFB = convertfrombox.SelectedItem.ToString();
            string valCTB = converttobox.SelectedItem.ToString();
            switch (valCFB)
            {
                case "meter":
                    {
                        switch (valCTB)
                        {
                            case "meter": {
                                    j = n * 1;
                                    break;
                                }
                            case "centimeter": { 
                                    j =  n * 100;
                                    break;
                                }
                            case "kilometer": { j = n / 1000;
                                    break;
                                }
                            case "inch": {
                                    j = n * 39.37;
                                    break;
                                }
                            case "mile": {
                                    j = n / 1609;
                                    break;
                                }
                            case "yard": {
                                    j = n / 1.094;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "centimeter":
                    {
                        switch (valCTB)
                        {
                            case "meter":
                                {
                                    j = n / 100;
                                    break;
                                }
                            case "centimeter":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "kilometer":
                                {
                                    j = n / 100000;
                                    break;
                                }
                            case "inch":
                                {
                                    j = n / 2.54;
                                    break;
                                }
                            case "mile":
                                {
                                    j = n / 160934;
                                    break;
                                }
                            case "yard":
                                {
                                    j = n / 91.44;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "kilometer":
                    {
                        switch (valCTB)
                        {
                            case "meter":
                                {
                                    j = n * 10000;
                                    break;
                                }
                            case "centimeter":
                                {
                                    j = n * 100000;
                                    break;
                                }
                            case "kilometer":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "inch":
                                {
                                    j = n * 39370;
                                    break;
                                }
                            case "mile":
                                {
                                    j = n / 1.60934;
                                    break;
                                }
                            case "yard":
                                {
                                    j = n * 1094;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "inch":
                    {
                        switch (valCTB)
                        {
                            case "meter":
                                {
                                    j = n * 39.37;
                                    break;
                                }
                            case "centimeter":
                                {
                                    j = n * 2.54;
                                    break;
                                }
                            case "kilometer":
                                {
                                    j = n / 39370;
                                    break;
                                }
                            case "inch":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "mile":
                                {
                                    j = n / 63360;
                                    break;
                                }
                            case "yard":
                                {
                                    j = n / 36;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "mile":
                    {
                        switch (valCTB)
                        {
                            case "meter":
                                {
                                    j = n * 1609;
                                    break;
                                }
                            case "centimeter":
                                {
                                    j = n * 160934;
                                    break;
                                }
                            case "kilometer":
                                {
                                    j = n * 1.609;
                                    break;
                                }
                            case "inch":
                                {
                                    j = n * 63360;
                                    break;
                                }
                            case "mile":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "yard":
                                {
                                    j = n * 1760;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "yard":
                    {
                        switch (valCTB)
                        {
                            case "meter":
                                {
                                    j = n / 1.094;
                                    break;
                                }
                            case "centimeter":
                                {
                                    j = n * 91.44;
                                    break;
                                }
                            case "kilometer":
                                {
                                    j = n / 1094;
                                    break;
                                }
                            case "inch":
                                {
                                    j = n * 36;
                                    break;
                                }
                            case "mile":
                                {
                                    j = n / 1760;
                                    break;
                                }
                            case "yard":
                                {
                                    j = n * 1;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }

                default:
                    {
                        convertfrombox.SelectedItem = "centimeter";
                        n = 0; 
                        converttobox.SelectedItem = "meter";
                    }
                    break;
            }
            resultbox.Text = Math.Round(j, 4).ToString();
        }

        public void Mass()
        {
            double n = 0;
            double j = 0;
            if (insertvaluebox.Text == null || insertvaluebox.Text == "")
            {
                n = 0;
                insertvaluebox.Text = n.ToString();
                n = Convert.ToDouble(insertvaluebox.Text);
            }
            n = Convert.ToDouble(insertvaluebox.Text);
            string valCFB = convertfrombox.SelectedItem.ToString();
            string valCTB = converttobox.SelectedItem.ToString();
            switch (valCFB)
            {
                case "kilogram":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n* 1000;
                                 break;
                                }
                            case "kilogram":
                                {

                                    j = n * 1; 
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n /1000;
                                    break; 
                                }
                            case "pound":
                                {
                                    j = n * 2.205;
                                    break; }
                            case "milligram":
                                {
                                    j = n * 1000000;
                                    break; 
                                }
                            case "ounce": 
                                {
                                    j = n * 35.274;
                                    break;
                                }
                        }
                        break;
                    }
                case "gram":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "kilogram":
                                {

                                    j = n /1000;
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n / 1000000;
                                    break;
                                }
                            case "pound":
                                {
                                    j = n / 454;
                                    break;
                                }
                            case "milligram":
                                {
                                    j = n * 1000;
                                    break;
                                }
                            case "ounce":
                                {
                                    j = n / 28.35;
                                    break;
                                }
                        }
                        break;
                    }
                case "milligram":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n / 1000;
                                    break;
                                }
                            case "kilogram":
                                {

                                    j = n / 1000000;
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n / 1000000000;
                                    break;
                                }
                            case "pound":
                                {
                                    j = n / 453592;
                                    break;
                                }
                            case "milligram":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "ounce":
                                {
                                    j = n / 28350;
                                    break;
                                }
                        }
                        break;
                    }
                case "tonne":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n * 1000000;
                                    break;
                                }
                            case "kilogram":
                                {

                                    j = n * 1000;
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "pound":
                                {
                                    j = n / 2205;
                                    break;
                                }
                            case "milligram":
                                {
                                    j = n * 11000000000;
                                    break;
                                }
                            case "ounce":
                                {
                                    j = n / 35274;
                                    break;
                                }
                        }
                        break;
                    }
                case "pound":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n * 454;
                                    break;
                                }
                            case "kilogram":
                                {

                                    j = n / 2.205;
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n / 2205;
                                    break;
                                }
                            case "pound":
                                {
                                    j = n * 1;
                                    break;
                                }
                            case "milligram":
                                {
                                    j = n * 453592;
                                    break;
                                }
                            case "ounce":
                                {
                                    j = n *16;
                                    break;
                                }
                        }
                        break;
                    }
                case "ounce":
                    {
                        switch (valCTB)
                        {
                            case "gram":
                                {
                                    j = n * 28.35;
                                    break;
                                }
                            case "kilogram":
                                {

                                    j = n / 35.274;
                                    break;
                                }
                            case "tonne":
                                {
                                    j = n / 35274;
                                    break;
                                }
                            case "pound":
                                {
                                    j = n / 16;
                                    break;
                                }
                            case "milligram":
                                {
                                    j = n * 28350;
                                    break;
                                }
                            case "ounce":
                                {
                                    j = n * 1;
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        n = 0;
                    }
                    break;
            }

            resultbox.Text = Math.Round(j,4).ToString();
        }

        public void temperature()
        {
            double n = 0;
            double j = 0;
            if (insertvaluebox.Text == null || insertvaluebox.Text == "")
            {
                n = 0;
                insertvaluebox.Text = n.ToString();
                n = Convert.ToDouble(insertvaluebox.Text);
            }
            n = Convert.ToDouble(insertvaluebox.Text);
            string valCFB = convertfrombox.SelectedItem.ToString();
            string valCTB = converttobox.SelectedItem.ToString();
            switch (valCFB)
            { 
                case "celsius":
                    {
                        switch (valCTB)
                        {
                            case "celsius":
                            {
                                    j = n * 1;
                                    break;
                            }
                            case "fahrenheit":
                                {
                                    j = ((n * 9)/5) + 32;
                                    break;
                                }
                            case "kelvin":
                                {
                                    j = n + 273.15;
                                    break;
                                }
                        }
                        break;  
                    }
                case "fahrenheit":
                    {
                        switch (valCTB)
                        {
                            case "celsius":
                                {
                                    j = ((n - 32) * 5) / 9;
                                    break;
                                }
                            case "fahrenheit":
                                {
                                    j = n* 1;
                                    break;
                                }
                            case "kelvin":
                                {
                                    j = ((n - 32) * 5) / 9 + 273.15;
                                    break;
                                }
                        }
                        break;
                    }
                case "kelvin":
                    {
                        switch (valCTB)
                        {
                            case "celsius":
                                {
                                    j = n - 273.15;
                                    break;
                                }
                            case "fahrenheit":
                                {
                                    j = (((n - 273.15) * 9) / 5) + 32;
                                    break;
                                }
                            case "kelvin":
                                {
                                    j = n * 1;
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }
            resultbox.Text = Math.Round(j, 5).ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (mainBox.SelectedItem.Equals("Length"))
            {
                Length();
            }
            if (mainBox.SelectedItem.Equals("Mass"))
            {
                Mass();
            }
            if (mainBox.SelectedItem.Equals("Temperature"))
            {
                temperature();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (mainBox.SelectedItem == "Length")
            {
                Length();
            }
            if (mainBox.SelectedItem == "Mass")
            {
                Mass();
            }*/
        }

        private void converttobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainBox.SelectedItem.Equals("Length"))
            {
                Length();
            }
            if (mainBox.SelectedItem.Equals("Mass"))
            {
                Mass();
            }
            if (mainBox.SelectedItem.Equals("Temperature"))
            {
                temperature();
            }
        }
    }
}
