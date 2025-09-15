namespace ProjetoPizzaria
{
    partial class Form1
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
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(38, 53);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(137, 21);
            this.cmbTamanhoPizza.TabIndex = 0;
            this.cmbTamanhoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Location = new System.Drawing.Point(239, 61);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorPizza.TabIndex = 1;
            this.lblValorPizza.Text = "VALOR DA PIZZA";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(431, 61);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 2;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            this.lblValorOpcionais.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(664, 61);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 3;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(234, 85);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(100, 20);
            this.txtValorPizza.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(657, 85);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagar.TabIndex = 7;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(450, 85);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcionais.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(38, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(6, 31);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 11;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 100);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 14;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.checkBox3);
            this.grpOpcionais.Controls.Add(this.checkBox4);
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Controls.Add(this.checkBox2);
            this.grpOpcionais.Location = new System.Drawing.Point(57, 140);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(102, 143);
            this.grpOpcionais.TabIndex = 15;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(780, 588);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 293);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorPizza);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

