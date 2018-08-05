using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialToolTip();
        }

        private void InitialToolTip()
        {
            ToolTip t1 = new ToolTip { ShowAlways = true, AutomaticDelay =0,InitialDelay=0,AutoPopDelay=0,ReshowDelay=0 };
            t1.SetToolTip(txtDataFrom, "Data dimulai dari 1 (Satu)");

            ToolTip t2 = new ToolTip { ShowAlways = true, AutomaticDelay = 0, InitialDelay = 0, AutoPopDelay = 0, ReshowDelay = 0 };
            t2.SetToolTip(txtInput, "[\"data1\",\"data2\"]");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
                string result = ConvertToInstaPyFormat();
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ConvertToInstaPyFormat()
        {
            try
            {
                string result = txtInput.Text;
                result = result.Replace("[", "").Replace("]", "").Replace("\"", "'");
                string[] array = result.Split(',');
                result = "[";
                result += string.Join(",", array.ToList().GetRange(int.Parse(txtDataFrom.Text) - 1, int.Parse(txtLimit.Text)));
                result += "]";
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void ValidateData()
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                throw new Exception("Data Inputan tidak boleh kosong");
            if (!IsValidJson(txtInput.Text))
                throw new Exception("Data Inputan harus berformat json");
            if (int.Parse(txtDataFrom.Text) > int.Parse(txtLimit.Text))
                throw new Exception("Data From tidak boleh lebih kecil dari Data To");
            if (int.Parse(txtDataFrom.Text) == 0)
                throw new Exception("Data yang diambil harus lebih besar dari 0 (nol)");
        }

        private static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
