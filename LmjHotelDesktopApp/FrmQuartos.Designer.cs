namespace LmjHotelDesktopApp
{
    partial class FrmQuartos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaQuartosDisponiveis = new System.Windows.Forms.Button();
            this.groupBoxListagemDeQuartos = new System.Windows.Forms.GroupBox();
            this.dataGridListaDeQuartos = new System.Windows.Forms.DataGridView();
            this.btnListarQuartosOcupados = new System.Windows.Forms.Button();
            this.btnVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.groupBoxListagemDeQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área de visualização dos quartos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListaQuartosDisponiveis
            // 
            this.btnListaQuartosDisponiveis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListaQuartosDisponiveis.BackColor = System.Drawing.Color.Silver;
            this.btnListaQuartosDisponiveis.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListaQuartosDisponiveis.FlatAppearance.BorderSize = 0;
            this.btnListaQuartosDisponiveis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaQuartosDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListaQuartosDisponiveis.Location = new System.Drawing.Point(499, 219);
            this.btnListaQuartosDisponiveis.Name = "btnListaQuartosDisponiveis";
            this.btnListaQuartosDisponiveis.Size = new System.Drawing.Size(150, 51);
            this.btnListaQuartosDisponiveis.TabIndex = 2;
            this.btnListaQuartosDisponiveis.Text = "Verificar quartos disponíveis";
            this.btnListaQuartosDisponiveis.UseVisualStyleBackColor = false;
            this.btnListaQuartosDisponiveis.Click += new System.EventHandler(this.btnListaQuartosDisponiveis_Click);
            // 
            // groupBoxListagemDeQuartos
            // 
            this.groupBoxListagemDeQuartos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxListagemDeQuartos.Controls.Add(this.dataGridListaDeQuartos);
            this.groupBoxListagemDeQuartos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListagemDeQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxListagemDeQuartos.Location = new System.Drawing.Point(262, 287);
            this.groupBoxListagemDeQuartos.Name = "groupBoxListagemDeQuartos";
            this.groupBoxListagemDeQuartos.Size = new System.Drawing.Size(387, 271);
            this.groupBoxListagemDeQuartos.TabIndex = 4;
            this.groupBoxListagemDeQuartos.TabStop = false;
            this.groupBoxListagemDeQuartos.Text = "Lista de quartos";
            // 
            // dataGridListaDeQuartos
            // 
            this.dataGridListaDeQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridListaDeQuartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridListaDeQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaDeQuartos.Location = new System.Drawing.Point(31, 40);
            this.dataGridListaDeQuartos.Name = "dataGridListaDeQuartos";
            this.dataGridListaDeQuartos.Size = new System.Drawing.Size(322, 209);
            this.dataGridListaDeQuartos.TabIndex = 2;
            // 
            // btnListarQuartosOcupados
            // 
            this.btnListarQuartosOcupados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarQuartosOcupados.BackColor = System.Drawing.Color.Silver;
            this.btnListarQuartosOcupados.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListarQuartosOcupados.FlatAppearance.BorderSize = 0;
            this.btnListarQuartosOcupados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarQuartosOcupados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarQuartosOcupados.Location = new System.Drawing.Point(317, 219);
            this.btnListarQuartosOcupados.Name = "btnListarQuartosOcupados";
            this.btnListarQuartosOcupados.Size = new System.Drawing.Size(150, 51);
            this.btnListarQuartosOcupados.TabIndex = 5;
            this.btnListarQuartosOcupados.Text = "Verificar quartos ocupados";
            this.btnListarQuartosOcupados.UseVisualStyleBackColor = false;
            this.btnListarQuartosOcupados.Click += new System.EventHandler(this.btnListarQuartosOcupados_Click);
            // 
            // btnVoltarTelaPrincipal
            // 
            this.btnVoltarTelaPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltarTelaPrincipal.BackColor = System.Drawing.Color.Silver;
            this.btnVoltarTelaPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnVoltarTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarTelaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoltarTelaPrincipal.Location = new System.Drawing.Point(499, 118);
            this.btnVoltarTelaPrincipal.Name = "btnVoltarTelaPrincipal";
            this.btnVoltarTelaPrincipal.Size = new System.Drawing.Size(150, 51);
            this.btnVoltarTelaPrincipal.TabIndex = 6;
            this.btnVoltarTelaPrincipal.Text = "Voltar a tela principal";
            this.btnVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btnVoltarTelaPrincipal.Click += new System.EventHandler(this.btnVoltarTelaPrincipal_Click);
            // 
            // FrmQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::LmjHotelDesktopApp.Properties.Resources.logotipo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(837, 570);
            this.Controls.Add(this.btnVoltarTelaPrincipal);
            this.Controls.Add(this.btnListarQuartosOcupados);
            this.Controls.Add(this.groupBoxListagemDeQuartos);
            this.Controls.Add(this.btnListaQuartosDisponiveis);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmQuartos";
            this.Text = "Listagem de quartos";
            this.Load += new System.EventHandler(this.FrmQuartos_Load);
            this.groupBoxListagemDeQuartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaQuartosDisponiveis;
        private System.Windows.Forms.GroupBox groupBoxListagemDeQuartos;
        private System.Windows.Forms.DataGridView dataGridListaDeQuartos;
        private System.Windows.Forms.Button btnListarQuartosOcupados;
        private System.Windows.Forms.Button btnVoltarTelaPrincipal;
    }
}