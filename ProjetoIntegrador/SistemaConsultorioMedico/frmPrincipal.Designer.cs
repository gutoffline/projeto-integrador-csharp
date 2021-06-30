namespace SistemaConsultorioMedico
{
    partial class frmPrincipal
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
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPacitenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarUmPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.novoPacitenteToolStripMenuItem,
            this.alterarPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listagemToolStripMenuItem.Text = "Listar todos";
            this.listagemToolStripMenuItem.Click += new System.EventHandler(this.listagemToolStripMenuItem_Click);
            // 
            // novoPacitenteToolStripMenuItem
            // 
            this.novoPacitenteToolStripMenuItem.Name = "novoPacitenteToolStripMenuItem";
            this.novoPacitenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoPacitenteToolStripMenuItem.Text = "Novo pacitente";
            this.novoPacitenteToolStripMenuItem.Click += new System.EventHandler(this.novoPacitenteToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTodosToolStripMenuItem,
            this.novoMédicoToolStripMenuItem});
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.médicosToolStripMenuItem.Text = "Médicos";
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.listarTodosToolStripMenuItem.Text = "Listar todos";
            // 
            // novoMédicoToolStripMenuItem
            // 
            this.novoMédicoToolStripMenuItem.Name = "novoMédicoToolStripMenuItem";
            this.novoMédicoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.novoMédicoToolStripMenuItem.Text = "Novo médico";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAgendaToolStripMenuItem,
            this.agendarUmPacienteToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // verAgendaToolStripMenuItem
            // 
            this.verAgendaToolStripMenuItem.Name = "verAgendaToolStripMenuItem";
            this.verAgendaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verAgendaToolStripMenuItem.Text = "Ver agenda";
            // 
            // agendarUmPacienteToolStripMenuItem
            // 
            this.agendarUmPacienteToolStripMenuItem.Name = "agendarUmPacienteToolStripMenuItem";
            this.agendarUmPacienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.agendarUmPacienteToolStripMenuItem.Text = "Agendar um paciente";
            // 
            // alterarPacienteToolStripMenuItem
            // 
            this.alterarPacienteToolStripMenuItem.Name = "alterarPacienteToolStripMenuItem";
            this.alterarPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarPacienteToolStripMenuItem.Text = "Alterar paciente";
            this.alterarPacienteToolStripMenuItem.Click += new System.EventHandler(this.alterarPacienteToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema Consultório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPacitenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarUmPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarPacienteToolStripMenuItem;
    }
}