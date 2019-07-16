using System;
using System.Data;
using System.Data.OracleClient;
using System.Threading;
using System.Windows.Forms;

namespace TestLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstBtn_Click(object sender, EventArgs e)
        {
            tstBtn.Enabled = false;

            if (rdBtn_devart.Checked)
            {
                var connectionStringBuilder = new Devart.Data.Oracle.OracleConnectionStringBuilder();

                connectionStringBuilder.Direct = true;
                connectionStringBuilder.ServiceName = txtBx_serviceName.Text;
                connectionStringBuilder.Sid = txtBx_sid.Text;
                connectionStringBuilder.Server = txtBx_server.Text;
                connectionStringBuilder.Port = Int32.Parse(txtBx_port.Text);
                connectionStringBuilder.UserId = txtBx_user.Text;
                connectionStringBuilder.Password = txtBx_pass.Text;

                var connection = new Devart.Data.Oracle.OracleConnection(connectionStringBuilder.ConnectionString);
                if (connection != null)
                {
                    for (int i = 0; i <= Int32.Parse(txtBx_qtd.Text); i++)
                    {

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                            MessageBox.Show("Conexão estabelecida");
                        }

                        Thread.Sleep(5000);

                        connection.Close();
                        MessageBox.Show("Conexão encerrada");

                        Thread.Sleep(3000);
                    }
                }
            }
            else if (rdBtn_native.Checked)
            {
                var connectionStringBuilder = new OracleConnectionStringBuilder();

                connectionStringBuilder.DataSource = txtBx_sid.Text;
                connectionStringBuilder.UserID = txtBx_user.Text;
                connectionStringBuilder.Password = txtBx_pass.Text;

                var connectionOracleClient = new OracleConnection(connectionStringBuilder.ConnectionString);

                if (connectionOracleClient != null)
                {
                    for (int i = 0; i <= Int32.Parse(txtBx_qtd.Text); i++)
                    {

                        if (connectionOracleClient.State != ConnectionState.Open)
                        {
                            connectionOracleClient.Open();
                            MessageBox.Show("Conexão estabelecida");
                        }

                        Thread.Sleep(5000);

                        connectionOracleClient.Close();
                        MessageBox.Show("Conexão encerrada");

                        Thread.Sleep(3000);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção de driver.");
            }

            tstBtn.Enabled = true;
        }
    }
}
