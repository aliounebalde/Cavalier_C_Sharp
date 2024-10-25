namespace Cavalier
{
    partial class Simulation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomRadioBtn = new System.Windows.Forms.RadioButton();
            this.manuelRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.breakBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vitesse De Simulation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Appliquer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.breakBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.manuelRadioBtn);
            this.groupBox1.Controls.Add(this.randomRadioBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(547, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Settings";
            // 
            // randomRadioBtn
            // 
            this.randomRadioBtn.AutoSize = true;
            this.randomRadioBtn.Checked = true;
            this.randomRadioBtn.Location = new System.Drawing.Point(6, 49);
            this.randomRadioBtn.Name = "randomRadioBtn";
            this.randomRadioBtn.Size = new System.Drawing.Size(65, 17);
            this.randomRadioBtn.TabIndex = 3;
            this.randomRadioBtn.TabStop = true;
            this.randomRadioBtn.Text = "Random";
            this.randomRadioBtn.UseVisualStyleBackColor = true;
            // 
            // manuelRadioBtn
            // 
            this.manuelRadioBtn.AutoSize = true;
            this.manuelRadioBtn.Location = new System.Drawing.Point(77, 49);
            this.manuelRadioBtn.Name = "manuelRadioBtn";
            this.manuelRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.manuelRadioBtn.TabIndex = 4;
            this.manuelRadioBtn.TabStop = true;
            this.manuelRadioBtn.Text = "Manuel";
            this.manuelRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Case de Départ";
            // 
            // breakBtn
            // 
            this.breakBtn.BackColor = System.Drawing.Color.Red;
            this.breakBtn.ForeColor = System.Drawing.Color.White;
            this.breakBtn.Location = new System.Drawing.Point(119, 120);
            this.breakBtn.Name = "breakBtn";
            this.breakBtn.Size = new System.Drawing.Size(79, 33);
            this.breakBtn.TabIndex = 6;
            this.breakBtn.Text = "Pause";
            this.breakBtn.UseVisualStyleBackColor = false;
            this.breakBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton manuelRadioBtn;
        private System.Windows.Forms.RadioButton randomRadioBtn;
        private System.Windows.Forms.Button breakBtn;
    }
}