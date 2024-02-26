using System;

namespace NavegadorWeb1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaDelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.buttonOrdenarAscendente = new System.Windows.Forms.Button();
            this.buttonOrdenarDescendente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.hacToolStripMenuItem,
            this.haciaDelanteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.menuToolStripMenuItem.Text = "Navegar";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.inicioToolStripMenuItem.Text = "Inicio ";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // hacToolStripMenuItem
            // 
            this.hacToolStripMenuItem.Name = "hacToolStripMenuItem";
            this.hacToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hacToolStripMenuItem.Text = "Hacia atras";
            this.hacToolStripMenuItem.Click += new System.EventHandler(this.hacToolStripMenuItem_Click);
            // 
            // haciaDelanteToolStripMenuItem
            // 
            this.haciaDelanteToolStripMenuItem.Name = "haciaDelanteToolStripMenuItem";
            this.haciaDelanteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.haciaDelanteToolStripMenuItem.Text = "Hacia delante ";
            this.haciaDelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaDelanteToolStripMenuItem_Click);
            // 
            // buttonIr
            // 
            this.buttonIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIr.Location = new System.Drawing.Point(470, 24);
            this.buttonIr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(106, 28);
            this.buttonIr.TabIndex = 1;
            this.buttonIr.Text = "Buscar";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.buttonIr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://www.youtube.com",
            "https://virtual.mesoamericana.edu.gt",
            "https://github.com"});
            this.comboBox1.Location = new System.Drawing.Point(9, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(457, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(9, 57);
            this.webView21.Margin = new System.Windows.Forms.Padding(2);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(693, 420);
            this.webView21.Source = new System.Uri("https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwjeiOnihJyEAxX0TDABHcSeCzgQ" +
        "PAgJ", System.UriKind.Absolute);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.Location = new System.Drawing.Point(748, 59);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(401, 368);
            this.listBoxHistorial.TabIndex = 4;
            this.listBoxHistorial.SelectedIndexChanged += new System.EventHandler(this.listBoxHistorial_SelectedIndexChanged);
            // 
            // buttonOrdenarAscendente
            // 
            this.buttonOrdenarAscendente.Location = new System.Drawing.Point(760, 445);
            this.buttonOrdenarAscendente.Name = "buttonOrdenarAscendente";
            this.buttonOrdenarAscendente.Size = new System.Drawing.Size(126, 31);
            this.buttonOrdenarAscendente.TabIndex = 5;
            this.buttonOrdenarAscendente.Text = "ascendente";
            this.buttonOrdenarAscendente.UseVisualStyleBackColor = true;
            this.buttonOrdenarAscendente.Click += new System.EventHandler(this.buttonOrdenarAscendente_Click);
            // 
            // buttonOrdenarDescendente
            // 
            this.buttonOrdenarDescendente.Location = new System.Drawing.Point(918, 445);
            this.buttonOrdenarDescendente.Name = "buttonOrdenarDescendente";
            this.buttonOrdenarDescendente.Size = new System.Drawing.Size(135, 31);
            this.buttonOrdenarDescendente.TabIndex = 6;
            this.buttonOrdenarDescendente.Text = "descendente";
            this.buttonOrdenarDescendente.UseVisualStyleBackColor = true;
            this.buttonOrdenarDescendente.Click += new System.EventHandler(this.buttonOrdenarDescendente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 488);
            this.Controls.Add(this.buttonOrdenarDescendente);
            this.Controls.Add(this.buttonOrdenarAscendente);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonIr);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBoxHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaDelanteToolStripMenuItem;
        private System.Windows.Forms.Button buttonIr;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.Button buttonOrdenarAscendente;
        private System.Windows.Forms.Button buttonOrdenarDescendente;
    }
}

