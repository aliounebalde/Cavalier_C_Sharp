namespace Cavalier
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimulation = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnLeave2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimulation
            // 
            this.btnSimulation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimulation.ForeColor = System.Drawing.Color.White;
            this.btnSimulation.Location = new System.Drawing.Point(413, 87);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(94, 36);
            this.btnSimulation.TabIndex = 0;
            this.btnSimulation.Text = "Simulation";
            this.btnSimulation.UseVisualStyleBackColor = false;
            this.btnSimulation.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnJouer.ForeColor = System.Drawing.Color.White;
            this.btnJouer.Location = new System.Drawing.Point(227, 85);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(94, 38);
            this.btnJouer.TabIndex = 2;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = false;
            this.btnJouer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Red;
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(319, 143);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(94, 33);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Quitter";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.SystemColors.Highlight;
            this.Redo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Redo.Location = new System.Drawing.Point(686, 95);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(105, 38);
            this.Redo.TabIndex = 4;
            this.Redo.Text = "Annuler Dernier Coup";
            this.Redo.UseVisualStyleBackColor = false;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(683, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit my Github pages";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnRejouer
            // 
            this.btnRejouer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRejouer.ForeColor = System.Drawing.Color.White;
            this.btnRejouer.Location = new System.Drawing.Point(572, 95);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(94, 38);
            this.btnRejouer.TabIndex = 7;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnLeave2
            // 
            this.btnLeave2.BackColor = System.Drawing.Color.Red;
            this.btnLeave2.ForeColor = System.Drawing.Color.White;
            this.btnLeave2.Location = new System.Drawing.Point(634, 172);
            this.btnLeave2.Name = "btnLeave2";
            this.btnLeave2.Size = new System.Drawing.Size(94, 33);
            this.btnLeave2.TabIndex = 8;
            this.btnLeave2.Text = "Quitter";
            this.btnLeave2.UseVisualStyleBackColor = false;
            this.btnLeave2.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeave2);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnSimulation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnLeave2;
    }
}

