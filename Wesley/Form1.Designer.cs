namespace Wesley
{
    partial class frmACME
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
            this.dgvVoos = new System.Windows.Forms.DataGridView();
            this.DATA_VOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL_DOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISTANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoos)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVoos
            // 
            this.dgvVoos.AllowUserToAddRows = false;
            this.dgvVoos.AllowUserToDeleteRows = false;
            this.dgvVoos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA_VOO,
            this.CAPTURA,
            this.NIVEL_DOR,
            this.ID_VOO,
            this.CUSTO,
            this.DISTANCIA});
            this.dgvVoos.Location = new System.Drawing.Point(12, 12);
            this.dgvVoos.Name = "dgvVoos";
            this.dgvVoos.Size = new System.Drawing.Size(345, 270);
            this.dgvVoos.TabIndex = 0;
            this.dgvVoos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoos_CellClick);
            this.dgvVoos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoos_CellContentClick);
            // 
            // DATA_VOO
            // 
            this.DATA_VOO.DataPropertyName = "DATA_VOO";
            this.DATA_VOO.HeaderText = "Data";
            this.DATA_VOO.Name = "DATA_VOO";
            // 
            // CAPTURA
            // 
            this.CAPTURA.DataPropertyName = "CAPTURA";
            this.CAPTURA.HeaderText = "Captura";
            this.CAPTURA.Name = "CAPTURA";
            // 
            // NIVEL_DOR
            // 
            this.NIVEL_DOR.DataPropertyName = "NIVEL_DOR";
            this.NIVEL_DOR.HeaderText = "Nivel de Dor";
            this.NIVEL_DOR.Name = "NIVEL_DOR";
            // 
            // ID_VOO
            // 
            this.ID_VOO.DataPropertyName = "ID_VOO";
            this.ID_VOO.HeaderText = "ID";
            this.ID_VOO.Name = "ID_VOO";
            this.ID_VOO.Visible = false;
            // 
            // CUSTO
            // 
            this.CUSTO.DataPropertyName = "CUSTO";
            this.CUSTO.HeaderText = "Custo";
            this.CUSTO.Name = "CUSTO";
            this.CUSTO.Visible = false;
            // 
            // DISTANCIA
            // 
            this.DISTANCIA.DataPropertyName = "DISTANCIA";
            this.DISTANCIA.HeaderText = "Distancia";
            this.DISTANCIA.Name = "DISTANCIA";
            this.DISTANCIA.Visible = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnIncluir);
            this.pnlButtons.Controls.Add(this.btnExcluir);
            this.pnlButtons.Location = new System.Drawing.Point(372, 13);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(264, 33);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Inserir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(93, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.rbSim);
            this.pnlCampos.Controls.Add(this.rbNao);
            this.pnlCampos.Controls.Add(this.btnSalvar);
            this.pnlCampos.Controls.Add(this.btnCancelar);
            this.pnlCampos.Controls.Add(this.txtNivelDor);
            this.pnlCampos.Controls.Add(this.txtDistancia);
            this.pnlCampos.Controls.Add(this.txtCusto);
            this.pnlCampos.Controls.Add(this.txtData);
            this.pnlCampos.Controls.Add(this.label1);
            this.pnlCampos.Controls.Add(this.label2);
            this.pnlCampos.Controls.Add(this.label3);
            this.pnlCampos.Controls.Add(this.label5);
            this.pnlCampos.Controls.Add(this.label4);
            this.pnlCampos.Location = new System.Drawing.Point(372, 52);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(264, 231);
            this.pnlCampos.TabIndex = 2;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(161, 117);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 11;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(78, 117);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Nao";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(42, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Location = new System.Drawing.Point(78, 150);
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(168, 20);
            this.txtNivelDor.TabIndex = 9;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(78, 81);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(168, 20);
            this.txtDistancia.TabIndex = 8;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(78, 48);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(168, 20);
            this.txtCusto.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(78, 15);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(168, 20);
            this.txtData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nivel Dor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Captura";
            // 
            // frmACME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 295);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvVoos);
            this.Name = "frmACME";
            this.ShowIcon = false;
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.frmACME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoos)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVoos;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_VOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_DOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISTANCIA;
    }
}

