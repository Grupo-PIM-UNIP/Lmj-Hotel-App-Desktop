
namespace LmjHotelDesktopApp
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripConsultarReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripConsultarQuartos = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartosToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConsultarReservas});
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.quartosToolStripMenuItem.Text = "Reservas";
            // 
            // toolStripConsultarReservas
            // 
            this.toolStripConsultarReservas.Name = "toolStripConsultarReservas";
            this.toolStripConsultarReservas.Size = new System.Drawing.Size(180, 22);
            this.toolStripConsultarReservas.Text = "Consultar";
            this.toolStripConsultarReservas.Click += new System.EventHandler(this.toolStripConsultarReservas_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripConsultarQuartos});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sairToolStripMenuItem.Text = "Quartos";
            // 
            // ToolStripConsultarQuartos
            // 
            this.ToolStripConsultarQuartos.Name = "ToolStripConsultarQuartos";
            this.ToolStripConsultarQuartos.Size = new System.Drawing.Size(180, 22);
            this.ToolStripConsultarQuartos.Text = "Consultar";
            this.ToolStripConsultarQuartos.Click += new System.EventHandler(this.toolStripConsultarQuartos_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::LmjHotelDesktopApp.Properties.Resources.logotipo;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LmjHotelDesktopApp.Properties.Resources.hotel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmPrincipal";
            this.Text = "LMJ Hotel";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripConsultarReservas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripConsultarQuartos;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}

