﻿namespace SistemaComidaRapida
{
    partial class frmAdministrador
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
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(1025, 24);
            this.menuStripAdmin.TabIndex = 1;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEmpleadosToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.historialDePedidosToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // historialDePedidosToolStripMenuItem
            // 
            this.historialDePedidosToolStripMenuItem.Name = "historialDePedidosToolStripMenuItem";
            this.historialDePedidosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.historialDePedidosToolStripMenuItem.Text = "Historial de Pedidos";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.menuToolStripMenuItem1,
            this.historialToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 519);
            this.Controls.Add(this.menuStripAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAdmin;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrador";
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}