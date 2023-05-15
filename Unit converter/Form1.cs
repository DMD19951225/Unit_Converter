using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
            Label output = null;
            output = label3;
            output.Text = "Convert Temperature";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("fahrenheit");
            comboBox1.Items.Add("celsius");
            comboBox1.Items.Add("kelvin");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("fahrenheit");
            comboBox2.Items.Add("celsius");
            comboBox2.Items.Add("kelvin");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
            Label output = null;
            output = label3;
            output.Text = "Convert Length";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("millimeter");
            comboBox1.Items.Add("centimeter");
            comboBox1.Items.Add("meter");
            comboBox1.Items.Add("kilometer");
            comboBox1.Items.Add("inch");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("millimeter");
            comboBox2.Items.Add("centimeter");
            comboBox2.Items.Add("meter");
            comboBox2.Items.Add("kilometer");
            comboBox2.Items.Add("inch");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
            Label output = null;
            output = label3;
            output.Text = "Convert Mass";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("milligram");
            comboBox1.Items.Add("gram");
            comboBox1.Items.Add("kilogram");
            comboBox1.Items.Add("ton");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("milligram");
            comboBox2.Items.Add("gram");
            comboBox2.Items.Add("kilogram");
            comboBox2.Items.Add("ton");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Focus();
            Label output = null;
            output = label3;
            output.Text = "Convert Time";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("second");
            comboBox1.Items.Add("minute");
            comboBox1.Items.Add("hour");
            comboBox1.Items.Add("day");
            comboBox1.Items.Add("month");
            comboBox1.Items.Add("year");

            comboBox2.Items.Clear();
            comboBox2.Items.Add("second");
            comboBox2.Items.Add("minute");
            comboBox2.Items.Add("hour");
            comboBox2.Items.Add("day");
            comboBox2.Items.Add("month");
            comboBox2.Items.Add("year");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                if (comboBox1.SelectedItem == "millimeter" && comboBox2.SelectedItem == "millimeter")
                {
                    textBox2.Text = (a * 1).ToString();
                }
                if (comboBox1.SelectedItem == "millimeter" && comboBox2.SelectedItem == "centimeter")
                {
                    textBox2.Text = (a / 10).ToString();
                }
                if (comboBox1.SelectedItem == "millimeter" && comboBox2.SelectedItem == "meter")
                {
                    textBox2.Text = (a / 1000).ToString();
                }
                if (comboBox1.SelectedItem == "millimeter" && comboBox2.SelectedItem == "kilometer")
                {
                    textBox2.Text = (a / 1000000).ToString();
                }
                if (comboBox1.SelectedItem == "millimeter" && comboBox2.SelectedItem == "inch")
                {
                    textBox2.Text = (a / 25.4).ToString();
                }
                if (comboBox1.SelectedItem == "centimeter" && comboBox2.SelectedItem == "millimeter")
                {
                    textBox2.Text = (a * 10).ToString();
                }
                if (comboBox1.SelectedItem == "centimeter" && comboBox2.SelectedItem == "centimeter")
                {
                    textBox2.Text = (a * 1).ToString();
                }
                if (comboBox1.SelectedItem == "centimeter" && comboBox2.SelectedItem == "meter")
                {
                    textBox2.Text = (a / 100).ToString();
                }
                if (comboBox1.SelectedItem == "centimeter" && comboBox2.SelectedItem == "kilometer")
                {
                    textBox2.Text = (a / 100000).ToString();
                }
                if (comboBox1.SelectedItem == "centimeter" && comboBox2.SelectedItem == "inch")
                {
                    textBox2.Text = (a / 2.54).ToString();
                }
                if (comboBox1.SelectedItem == "meter" && comboBox2.SelectedItem == "millimeter")
                {
                    textBox2.Text = (a * 1000).ToString();
                }
                if (comboBox1.SelectedItem == "meter" && comboBox2.SelectedItem == "centimeter")
                {
                    textBox2.Text = (a * 100).ToString();
                }
                if (comboBox1.SelectedItem == "meter" && comboBox2.SelectedItem == "meter")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "meter" && comboBox2.SelectedItem == "kilometer")
                {
                    textBox2.Text = (a / 1000).ToString();
                }
                if (comboBox1.SelectedItem == "meter" && comboBox2.SelectedItem == "inch")
                {
                    textBox2.Text = (a * 39.3701).ToString();
                }
                if (comboBox1.SelectedItem == "kilometer" && comboBox2.SelectedItem == "millimeter")
                {
                    textBox2.Text = (a * 1000000).ToString();
                }
                if (comboBox1.SelectedItem == "kilometer" && comboBox2.SelectedItem == "centimeter")
                {
                    textBox2.Text = (a * 100000).ToString();
                }
                if (comboBox1.SelectedItem == "kilometer" && comboBox2.SelectedItem == "meter")
                {
                    textBox2.Text = (a * 1000).ToString();
                }
                if (comboBox1.SelectedItem == "kilometer" && comboBox2.SelectedItem == "kilometer")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "kilometer" && comboBox2.SelectedItem == "inch")
                {
                    textBox2.Text = (a * 39370.1).ToString();
                }
                if (comboBox1.SelectedItem == "inch" && comboBox2.SelectedItem == "millimeter")
                {
                    textBox2.Text = (a * 25.4).ToString();
                }
                if (comboBox1.SelectedItem == "inch" && comboBox2.SelectedItem == "centimeter")
                {
                    textBox2.Text = (a * 2.54).ToString();
                }
                if (comboBox1.SelectedItem == "inch" && comboBox2.SelectedItem == "meter")
                {
                    textBox2.Text = (a * 0.0254).ToString();
                }
                if (comboBox1.SelectedItem == "inch" && comboBox2.SelectedItem == "kilometer")
                {
                    textBox2.Text = (a * 0.0000254).ToString();
                }
                if (comboBox1.SelectedItem == "inch" && comboBox2.SelectedItem == "inch")
                {
                    textBox2.Text = (a).ToString();
                }


                if (comboBox1.SelectedItem == "milligram" && comboBox2.SelectedItem == "milligram")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "milligram" && comboBox2.SelectedItem == "gram")
                {
                    textBox2.Text = (a * 0.001).ToString();
                }
                if (comboBox1.SelectedItem == "milligram" && comboBox2.SelectedItem == "kilogram")
                {
                    textBox2.Text = (a * 0.000001).ToString();
                }
                if (comboBox1.SelectedItem == "milligram" && comboBox2.SelectedItem == "ton")
                {
                    textBox2.Text = (a * 0.000000001).ToString();
                }
                if (comboBox1.SelectedItem == "gram" && comboBox2.SelectedItem == "milligram")
                {
                    textBox2.Text = (a * 1000).ToString();
                }
                if (comboBox1.SelectedItem == "gram" && comboBox2.SelectedItem == "gram")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "gram" && comboBox2.SelectedItem == "kilogram")
                {
                    textBox2.Text = (a * 0.001).ToString();
                }
                if (comboBox1.SelectedItem == "gram" && comboBox2.SelectedItem == "ton")
                {
                    textBox2.Text = (a * 0.000001).ToString();
                }
                if (comboBox1.SelectedItem == "kilogram" && comboBox2.SelectedItem == "milligram")
                {
                    textBox2.Text = (a * 1000000).ToString();
                }
                if (comboBox1.SelectedItem == "kilogram" && comboBox2.SelectedItem == "gram")
                {
                    textBox2.Text = (a * 1000).ToString();
                }
                if (comboBox1.SelectedItem == "kilogram" && comboBox2.SelectedItem == "kilogram")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "kilogram" && comboBox2.SelectedItem == "ton")
                {
                    textBox2.Text = (a * 0.001).ToString();
                }
                if (comboBox1.SelectedItem == "ton" && comboBox2.SelectedItem == "milligram")
                {
                    textBox2.Text = (a * 1000000000).ToString();
                }
                if (comboBox1.SelectedItem == "ton" && comboBox2.SelectedItem == "gram")
                {
                    textBox2.Text = (a * 1000000).ToString();
                }
                if (comboBox1.SelectedItem == "ton" && comboBox2.SelectedItem == "kilogram")
                {
                    textBox2.Text = (a * 1000).ToString();
                }
                if (comboBox1.SelectedItem == "ton" && comboBox2.SelectedItem == "ton")
                {
                    textBox2.Text = (a).ToString();
                }


                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a / 60).ToString();
                }
                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a / 3600).ToString();
                }
                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a / 86400).ToString();
                }
                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a / 2592000).ToString();
                }
                if (comboBox1.SelectedItem == "second" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a / 31536000).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a * 60).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a / 60).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a / 1440).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a / 43200).ToString();
                }
                if (comboBox1.SelectedItem == "minute" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a / 525600).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a * 3600).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a * 60).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a / 24).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a / 720).ToString();
                }
                if (comboBox1.SelectedItem == "hour" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a / 8760).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a * 86400).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a * 1440).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a * 24).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a / 30).ToString();
                }
                if (comboBox1.SelectedItem == "day" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a / 365).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a * 2592000).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a * 43200).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a * 720).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a * 30).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "month" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a / 12).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "second")
                {
                    textBox2.Text = (a * 31536000).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "minute")
                {
                    textBox2.Text = (a * 525600).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "hour")
                {
                    textBox2.Text = (a * 8760).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "day")
                {
                    textBox2.Text = (a * 365).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "month")
                {
                    textBox2.Text = (a * 12).ToString();
                }
                if (comboBox1.SelectedItem == "year" && comboBox2.SelectedItem == "year")
                {
                    textBox2.Text = (a).ToString();
                }


                if (comboBox1.SelectedItem == "fahrenheit" && comboBox2.SelectedItem == "fahrenheit")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "fahrenheit" && comboBox2.SelectedItem == "celsius")
                {
                    textBox2.Text = ((a - 32) * 5 / 9).ToString();
                }
                if (comboBox1.SelectedItem == "fahrenheit" && comboBox2.SelectedItem == "kelvin")
                {
                    textBox2.Text = ((a - 32) * 5 / 9 + 273.15).ToString();
                }
                if (comboBox1.SelectedItem == "celsius" && comboBox2.SelectedItem == "fahrenheit")
                {
                    textBox2.Text = (a * 9 / 5 + 32).ToString();
                }
                if (comboBox1.SelectedItem == "celsius" && comboBox2.SelectedItem == "celsius")
                {
                    textBox2.Text = (a).ToString();
                }
                if (comboBox1.SelectedItem == "celsius" && comboBox2.SelectedItem == "kelvin")
                {
                    textBox2.Text = (a + 273.15).ToString();
                }
                if (comboBox1.SelectedItem == "kelvin" && comboBox2.SelectedItem == "fahrenheit")
                {
                    textBox2.Text = ((a - 273.15) * 9 / 5 + 32).ToString();
                }
                if (comboBox1.SelectedItem == "kelvin" && comboBox2.SelectedItem == "celsius")
                {
                    textBox2.Text = (a - 273.15).ToString();
                }
                if (comboBox1.SelectedItem == "kelvin" && comboBox2.SelectedItem == "kelvin")
                {
                    textBox2.Text = (a).ToString();
                }
            }
            catch { MessageBox.Show("You have to enter only number."); }
        }
    }
}
