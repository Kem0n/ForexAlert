namespace ForexAlert
{
    partial class AddNewPositionForm
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
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTaik = new System.Windows.Forms.TextBox();
            this.textBoxLoss = new System.Windows.Forms.TextBox();
            this.buttonAddNewPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(22, 35);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(157, 21);
            this.comboBoxCurrency.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(202, 35);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(127, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TAIK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOSS";
            // 
            // textBoxTaik
            // 
            this.textBoxTaik.Location = new System.Drawing.Point(22, 95);
            this.textBoxTaik.Name = "textBoxTaik";
            this.textBoxTaik.Size = new System.Drawing.Size(154, 20);
            this.textBoxTaik.TabIndex = 6;
            // 
            // textBoxLoss
            // 
            this.textBoxLoss.Location = new System.Drawing.Point(202, 95);
            this.textBoxLoss.Name = "textBoxLoss";
            this.textBoxLoss.Size = new System.Drawing.Size(127, 20);
            this.textBoxLoss.TabIndex = 7;
            // 
            // buttonAddNewPosition
            // 
            this.buttonAddNewPosition.Location = new System.Drawing.Point(136, 149);
            this.buttonAddNewPosition.Name = "buttonAddNewPosition";
            this.buttonAddNewPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewPosition.TabIndex = 8;
            this.buttonAddNewPosition.Text = "Add";
            this.buttonAddNewPosition.UseVisualStyleBackColor = true;
            this.buttonAddNewPosition.Click += new System.EventHandler(this.buttonAddNewPosition_Click);
            // 
            // AddNewPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 199);
            this.Controls.Add(this.buttonAddNewPosition);
            this.Controls.Add(this.textBoxLoss);
            this.Controls.Add(this.textBoxTaik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewPositionForm";
            this.Text = "Добавление новой позиции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTaik;
        private System.Windows.Forms.TextBox textBoxLoss;
        private System.Windows.Forms.Button buttonAddNewPosition;
    }
}