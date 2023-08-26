namespace Price_calculator
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
            this.Minutes_TextBox = new System.Windows.Forms.TextBox();
            this.Minutes_label = new System.Windows.Forms.Label();
            this.Stabilizante_Grande_RadioButton = new System.Windows.Forms.RadioButton();
            this.Stabilizante_Chico_RadioButton = new System.Windows.Forms.RadioButton();
            this.Pago_por_Hora_TextBox = new System.Windows.Forms.TextBox();
            this.Pago_por_Hora_Lable = new System.Windows.Forms.Label();
            this.Item_Count_TextBox = new System.Windows.Forms.TextBox();
            this.item_Count_Lable = new System.Windows.Forms.Label();
            this.Precio_De_Articulo_lable = new System.Windows.Forms.Label();
            this.Precio_De_Articulo_TextBox = new System.Windows.Forms.TextBox();
            this.OutPut_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Minutes_TextBox
            // 
            this.Minutes_TextBox.Location = new System.Drawing.Point(142, 9);
            this.Minutes_TextBox.Name = "Minutes_TextBox";
            this.Minutes_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Minutes_TextBox.TabIndex = 0;
            this.Minutes_TextBox.TextChanged += new System.EventHandler(this.Minutes_TextBox_TextChanged);
            // 
            // Minutes_label
            // 
            this.Minutes_label.AutoSize = true;
            this.Minutes_label.Location = new System.Drawing.Point(83, 12);
            this.Minutes_label.Name = "Minutes_label";
            this.Minutes_label.Size = new System.Drawing.Size(53, 16);
            this.Minutes_label.TabIndex = 2;
            this.Minutes_label.Text = "Minutes";
            this.Minutes_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Stabilizante_Grande_RadioButton
            // 
            this.Stabilizante_Grande_RadioButton.AutoSize = true;
            this.Stabilizante_Grande_RadioButton.Location = new System.Drawing.Point(9, 126);
            this.Stabilizante_Grande_RadioButton.Name = "Stabilizante_Grande_RadioButton";
            this.Stabilizante_Grande_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stabilizante_Grande_RadioButton.Size = new System.Drawing.Size(145, 20);
            this.Stabilizante_Grande_RadioButton.TabIndex = 5;
            this.Stabilizante_Grande_RadioButton.TabStop = true;
            this.Stabilizante_Grande_RadioButton.Text = "Stabilizante Grande";
            this.Stabilizante_Grande_RadioButton.UseVisualStyleBackColor = true;
            this.Stabilizante_Grande_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Stabilizante_Chico_RadioButton
            // 
            this.Stabilizante_Chico_RadioButton.AutoSize = true;
            this.Stabilizante_Chico_RadioButton.Location = new System.Drawing.Point(16, 152);
            this.Stabilizante_Chico_RadioButton.Name = "Stabilizante_Chico_RadioButton";
            this.Stabilizante_Chico_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Stabilizante_Chico_RadioButton.Size = new System.Drawing.Size(134, 20);
            this.Stabilizante_Chico_RadioButton.TabIndex = 6;
            this.Stabilizante_Chico_RadioButton.TabStop = true;
            this.Stabilizante_Chico_RadioButton.Text = "Stabilizante Chico";
            this.Stabilizante_Chico_RadioButton.UseVisualStyleBackColor = true;
            this.Stabilizante_Chico_RadioButton.CheckedChanged += new System.EventHandler(this.Stabilizante_Chico_RadioButton_CheckedChanged);
            // 
            // Pago_por_Hora_TextBox
            // 
            this.Pago_por_Hora_TextBox.Location = new System.Drawing.Point(142, 37);
            this.Pago_por_Hora_TextBox.Name = "Pago_por_Hora_TextBox";
            this.Pago_por_Hora_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Pago_por_Hora_TextBox.TabIndex = 7;
            this.Pago_por_Hora_TextBox.TextChanged += new System.EventHandler(this.Pago_por_Hora_TextBox_TextChanged);
            // 
            // Pago_por_Hora_Lable
            // 
            this.Pago_por_Hora_Lable.AutoSize = true;
            this.Pago_por_Hora_Lable.Location = new System.Drawing.Point(43, 37);
            this.Pago_por_Hora_Lable.Name = "Pago_por_Hora_Lable";
            this.Pago_por_Hora_Lable.Size = new System.Drawing.Size(93, 16);
            this.Pago_por_Hora_Lable.TabIndex = 8;
            this.Pago_por_Hora_Lable.Text = "Pago por hora";
            // 
            // Item_Count_TextBox
            // 
            this.Item_Count_TextBox.Location = new System.Drawing.Point(142, 66);
            this.Item_Count_TextBox.Name = "Item_Count_TextBox";
            this.Item_Count_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Item_Count_TextBox.TabIndex = 9;
            this.Item_Count_TextBox.TextChanged += new System.EventHandler(this.Item_Count_TextBox_TextChanged);
            // 
            // item_Count_Lable
            // 
            this.item_Count_Lable.AutoSize = true;
            this.item_Count_Lable.Location = new System.Drawing.Point(3, 69);
            this.item_Count_Lable.Name = "item_Count_Lable";
            this.item_Count_Lable.Size = new System.Drawing.Size(133, 16);
            this.item_Count_Lable.TabIndex = 10;
            this.item_Count_Lable.Text = "Cantidad de articulos";
            // 
            // Precio_De_Articulo_lable
            // 
            this.Precio_De_Articulo_lable.AutoSize = true;
            this.Precio_De_Articulo_lable.Location = new System.Drawing.Point(25, 98);
            this.Precio_De_Articulo_lable.Name = "Precio_De_Articulo_lable";
            this.Precio_De_Articulo_lable.Size = new System.Drawing.Size(111, 16);
            this.Precio_De_Articulo_lable.TabIndex = 11;
            this.Precio_De_Articulo_lable.Text = "Precio de articulo";
            // 
            // Precio_De_Articulo_TextBox
            // 
            this.Precio_De_Articulo_TextBox.Location = new System.Drawing.Point(142, 98);
            this.Precio_De_Articulo_TextBox.Name = "Precio_De_Articulo_TextBox";
            this.Precio_De_Articulo_TextBox.Size = new System.Drawing.Size(100, 22);
            this.Precio_De_Articulo_TextBox.TabIndex = 12;
            this.Precio_De_Articulo_TextBox.TextChanged += new System.EventHandler(this.Precio_De_Articulo_TextBox_TextChanged);
            // 
            // OutPut_lable
            // 
            this.OutPut_lable.AutoSize = true;
            this.OutPut_lable.Location = new System.Drawing.Point(28, 211);
            this.OutPut_lable.Name = "OutPut_lable";
            this.OutPut_lable.Size = new System.Drawing.Size(0, 16);
            this.OutPut_lable.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutPut_lable);
            this.Controls.Add(this.Precio_De_Articulo_TextBox);
            this.Controls.Add(this.Precio_De_Articulo_lable);
            this.Controls.Add(this.item_Count_Lable);
            this.Controls.Add(this.Item_Count_TextBox);
            this.Controls.Add(this.Pago_por_Hora_Lable);
            this.Controls.Add(this.Pago_por_Hora_TextBox);
            this.Controls.Add(this.Stabilizante_Chico_RadioButton);
            this.Controls.Add(this.Stabilizante_Grande_RadioButton);
            this.Controls.Add(this.Minutes_label);
            this.Controls.Add(this.Minutes_TextBox);
            this.Name = "Form1";
            this.Text = "Claculadora Del Precio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Minutes_TextBox;
        private System.Windows.Forms.Label Minutes_label;
        private System.Windows.Forms.RadioButton Stabilizante_Grande_RadioButton;
        private System.Windows.Forms.RadioButton Stabilizante_Chico_RadioButton;
        private System.Windows.Forms.TextBox Pago_por_Hora_TextBox;
        private System.Windows.Forms.Label Pago_por_Hora_Lable;
        private System.Windows.Forms.TextBox Item_Count_TextBox;
        private System.Windows.Forms.Label item_Count_Lable;
        private System.Windows.Forms.Label Precio_De_Articulo_lable;
        private System.Windows.Forms.TextBox Precio_De_Articulo_TextBox;
        private System.Windows.Forms.Label OutPut_lable;
    }
}

