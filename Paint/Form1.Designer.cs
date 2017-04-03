namespace Paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Color_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pen_num = new System.Windows.Forms.NumericUpDown();
            this.Instrument_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pen_num)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 305);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(12, 12);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(63, 56);
            this.Clear_btn.TabIndex = 1;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Color_btn
            // 
            this.Color_btn.BackColor = System.Drawing.Color.Red;
            this.Color_btn.Location = new System.Drawing.Point(709, 12);
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(63, 56);
            this.Color_btn.TabIndex = 2;
            this.Color_btn.UseVisualStyleBackColor = false;
            this.Color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pen Width";
            // 
            // Pen_num
            // 
            this.Pen_num.Location = new System.Drawing.Point(144, 43);
            this.Pen_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pen_num.Name = "Pen_num";
            this.Pen_num.Size = new System.Drawing.Size(54, 20);
            this.Pen_num.TabIndex = 6;
            this.Pen_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pen_num.ValueChanged += new System.EventHandler(this.Pen_num_ValueChanged);
            // 
            // Instrument_box
            // 
            this.Instrument_box.FormattingEnabled = true;
            this.Instrument_box.Items.AddRange(new object[] {
            "Pen",
            "Line"});
            this.Instrument_box.Location = new System.Drawing.Point(144, 16);
            this.Instrument_box.Name = "Instrument_box";
            this.Instrument_box.Size = new System.Drawing.Size(121, 21);
            this.Instrument_box.TabIndex = 7;
            this.Instrument_box.Text = "Pen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instrument";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Instrument_box);
            this.Controls.Add(this.Pen_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Color_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pen_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Color_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Pen_num;
        private System.Windows.Forms.ComboBox Instrument_box;
        private System.Windows.Forms.Label label2;
    }
}

