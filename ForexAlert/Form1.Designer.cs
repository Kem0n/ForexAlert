namespace ForexAlert
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCurrentPosition = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSignal = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUp = new System.Windows.Forms.DataGridView();
            this.CurrencyColumnUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeColumnUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDown = new System.Windows.Forms.DataGridView();
            this.CurrencyColumnDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeColumnDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerSuper = new System.Windows.Forms.Timer(this.components);
            this.СurrencyColumnCurrentPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LossColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaikColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyColumnSignal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PriceColumnSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPosition)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCurrentPosition);
            this.groupBox1.Location = new System.Drawing.Point(267, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущие сделки";
            // 
            // dataGridViewCurrentPosition
            // 
            this.dataGridViewCurrentPosition.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCurrentPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.СurrencyColumnCurrentPosition,
            this.price,
            this.LossColumn,
            this.TaikColumn,
            this.ResultColumn});
            this.dataGridViewCurrentPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCurrentPosition.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCurrentPosition.Name = "dataGridViewCurrentPosition";
            this.dataGridViewCurrentPosition.Size = new System.Drawing.Size(596, 160);
            this.dataGridViewCurrentPosition.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSignal);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 179);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сигналы";
            // 
            // dataGridViewSignal
            // 
            this.dataGridViewSignal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSignal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyColumnSignal,
            this.PriceColumnSignal});
            this.dataGridViewSignal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSignal.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSignal.Name = "dataGridViewSignal";
            this.dataGridViewSignal.Size = new System.Drawing.Size(268, 160);
            this.dataGridViewSignal.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewUp);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 179);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вверх";
            // 
            // dataGridViewUp
            // 
            this.dataGridViewUp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyColumnUp,
            this.ChangeColumnUp});
            this.dataGridViewUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUp.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewUp.Name = "dataGridViewUp";
            this.dataGridViewUp.Size = new System.Drawing.Size(237, 160);
            this.dataGridViewUp.TabIndex = 0;
            // 
            // CurrencyColumnUp
            // 
            this.CurrencyColumnUp.HeaderText = "Валютная пара";
            this.CurrencyColumnUp.Name = "CurrencyColumnUp";
            this.CurrencyColumnUp.Width = 85;
            // 
            // ChangeColumnUp
            // 
            this.ChangeColumnUp.HeaderText = "Изменение";
            this.ChangeColumnUp.Name = "ChangeColumnUp";
            this.ChangeColumnUp.Width = 90;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewDown);
            this.groupBox4.Location = new System.Drawing.Point(15, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 179);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вниз";
            // 
            // dataGridViewDown
            // 
            this.dataGridViewDown.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDown.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CurrencyColumnDown,
            this.ChangeColumnDown});
            this.dataGridViewDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDown.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDown.Name = "dataGridViewDown";
            this.dataGridViewDown.Size = new System.Drawing.Size(237, 160);
            this.dataGridViewDown.TabIndex = 0;
            // 
            // CurrencyColumnDown
            // 
            this.CurrencyColumnDown.HeaderText = "Валютная пара";
            this.CurrencyColumnDown.Name = "CurrencyColumnDown";
            this.CurrencyColumnDown.Width = 85;
            // 
            // ChangeColumnDown
            // 
            this.ChangeColumnDown.HeaderText = "Изменение";
            this.ChangeColumnDown.Name = "ChangeColumnDown";
            this.ChangeColumnDown.Width = 90;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(541, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(200, 76);
            this.labelTime.TabIndex = 24;
            this.labelTime.Text = "00:00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(541, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 84);
            this.textBox1.TabIndex = 25;
            // 
            // timerSuper
            // 
            this.timerSuper.Tick += new System.EventHandler(this.timerSuper_Tick);
            // 
            // СurrencyColumnCurrentPosition
            // 
            this.СurrencyColumnCurrentPosition.HeaderText = "Валютные пары";
            this.СurrencyColumnCurrentPosition.Name = "СurrencyColumnCurrentPosition";
            this.СurrencyColumnCurrentPosition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.СurrencyColumnCurrentPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.СurrencyColumnCurrentPosition.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // LossColumn
            // 
            this.LossColumn.HeaderText = "Стоп-Лосс";
            this.LossColumn.Name = "LossColumn";
            // 
            // TaikColumn
            // 
            this.TaikColumn.HeaderText = "Тейк-Профит";
            this.TaikColumn.Name = "TaikColumn";
            // 
            // ResultColumn
            // 
            this.ResultColumn.HeaderText = "Результат(ПП)";
            this.ResultColumn.Name = "ResultColumn";
            // 
            // CurrencyColumnSignal
            // 
            this.CurrencyColumnSignal.HeaderText = "Валютные пары";
            this.CurrencyColumnSignal.Name = "CurrencyColumnSignal";
            this.CurrencyColumnSignal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrencyColumnSignal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PriceColumnSignal
            // 
            this.PriceColumnSignal.HeaderText = "Цена";
            this.PriceColumnSignal.Name = "PriceColumnSignal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ForexAlert";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentPosition)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCurrentPosition;
        private System.Windows.Forms.DataGridView dataGridViewSignal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyColumnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeColumnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyColumnDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeColumnDown;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerSuper;
        private System.Windows.Forms.DataGridViewComboBoxColumn СurrencyColumnCurrentPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LossColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaikColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CurrencyColumnSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumnSignal;
    }
}

