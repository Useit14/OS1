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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idProcess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 407);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(200, 292);
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
            this.buttonRemoveByIndex.Location = new System.Drawing.Point(185, 62);
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
            this.buttonPrepend.Location = new System.Drawing.Point(200, 334);
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
            this.buttonAddMidlle.Location = new System.Drawing.Point(185, 30);
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
            this.buttonFindByKey.Location = new System.Drawing.Point(185, 94);
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
            this.buttonFindByIndex.Location = new System.Drawing.Point(185, 126);
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
            this.buttonSort.Location = new System.Drawing.Point(185, 158);
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
            this.chart1.Location = new System.Drawing.Point(508, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(332, 398);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 94);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 126);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.idProcess);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.buttonFindByIndex);
            this.panel1.Controls.Add(this.buttonFindByKey);
            this.panel1.Controls.Add(this.buttonAddMidlle);
            this.panel1.Controls.Add(this.buttonRemoveByIndex);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 215);
            this.panel1.TabIndex = 14;
            // 
            // idProcess
            // 
            this.idProcess.AutoSize = true;
            this.idProcess.Location = new System.Drawing.Point(16, 38);
            this.idProcess.Name = "idProcess";
            this.idProcess.Size = new System.Drawing.Size(35, 13);
            this.idProcess.TabIndex = 14;
            this.idProcess.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPrepend);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idProcess;
    }
}