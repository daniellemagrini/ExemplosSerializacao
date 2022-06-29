namespace ExemplosSerializacao
{
    partial class frm_serializacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_data_nascimento = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_dt_nascimento = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.bt_binary = new System.Windows.Forms.Button();
            this.bt_soap = new System.Windows.Forms.Button();
            this.bt_xml = new System.Windows.Forms.Button();
            this.bt_json = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(33, 41);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(47, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "NOME:";
            // 
            // lb_data_nascimento
            // 
            this.lb_data_nascimento.AutoSize = true;
            this.lb_data_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_nascimento.Location = new System.Drawing.Point(33, 90);
            this.lb_data_nascimento.Name = "lb_data_nascimento";
            this.lb_data_nascimento.Size = new System.Drawing.Size(150, 13);
            this.lb_data_nascimento.TabIndex = 1;
            this.lb_data_nascimento.Text = "DATA DE NASCIMENTO:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(33, 144);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(34, 13);
            this.lb_cpf.TabIndex = 2;
            this.lb_cpf.Text = "CPF:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(86, 38);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(228, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // tb_dt_nascimento
            // 
            this.tb_dt_nascimento.Location = new System.Drawing.Point(189, 87);
            this.tb_dt_nascimento.Name = "tb_dt_nascimento";
            this.tb_dt_nascimento.Size = new System.Drawing.Size(125, 20);
            this.tb_dt_nascimento.TabIndex = 4;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(73, 141);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(241, 20);
            this.tb_cpf.TabIndex = 5;
            // 
            // bt_binary
            // 
            this.bt_binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_binary.Location = new System.Drawing.Point(32, 186);
            this.bt_binary.Name = "bt_binary";
            this.bt_binary.Size = new System.Drawing.Size(72, 28);
            this.bt_binary.TabIndex = 6;
            this.bt_binary.Text = "BINARY";
            this.bt_binary.UseVisualStyleBackColor = true;
            this.bt_binary.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_soap
            // 
            this.bt_soap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_soap.Location = new System.Drawing.Point(107, 186);
            this.bt_soap.Name = "bt_soap";
            this.bt_soap.Size = new System.Drawing.Size(72, 28);
            this.bt_soap.TabIndex = 7;
            this.bt_soap.Text = "SOAP";
            this.bt_soap.UseVisualStyleBackColor = true;
            this.bt_soap.Click += new System.EventHandler(this.bt_soap_Click);
            // 
            // bt_xml
            // 
            this.bt_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xml.Location = new System.Drawing.Point(185, 186);
            this.bt_xml.Name = "bt_xml";
            this.bt_xml.Size = new System.Drawing.Size(72, 28);
            this.bt_xml.TabIndex = 8;
            this.bt_xml.Text = "XML";
            this.bt_xml.UseVisualStyleBackColor = true;
            this.bt_xml.Click += new System.EventHandler(this.bt_xml_Click);
            // 
            // bt_json
            // 
            this.bt_json.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_json.Location = new System.Drawing.Point(263, 186);
            this.bt_json.Name = "bt_json";
            this.bt_json.Size = new System.Drawing.Size(72, 28);
            this.bt_json.TabIndex = 9;
            this.bt_json.Text = "JSON";
            this.bt_json.UseVisualStyleBackColor = true;
            this.bt_json.Click += new System.EventHandler(this.bt_json_Click);
            // 
            // frm_serializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 244);
            this.Controls.Add(this.bt_json);
            this.Controls.Add(this.bt_xml);
            this.Controls.Add(this.bt_soap);
            this.Controls.Add(this.bt_binary);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.tb_dt_nascimento);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_data_nascimento);
            this.Controls.Add(this.lb_nome);
            this.Name = "frm_serializacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERIALIZAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_data_nascimento;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_dt_nascimento;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Button bt_binary;
        private System.Windows.Forms.Button bt_soap;
        private System.Windows.Forms.Button bt_xml;
        private System.Windows.Forms.Button bt_json;
    }
}

