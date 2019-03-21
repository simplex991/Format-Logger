using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            textBox1.Text = now.ToString("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "diskpart.exe";
            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardInput.WriteLine("list disk");
            process.StandardInput.WriteLine("exit");
            string output = process.StandardOutput.ReadToEnd();
            listdisk_output.Text = output;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string volume = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void format_btn_Click(object sender, EventArgs e)
        {
            string format_exec = "";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "diskpart.exe";
            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardInput.WriteLine("select " + comboBox2.SelectedItem.ToString());
            process.StandardInput.WriteLine("format FS=" + comboBox1.SelectedItem.ToString() + " label=test quick");
            process.StandardInput.WriteLine("exit");
            string format_output = process.StandardOutput.ReadToEnd();
            format_output_text.Text = format_output;
            MessageBox.Show("Formatting Successfull",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""e:""");
            dsk.Get();
            string id = dsk["VolumeSerialNumber"].ToString();
            textBox2.Text = id.ToString();
            string name = name_input.Text;
            DateTime now = DateTime.Now;
            StringBuilder csvcontent = new StringBuilder();
            if (!File.Exists("D:\\Repos\\FormatLogger\\WindowsFormsApp1\\csv\\log.csv"))
            {
                csvcontent.AppendLine("Dato;Navn;S/N");
                csvcontent.AppendLine(now.ToString("F") + ";" + name + ";" + id);
                string csvpath = "D:\\Repos\\FormatLogger\\WindowsFormsApp1\\csv\\log.csv";
                File.AppendAllText(csvpath, csvcontent.ToString());
            }
            else
            {
                string csvpath = "D:\\Repos\\FormatLogger\\WindowsFormsApp1\\csv\\log.csv";
                csvcontent.AppendLine(now.ToString("F") + ";" + name + ";" + id);
                File.AppendAllText(csvpath, csvcontent.ToString());
            }
            /*StreamWriter File = new StreamWriter("Test.txt"); // Må endre sånn at filen blir bare laget 1 gang
            File.Write(now.ToString("F") + " - " + name + " - " + id); // legge til id variable
            File.Close();*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string name = name_input.Text;
            output_name.Text = name;
        }

        private void name_enter_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            DateTime now = DateTime.Now;
            textBox1.Text = now.ToString("F");
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            textBox1.Text = now.ToString("F");

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""e:""");
            dsk.Get();
            string id = dsk["VolumeSerialNumber"].ToString();
            textBox2.Text = id.ToString();*/
        }

        private void listdisk_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
