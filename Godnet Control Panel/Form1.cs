using Godnet_Control_Panel.Resources;
using Renci.SshNet;
using System.Net;
using Godnet_Control_Panel;
using Renci.SshNet.Common;

namespace Godnet_Control_Panel
{
    public partial class Form1 : Form
    {
        public SftpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.client.Disconnect();
            this.client.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("users.gn"))
            {
                this.client.DownloadFile("/root/cnc/assets/users.gn", fs);
            }

            string[] users = File.ReadAllLines("users.gn");

            dataGridView1.Rows.Clear();
            foreach (string line in users)
            {
                if (line == string.Empty) break;
                //('Jeff','5.5.5.5','niggerbob','0','0','0','0','0','0')
                //   0        1           2      3   4   5   6   7   8
                string[] line_info = line.Replace("(", "").Replace(")", "").Replace("'", "").Split(',');
                dataGridView1.Rows.Add(
                    line_info[0],
                    line_info[1],
                    line_info[3],
                    line_info[4],
                    line_info[5],
                    line_info[6],
                    line_info[7],
                    line_info[8],
                    line_info[2]);
            }

            label5.BringToFront();
            label6.BringToFront();
            label7.BringToFront();
            label8.BringToFront();
            label9.BringToFront();
            label10.BringToFront();
            label11.BringToFront();
            label12.BringToFront();
            panel6.BringToFront();
            dataGridView1.BringToFront();
            this.fix_box();
        }

        public void fix_box()
        {
            panel12.BringToFront();
            panel13.BringToFront();
            panel14.BringToFront();
            panel15.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool empty = false;

            foreach (TextBox t in (new TextBox[] { textBox1, textBox1, textBox3 }))
            { if (t.Text == string.Empty) empty = true; }
            if (empty) err_n_exit("Must fill all connection info textboxes!");

            try
            {
                this.client = SSH_Config.sshInfo(textBox1.Text, textBox2.Text, textBox3.Text);
                this.client.Connect();
                label13.Text = "Connection State: Connected";
            }
            catch { err_n_exit("Unable to connect to host!"); label13.Text = "Connection State: Failed to connect"; }
        }

        public void err_n_exit(string msg) { MessageBox.Show(msg); this.close(); }

        public void close()
        {
            try
            {
                this.client.Disconnect();
                this.client.Dispose();
            }
            catch { }
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("apis.json"))
            {
                this.client.DownloadFile("/root/cnc/assets/apis.json", fs);
            }

            richTextBox1.Text = File.ReadAllText("apis.json");

            richTextBox1.BringToFront();
            this.fix_box();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                File.Delete("users.gn");

                string val = dataGridView1.SelectedRows[0].ToString();
                string t = "";
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if ($"{r.Cells[0].Value}" == "") break;
                    t += $"('{r.Cells[0].Value}','{r.Cells[1].Value}','{r.Cells[8].Value}','{r.Cells[2].Value}','{r.Cells[3].Value}','{r.Cells[4].Value}','{r.Cells[5].Value}','{r.Cells[6].Value}','{r.Cells[7].Value}')";
                }
                File.WriteAllText("users.gn", t);

                Stream fs = client.OpenRead("users.gn");
                client.UploadFile(fs, "/root/cnc/assets/users.gn");
                MessageBox.Show("Database updated...!");
            }
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[0];
            //string g = row.Cells[5].Value;
            //MessageBox.Show(g);
        }
    }
}
