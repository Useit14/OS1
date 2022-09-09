namespace List
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonRemoveByIndex = new System.Windows.Forms.Button();
            this.buttonPrepend = new System.Windows.Forms.Button();
            this.buttonAddMidlle = new System.Windows.Forms.Button();
            this.buttonFindByKey = new System.Windows.Forms.Button();
            this.buttonFindByIndex = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 79);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 186);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(119, 44);
            this.buttonAppend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(68, 28);
            this.buttonAppend.TabIndex = 2;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonRemoveByIndex
            // 
            this.buttonRemoveByIndex.Location = new System.Drawing.Point(200, 111);
            this.buttonRemoveByIndex.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveByIndex.Name = "buttonRemoveByIndex";
            this.buttonRemoveByIndex.Size = new System.Drawing.Size(68, 28);
            this.buttonRemoveByIndex.TabIndex = 4;
            this.buttonRemoveByIndex.Text = "Remove";
            this.buttonRemoveByIndex.UseVisualStyleBackColor = true;
            this.buttonRemoveByIndex.Click += new System.EventHandler(this.buttonRemoveByIndex_Click);
            // 
            // buttonPrepend
            // 
            this.buttonPrepend.Location = new System.Drawing.Point(192, 44);
            this.buttonPrepend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrepend.Name = "buttonPrepend";
            this.buttonPrepend.Size = new System.Drawing.Size(68, 28);
            this.buttonPrepend.TabIndex = 5;
            this.buttonPrepend.Text = "Pepend";
            this.buttonPrepend.UseVisualStyleBackColor = true;
            this.buttonPrepend.Click += new System.EventHandler(this.buttonPrepend_Click);
            // 
            // buttonAddMidlle
            // 
            this.buttonAddMidlle.Location = new System.Drawing.Point(200, 79);
            this.buttonAddMidlle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMidlle.Name = "buttonAddMidlle";
            this.buttonAddMidlle.Size = new System.Drawing.Size(68, 28);
            this.buttonAddMidlle.TabIndex = 6;
            this.buttonAddMidlle.Text = "Add";
            this.buttonAddMidlle.UseVisualStyleBackColor = true;
            this.buttonAddMidlle.Click += new System.EventHandler(this.Add);
            // 
            // buttonFindByKey
            // 
            this.buttonFindByKey.Location = new System.Drawing.Point(200, 143);
            this.buttonFindByKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindByKey.Name = "buttonFindByKey";
            this.buttonFindByKey.Size = new System.Drawing.Size(68, 28);
            this.buttonFindByKey.TabIndex = 7;
            this.buttonFindByKey.Text = "FindKey";
            this.buttonFindByKey.UseVisualStyleBackColor = true;
            this.buttonFindByKey.Click += new System.EventHandler(this.buttonFindByKey_Click);
            // 
            // buttonFindByIndex
            // 
            this.buttonFindByIndex.Location = new System.Drawing.Point(200, 175);
            this.buttonFindByIndex.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindByIndex.Name = "buttonFindByIndex";
            this.buttonFindByIndex.Size = new System.Drawing.Size(68, 28);
            this.buttonFindByIndex.TabIndex = 8;
            this.buttonFindByIndex.Text = "FindIndex";
            this.buttonFindByIndex.UseVisualStyleBackColor = true;
            this.buttonFindByIndex.Click += new System.EventHandler(this.buttonFindByIndex_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(200, 207);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(68, 28);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(310, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 262);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 297);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonFindByIndex);
            this.Controls.Add(this.buttonFindByKey);
            this.Controls.Add(this.buttonAddMidlle);
            this.Controls.Add(this.buttonPrepend);
            this.Controls.Add(this.buttonRemoveByIndex);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonRemoveByIndex;
        private System.Windows.Forms.Button buttonPrepend;
        private System.Windows.Forms.Button buttonAddMidlle;
        private System.Windows.Forms.Button buttonFindByKey;
        private System.Windows.Forms.Button buttonFindByIndex;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}