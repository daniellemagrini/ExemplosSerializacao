using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExemplosSerializacao
{
    public partial class frm_serializacao : Form
    {
        public frm_serializacao()
        {
            InitializeComponent();
        }

        Paciente p = new Paciente();

        private void Limpar()
        {
            tb_nome.Clear();
            tb_dt_nascimento.Clear();
            tb_cpf.Clear();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            p.nome = tb_nome.Text;
            p.data_nascimento = tb_dt_nascimento.Text;
            p.cpf = tb_cpf.Text;

            if (tb_nome.Text != "" && tb_dt_nascimento.Text != "" && tb_cpf.Text != "")
            {
                try
                {
                    string nome = tb_nome.Text;
                    string dataNascimento = tb_dt_nascimento.Text;
                    string cpf = tb_cpf.Text;
                    FileStream arquivo = new FileStream(@"C:\Users\Usuario\Documents\DANI\ACADEMIA ATOS\SERIALIZACAO\ExemplosSerializacao\Arquivos\dadosBINARY.data", FileMode.Create);
                    BinaryFormatter serializador = new BinaryFormatter();
                    serializador.Serialize(arquivo, nome + dataNascimento + cpf);
                    arquivo.Close();

                    MessageBox.Show("Serializado com sucesso!");
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("É OBRIGATÓRIO PREENCHER TODOS OS CAMPOS");
            }
        }

        private void bt_soap_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text != "" && tb_dt_nascimento.Text != "" && tb_cpf.Text != "")
            {
                try
                {
                    p.nome = tb_nome.Text;
                    p.data_nascimento = tb_dt_nascimento.Text;
                    p.cpf = tb_cpf.Text;

                    FileStream arquivo = new FileStream(@"C:\Users\Usuario\Documents\DANI\ACADEMIA ATOS\SERIALIZACAO\ExemplosSerializacao\Arquivos\dadosSOAP.data", FileMode.Create);
                    SoapFormatter serializador = new SoapFormatter();

                    serializador.Serialize(arquivo, p);
                    arquivo.Close();

                    MessageBox.Show("Sucesso para serializar SOAP");
                    Limpar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("É OBRIGATÓRIO PREENCHER TODOS OS CAMPOS");
            }
        }

        private void bt_xml_Click(object sender, EventArgs e)
        {
            p.nome = tb_nome.Text;
            p.data_nascimento = tb_dt_nascimento.Text;
            p.cpf = tb_cpf.Text;

            if (tb_nome.Text != "" && tb_dt_nascimento.Text != "" && tb_cpf.Text != "")
            {
                try
                {                   
                    FileStream arquivo = new FileStream(@"C:\Users\Usuario\Documents\DANI\ACADEMIA ATOS\SERIALIZACAO\ExemplosSerializacao\Arquivos\dadosXML.data", FileMode.Create);
                    XmlSerializer serializador = new XmlSerializer(typeof(Paciente));

                    serializador.Serialize(arquivo, p);
                    arquivo.Close();

                    MessageBox.Show("Sucesso para serializar com XML");
                    Limpar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("É OBRIGATÓRIO PREENCHER TODOS OS CAMPOS");
            }
        }

        private void bt_json_Click(object sender, EventArgs e)
        {
            p.nome = tb_nome.Text;
            p.data_nascimento = tb_dt_nascimento.Text;
            p.cpf = tb_cpf.Text;

            if (tb_nome.Text != "" && tb_dt_nascimento.Text != "" && tb_cpf.Text != "")
            {
                try
                {
                    JsonSerializer serializador = new JsonSerializer();
                    StreamWriter arquivo = new StreamWriter(@"C:\Users\Usuario\Documents\DANI\ACADEMIA ATOS\SERIALIZACAO\ExemplosSerializacao\Arquivos\dadosJSON.data");
                    JsonWriter escritor = new JsonTextWriter(arquivo);
                    serializador.Serialize(escritor, p);
                    arquivo.Close();
                    escritor.Close();

                    MessageBox.Show("Sucesso para serializar com JSON");
                    Limpar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("É OBRIGATÓRIO PREENCHER TODOS OS CAMPOS");
            }
        }
    }
}
