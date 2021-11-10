
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
            this.btnListaQuartosOcupados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridListaDeQuartos = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(231, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área de visualização dos quartos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListaQuartosDisponiveis
            // 
            this.btnListaQuartosDisponiveis.BackColor = System.Drawing.Color.Silver;
            this.btnListaQuartosDisponiveis.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListaQuartosDisponiveis.FlatAppearance.BorderSize = 0;
            this.btnListaQuartosDisponiveis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaQuartosDisponiveis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListaQuartosDisponiveis.Location = new System.Drawing.Point(602, 161);
            this.btnListaQuartosDisponiveis.Name = "btnListaQuartosDisponiveis";
            this.btnListaQuartosDisponiveis.Size = new System.Drawing.Size(150, 51);
            this.btnListaQuartosDisponiveis.TabIndex = 2;
            this.btnListaQuartosDisponiveis.Text = "Verificar quartos disponíveis";
            this.btnListaQuartosDisponiveis.UseVisualStyleBackColor = false;
            // 
            // btnListaQuartosOcupados
            // 
            this.btnListaQuartosOcupados.BackColor = System.Drawing.Color.Silver;
            this.btnListaQuartosOcupados.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListaQuartosOcupados.FlatAppearance.BorderSize = 2;
            this.btnListaQuartosOcupados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaQuartosOcupados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListaQuartosOcupados.Location = new System.Drawing.Point(602, 95);
            this.btnListaQuartosOcupados.Name = "btnListaQuartosOcupados";
            this.btnListaQuartosOcupados.Size = new System.Drawing.Size(150, 47);
            this.btnListaQuartosOcupados.TabIndex = 3;
            this.btnListaQuartosOcupados.Text = "Verificar quartos ocupados";
            this.btnListaQuartosOcupados.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dataGridListaDeQuartos);
            this.groupBox1.Location = new System.Drawing.Point(131, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de quartos";
            // 
            // dataGridListaDeQuartos
            // 
            this.dataGridListaDeQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridListaDeQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridListaDeQuartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridListaDeQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaDeQuartos.Location = new System.Drawing.Point(19, 33);
            this.dataGridListaDeQuartos.Name = "dataGridListaDeQuartos";
            this.dataGridListaDeQuartos.Size = new System.Drawing.Size(642, 223);
            this.dataGridListaDeQuartos.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Silver;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoltar.Location = new System.Drawing.Point(237, 122);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 47);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar a tela inicial";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FrmQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::LmjHotelDesktopApp.Properties.Resources.logotipo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(892, 553);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListaQuartosOcupados);
            this.Controls.Add(this.btnListaQuartosDisponiveis);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmQuartos";
            this.Text = "Listagem de quartos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaDeQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaQuartosDisponiveis;
        private System.Windows.Forms.Button btnListaQuartosOcupados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridListaDeQuartos;
        private System.Windows.Forms.Button btnVoltar;
    }
}