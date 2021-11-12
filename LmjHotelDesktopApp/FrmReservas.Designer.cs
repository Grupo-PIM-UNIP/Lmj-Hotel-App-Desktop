namespace LmjHotelDesktopApp
{
    partial class FrmReservas
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
            this.btnListarReservasAtivas = new System.Windows.Forms.Button();
            this.groupBoxListagemReservas = new System.Windows.Forms.GroupBox();
            this.dataGridListagemReservas = new System.Windows.Forms.DataGridView();
            this.btnListarReservasInicioHoje = new System.Windows.Forms.Button();
            this.btnVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.btnListarTodasReservas = new System.Windows.Forms.Button();
            this.groupBoxListagemReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListagemReservas)).BeginInit();
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
            this.label1.Text = "Área de visualização de reservas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnListarReservasAtivas
            // 
            this.btnListarReservasAtivas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarReservasAtivas.BackColor = System.Drawing.Color.Silver;
            this.btnListarReservasAtivas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListarReservasAtivas.FlatAppearance.BorderSize = 0;
            this.btnListarReservasAtivas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarReservasAtivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarReservasAtivas.Location = new System.Drawing.Point(552, 219);
            this.btnListarReservasAtivas.Name = "btnListarReservasAtivas";
            this.btnListarReservasAtivas.Size = new System.Drawing.Size(175, 51);
            this.btnListarReservasAtivas.TabIndex = 2;
            this.btnListarReservasAtivas.Text = "Consultar reservas  com hospedagem ativa";
            this.btnListarReservasAtivas.UseVisualStyleBackColor = false;
            this.btnListarReservasAtivas.Click += new System.EventHandler(this.btnListarReservasAtivas_Click);
            // 
            // groupBoxListagemReservas
            // 
            this.groupBoxListagemReservas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxListagemReservas.Controls.Add(this.dataGridListagemReservas);
            this.groupBoxListagemReservas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListagemReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxListagemReservas.Location = new System.Drawing.Point(48, 287);
            this.groupBoxListagemReservas.Name = "groupBoxListagemReservas";
            this.groupBoxListagemReservas.Size = new System.Drawing.Size(761, 271);
            this.groupBoxListagemReservas.TabIndex = 4;
            this.groupBoxListagemReservas.TabStop = false;
            this.groupBoxListagemReservas.Text = "Reservas";
            // 
            // dataGridListagemReservas
            // 
            this.dataGridListagemReservas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridListagemReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridListagemReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListagemReservas.Location = new System.Drawing.Point(31, 40);
            this.dataGridListagemReservas.Name = "dataGridListagemReservas";
            this.dataGridListagemReservas.Size = new System.Drawing.Size(698, 209);
            this.dataGridListagemReservas.TabIndex = 2;
            // 
            // btnListarReservasInicioHoje
            // 
            this.btnListarReservasInicioHoje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarReservasInicioHoje.BackColor = System.Drawing.Color.Silver;
            this.btnListarReservasInicioHoje.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListarReservasInicioHoje.FlatAppearance.BorderSize = 0;
            this.btnListarReservasInicioHoje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarReservasInicioHoje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarReservasInicioHoje.Location = new System.Drawing.Point(359, 219);
            this.btnListarReservasInicioHoje.Name = "btnListarReservasInicioHoje";
            this.btnListarReservasInicioHoje.Size = new System.Drawing.Size(165, 51);
            this.btnListarReservasInicioHoje.TabIndex = 5;
            this.btnListarReservasInicioHoje.Text = "Consultar reservas que iniciam hoje";
            this.btnListarReservasInicioHoje.UseVisualStyleBackColor = false;
            this.btnListarReservasInicioHoje.Click += new System.EventHandler(this.btnListarReservasInicioHoje_Click);
            // 
            // btnVoltarTelaPrincipal
            // 
            this.btnVoltarTelaPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltarTelaPrincipal.BackColor = System.Drawing.Color.Silver;
            this.btnVoltarTelaPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnVoltarTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarTelaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVoltarTelaPrincipal.Location = new System.Drawing.Point(562, 115);
            this.btnVoltarTelaPrincipal.Name = "btnVoltarTelaPrincipal";
            this.btnVoltarTelaPrincipal.Size = new System.Drawing.Size(150, 51);
            this.btnVoltarTelaPrincipal.TabIndex = 6;
            this.btnVoltarTelaPrincipal.Text = "Voltar a tela principal";
            this.btnVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btnVoltarTelaPrincipal.Click += new System.EventHandler(this.btnVoltarTelaPrincipal_Click);
            // 
            // btnListarTodasReservas
            // 
            this.btnListarTodasReservas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarTodasReservas.BackColor = System.Drawing.Color.Silver;
            this.btnListarTodasReservas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnListarTodasReservas.FlatAppearance.BorderSize = 0;
            this.btnListarTodasReservas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodasReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListarTodasReservas.Location = new System.Drawing.Point(175, 219);
            this.btnListarTodasReservas.Name = "btnListarTodasReservas";
            this.btnListarTodasReservas.Size = new System.Drawing.Size(143, 51);
            this.btnListarTodasReservas.TabIndex = 7;
            this.btnListarTodasReservas.Text = "Consultar todas as reservas";
            this.btnListarTodasReservas.UseVisualStyleBackColor = false;
            this.btnListarTodasReservas.Click += new System.EventHandler(this.btnListarTodasReservas_Click);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::LmjHotelDesktopApp.Properties.Resources.logotipo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(837, 570);
            this.Controls.Add(this.btnListarTodasReservas);
            this.Controls.Add(this.btnVoltarTelaPrincipal);
            this.Controls.Add(this.btnListarReservasInicioHoje);
            this.Controls.Add(this.groupBoxListagemReservas);
            this.Controls.Add(this.btnListarReservasAtivas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmReservas";
            this.Text = "Listagem de quartos";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.groupBoxListagemReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListagemReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarReservasAtivas;
        private System.Windows.Forms.GroupBox groupBoxListagemReservas;
        private System.Windows.Forms.DataGridView dataGridListagemReservas;
        private System.Windows.Forms.Button btnListarReservasInicioHoje;
        private System.Windows.Forms.Button btnVoltarTelaPrincipal;
        private System.Windows.Forms.Button btnListarTodasReservas;
    }
}