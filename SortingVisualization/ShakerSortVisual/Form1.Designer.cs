namespace ShakerSortVisual
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormArrayBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SortBTN = new System.Windows.Forms.Button();
            this.doubleSelectionRB = new System.Windows.Forms.RadioButton();
            this.insertionRB = new System.Windows.Forms.RadioButton();
            this.mergeRB = new System.Windows.Forms.RadioButton();
            this.bubbleSortRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormArrayBTN
            // 
            this.FormArrayBTN.Location = new System.Drawing.Point(1089, 33);
            this.FormArrayBTN.Name = "FormArrayBTN";
            this.FormArrayBTN.Size = new System.Drawing.Size(103, 35);
            this.FormArrayBTN.TabIndex = 1;
            this.FormArrayBTN.Text = "Form new array";
            this.FormArrayBTN.UseVisualStyleBackColor = true;
            this.FormArrayBTN.Click += new System.EventHandler(this.FormArrayBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SortBTN
            // 
            this.SortBTN.Location = new System.Drawing.Point(1089, 74);
            this.SortBTN.Name = "SortBTN";
            this.SortBTN.Size = new System.Drawing.Size(103, 39);
            this.SortBTN.TabIndex = 2;
            this.SortBTN.Text = "Start sorting";
            this.SortBTN.UseVisualStyleBackColor = true;
            this.SortBTN.Click += new System.EventHandler(this.SortBTN_Click);
            // 
            // doubleSelectionRB
            // 
            this.doubleSelectionRB.AutoSize = true;
            this.doubleSelectionRB.Checked = true;
            this.doubleSelectionRB.Location = new System.Drawing.Point(1062, 140);
            this.doubleSelectionRB.Name = "doubleSelectionRB";
            this.doubleSelectionRB.Size = new System.Drawing.Size(128, 17);
            this.doubleSelectionRB.TabIndex = 3;
            this.doubleSelectionRB.TabStop = true;
            this.doubleSelectionRB.Text = "Double Selection Sort";
            this.doubleSelectionRB.UseVisualStyleBackColor = true;
            // 
            // insertionRB
            // 
            this.insertionRB.AutoSize = true;
            this.insertionRB.Location = new System.Drawing.Point(1062, 177);
            this.insertionRB.Name = "insertionRB";
            this.insertionRB.Size = new System.Drawing.Size(87, 17);
            this.insertionRB.TabIndex = 3;
            this.insertionRB.TabStop = true;
            this.insertionRB.Text = "Insertion Sort";
            this.insertionRB.UseVisualStyleBackColor = true;
            // 
            // mergeRB
            // 
            this.mergeRB.AutoSize = true;
            this.mergeRB.Location = new System.Drawing.Point(1062, 216);
            this.mergeRB.Name = "mergeRB";
            this.mergeRB.Size = new System.Drawing.Size(77, 17);
            this.mergeRB.TabIndex = 3;
            this.mergeRB.TabStop = true;
            this.mergeRB.Text = "Merge Sort";
            this.mergeRB.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRB
            // 
            this.bubbleSortRB.AutoSize = true;
            this.bubbleSortRB.Location = new System.Drawing.Point(1062, 259);
            this.bubbleSortRB.Name = "bubbleSortRB";
            this.bubbleSortRB.Size = new System.Drawing.Size(80, 17);
            this.bubbleSortRB.TabIndex = 3;
            this.bubbleSortRB.TabStop = true;
            this.bubbleSortRB.Text = "Bubble Sort";
            this.bubbleSortRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 542);
            this.Controls.Add(this.bubbleSortRB);
            this.Controls.Add(this.mergeRB);
            this.Controls.Add(this.insertionRB);
            this.Controls.Add(this.doubleSelectionRB);
            this.Controls.Add(this.SortBTN);
            this.Controls.Add(this.FormArrayBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FormArrayBTN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SortBTN;
        private System.Windows.Forms.RadioButton doubleSelectionRB;
        private System.Windows.Forms.RadioButton insertionRB;
        private System.Windows.Forms.RadioButton mergeRB;
        private System.Windows.Forms.RadioButton bubbleSortRB;
    }
}

