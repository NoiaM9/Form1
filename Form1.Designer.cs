namespace Tema2Seminar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            SpnPerioada = new NumericUpDown();
            CboDobanda = new ComboBox();
            groupBox1 = new GroupBox();
            OptEuro = new RadioButton();
            OptLei = new RadioButton();
            groupBox2 = new GroupBox();
            Optamortismente = new RadioButton();
            OptAnuitati = new RadioButton();
            BtnCalcul = new Button();
            BtnReset = new Button();
            BtnIesire = new Button();
            LstRambursare = new ListBox();
            ((System.ComponentModel.ISupportInitialize)SpnPerioada).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Suma imprumutata";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Perioada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 106);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 2;
            label3.Text = "Rata dobanzii";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 56);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Luni";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(140, 15);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(136, 23);
            txtSuma.TabIndex = 4;
            // 
            // SpnPerioada
            // 
            SpnPerioada.Location = new Point(101, 54);
            SpnPerioada.Maximum = new decimal(new int[] { 420, 0, 0, 0 });
            SpnPerioada.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            SpnPerioada.Name = "SpnPerioada";
            SpnPerioada.Size = new Size(120, 23);
            SpnPerioada.TabIndex = 5;
            SpnPerioada.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // CboDobanda
            // 
            CboDobanda.FormattingEnabled = true;
            CboDobanda.Location = new Point(115, 107);
            CboDobanda.Name = "CboDobanda";
            CboDobanda.Size = new Size(121, 23);
            CboDobanda.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OptEuro);
            groupBox1.Controls.Add(OptLei);
            groupBox1.Location = new Point(384, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "moneda";
            // 
            // OptEuro
            // 
            OptEuro.AutoSize = true;
            OptEuro.Location = new Point(4, 55);
            OptEuro.Name = "OptEuro";
            OptEuro.Size = new Size(49, 19);
            OptEuro.TabIndex = 1;
            OptEuro.TabStop = true;
            OptEuro.Text = "Euro";
            OptEuro.UseVisualStyleBackColor = true;
            // 
            // OptLei
            // 
            OptLei.AutoSize = true;
            OptLei.Location = new Point(7, 26);
            OptLei.Name = "OptLei";
            OptLei.Size = new Size(40, 19);
            OptLei.TabIndex = 0;
            OptLei.TabStop = true;
            OptLei.Text = "Lei";
            OptLei.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Optamortismente);
            groupBox2.Controls.Add(OptAnuitati);
            groupBox2.Location = new Point(712, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Metoda rambursare";
            // 
            // Optamortismente
            // 
            Optamortismente.AutoSize = true;
            Optamortismente.Location = new Point(4, 45);
            Optamortismente.Name = "Optamortismente";
            Optamortismente.Size = new Size(154, 19);
            Optamortismente.TabIndex = 1;
            Optamortismente.TabStop = true;
            Optamortismente.Text = "amortismente constante";
            Optamortismente.UseVisualStyleBackColor = true;
            // 
            // OptAnuitati
            // 
            OptAnuitati.AutoSize = true;
            OptAnuitati.Location = new Point(3, 18);
            OptAnuitati.Name = "OptAnuitati";
            OptAnuitati.Size = new Size(122, 19);
            OptAnuitati.TabIndex = 0;
            OptAnuitati.TabStop = true;
            OptAnuitati.Text = "Anuitati constante";
            OptAnuitati.UseVisualStyleBackColor = true;
            // 
            // BtnCalcul
            // 
            BtnCalcul.Location = new Point(1157, 41);
            BtnCalcul.Name = "BtnCalcul";
            BtnCalcul.Size = new Size(139, 63);
            BtnCalcul.TabIndex = 9;
            BtnCalcul.Text = "Calcul";
            BtnCalcul.UseVisualStyleBackColor = true;
            BtnCalcul.Click += BtnCalcul_Click;
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(1157, 138);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(139, 63);
            BtnReset.TabIndex = 10;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnIesire
            // 
            BtnIesire.Location = new Point(1157, 232);
            BtnIesire.Name = "BtnIesire";
            BtnIesire.Size = new Size(139, 63);
            BtnIesire.TabIndex = 11;
            BtnIesire.Text = "Iesire";
            BtnIesire.UseVisualStyleBackColor = true;
            BtnIesire.Click += BtnIesire_Click;
            // 
            // LstRambursare
            // 
            LstRambursare.FormattingEnabled = true;
            LstRambursare.ItemHeight = 15;
            LstRambursare.Location = new Point(219, 346);
            LstRambursare.Name = "LstRambursare";
            LstRambursare.Size = new Size(856, 244);
            LstRambursare.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 627);
            Controls.Add(LstRambursare);
            Controls.Add(BtnIesire);
            Controls.Add(BtnReset);
            Controls.Add(BtnCalcul);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(CboDobanda);
            Controls.Add(SpnPerioada);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SpnPerioada).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private NumericUpDown SpnPerioada;
        private ComboBox CboDobanda;
        private GroupBox groupBox1;
        private RadioButton OptEuro;
        private RadioButton OptLei;
        private GroupBox groupBox2;
        private RadioButton Optamortismente;
        private RadioButton OptAnuitati;
        private Button BtnCalcul;
        private Button BtnReset;
        private Button BtnIesire;
        private ListBox LstRambursare;
    }
}
