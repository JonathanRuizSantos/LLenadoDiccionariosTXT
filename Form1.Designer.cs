namespace LLenadoDeDiccionarios
{
    partial class LLenado_De_Diccionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBT = new System.Windows.Forms.TextBox();
            this.tBKey = new System.Windows.Forms.TextBox();
            this.tBValue = new System.Windows.Forms.TextBox();
            this.BtRun = new System.Windows.Forms.Button();
            this.BtSave = new System.Windows.Forms.Button();
            this.bTLimpiar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.TextBox();
            this.C2 = new System.Windows.Forms.TextBox();
            this.C3 = new System.Windows.Forms.TextBox();
            this.C4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "<T>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // tBT
            // 
            this.tBT.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tBT.Location = new System.Drawing.Point(131, 41);
            this.tBT.Name = "tBT";
            this.tBT.Size = new System.Drawing.Size(219, 31);
            this.tBT.TabIndex = 3;
            this.tBT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBT_KeyPress);
            // 
            // tBKey
            // 
            this.tBKey.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tBKey.Location = new System.Drawing.Point(131, 105);
            this.tBKey.Name = "tBKey";
            this.tBKey.Size = new System.Drawing.Size(219, 31);
            this.tBKey.TabIndex = 4;
            this.tBKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBKey_KeyPress);
            // 
            // tBValue
            // 
            this.tBValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tBValue.Location = new System.Drawing.Point(131, 170);
            this.tBValue.Name = "tBValue";
            this.tBValue.Size = new System.Drawing.Size(219, 31);
            this.tBValue.TabIndex = 5;
            this.tBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBValue_KeyPress);
            // 
            // BtRun
            // 
            this.BtRun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtRun.Location = new System.Drawing.Point(12, 261);
            this.BtRun.Name = "BtRun";
            this.BtRun.Size = new System.Drawing.Size(113, 44);
            this.BtRun.TabIndex = 7;
            this.BtRun.Text = "Ejecutar";
            this.BtRun.UseVisualStyleBackColor = true;
            this.BtRun.Click += new System.EventHandler(this.BtRun_Click);
            // 
            // BtSave
            // 
            this.BtSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtSave.Location = new System.Drawing.Point(139, 261);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(115, 44);
            this.BtSave.TabIndex = 8;
            this.BtSave.Text = "Guardar";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // bTLimpiar
            // 
            this.bTLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTLimpiar.Location = new System.Drawing.Point(270, 261);
            this.bTLimpiar.Name = "bTLimpiar";
            this.bTLimpiar.Size = new System.Drawing.Size(115, 44);
            this.bTLimpiar.TabIndex = 9;
            this.bTLimpiar.Text = "Limpiar";
            this.bTLimpiar.UseVisualStyleBackColor = true;
            this.bTLimpiar.Click += new System.EventHandler(this.bTLimpiar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(391, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(402, 254);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(811, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(413, 254);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Diccionario1(Real)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(879, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Diccionario2(Contraparte)";
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(94, 105);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(31, 31);
            this.C1.TabIndex = 14;
            this.C1.Text = "\"";
            this.C1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(354, 105);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(31, 31);
            this.C2.TabIndex = 15;
            this.C2.Text = "\"";
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(94, 170);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(31, 31);
            this.C3.TabIndex = 16;
            this.C3.Text = "\"";
            this.C3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // C4
            // 
            this.C4.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.C4.Location = new System.Drawing.Point(354, 170);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(31, 31);
            this.C4.TabIndex = 17;
            this.C4.Text = "\"";
            // 
            // LLenado_De_Diccionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 325);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bTLimpiar);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.BtRun);
            this.Controls.Add(this.tBValue);
            this.Controls.Add(this.tBKey);
            this.Controls.Add(this.tBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LLenado_De_Diccionarios";
            this.Text = "LLenado_De_Diccionarios_C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tBT;
        private TextBox tBKey;
        private TextBox tBValue;
        private Button BtRun;
        private Button BtSave;
        private Button bTLimpiar;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label4;
        private Label label5;
        private TextBox C1;
        private TextBox C2;
        private TextBox C3;
        private TextBox C4;
    }
}