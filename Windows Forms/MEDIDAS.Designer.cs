namespace Windows_Forms
{
    partial class MEDIDAS
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
            this.buttonconvert = new System.Windows.Forms.Button();
            this.TxtConverter = new System.Windows.Forms.TextBox();
            this.TxtConvertido = new System.Windows.Forms.TextBox();
            this.PreConverter = new System.Windows.Forms.Label();
            this.PosConverter = new System.Windows.Forms.Label();
            this.OPTION = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonconvert
            // 
            this.buttonconvert.Location = new System.Drawing.Point(542, 180);
            this.buttonconvert.Name = "buttonconvert";
            this.buttonconvert.Size = new System.Drawing.Size(208, 94);
            this.buttonconvert.TabIndex = 0;
            this.buttonconvert.Text = "Converter";
            this.buttonconvert.UseVisualStyleBackColor = true;
            this.buttonconvert.Click += new System.EventHandler(this.buttonconvert_Click);
            // 
            // TxtConverter
            // 
            this.TxtConverter.Location = new System.Drawing.Point(542, 89);
            this.TxtConverter.Multiline = true;
            this.TxtConverter.Name = "TxtConverter";
            this.TxtConverter.Size = new System.Drawing.Size(208, 46);
            this.TxtConverter.TabIndex = 1;
            this.TxtConverter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtConvertido
            // 
            this.TxtConvertido.Location = new System.Drawing.Point(542, 324);
            this.TxtConvertido.Multiline = true;
            this.TxtConvertido.Name = "TxtConvertido";
            this.TxtConvertido.Size = new System.Drawing.Size(208, 46);
            this.TxtConvertido.TabIndex = 2;
            this.TxtConvertido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PreConverter
            // 
            this.PreConverter.AutoSize = true;
            this.PreConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreConverter.Location = new System.Drawing.Point(330, 98);
            this.PreConverter.Name = "PreConverter";
            this.PreConverter.Size = new System.Drawing.Size(182, 25);
            this.PreConverter.TabIndex = 4;
            this.PreConverter.Text = "Valor a converter:";
            this.PreConverter.Click += new System.EventHandler(this.label1_Click);
            // 
            // PosConverter
            // 
            this.PosConverter.AutoSize = true;
            this.PosConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosConverter.Location = new System.Drawing.Point(330, 334);
            this.PosConverter.Name = "PosConverter";
            this.PosConverter.Size = new System.Drawing.Size(174, 25);
            this.PosConverter.TabIndex = 5;
            this.PosConverter.Text = "Valor convertido:";
            this.PosConverter.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OPTION
            // 
            this.OPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTION.FormattingEnabled = true;
            this.OPTION.Items.AddRange(new object[] {
            "Celsius -> Fahrenheit",
            "Fahrenheit -> Celsius"});
            this.OPTION.Location = new System.Drawing.Point(73, 209);
            this.OPTION.Name = "OPTION";
            this.OPTION.Size = new System.Drawing.Size(417, 33);
            this.OPTION.TabIndex = 6;
            this.OPTION.Text = "Escolha a medidada...";
            this.OPTION.SelectedIndexChanged += new System.EventHandler(this.OPTION_SelectedIndexChanged);
            // 
            // MEDIDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OPTION);
            this.Controls.Add(this.PosConverter);
            this.Controls.Add(this.PreConverter);
            this.Controls.Add(this.TxtConvertido);
            this.Controls.Add(this.TxtConverter);
            this.Controls.Add(this.buttonconvert);
            this.Name = "MEDIDAS";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonconvert;
        private System.Windows.Forms.TextBox TxtConverter;
        private System.Windows.Forms.TextBox TxtConvertido;
        private System.Windows.Forms.Label PreConverter;
        private System.Windows.Forms.Label PosConverter;
        private System.Windows.Forms.ComboBox OPTION;
    }
}

