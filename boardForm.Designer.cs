namespace Darts_forms
{
    partial class boardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boardForm));
            pictureBox1 = new PictureBox();
            trip20btn = new Button();
            upperSingle20btn = new Button();
            double20btn = new Button();
            double1btn = new Button();
            up_single_1btn = new Button();
            triple1btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 83);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1281, 1269);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // trip20btn
            // 
            trip20btn.BackColor = Color.Transparent;
            trip20btn.BackgroundImage = (Image)resources.GetObject("trip20btn.BackgroundImage");
            trip20btn.FlatAppearance.BorderColor = Color.Red;
            trip20btn.FlatAppearance.BorderSize = 0;
            trip20btn.FlatStyle = FlatStyle.Flat;
            trip20btn.Image = Properties.Resources.red_triple;
            trip20btn.Location = new Point(708, 426);
            trip20btn.Margin = new Padding(0);
            trip20btn.Name = "trip20btn";
            trip20btn.Size = new Size(75, 23);
            trip20btn.TabIndex = 1;
            trip20btn.UseVisualStyleBackColor = false;
            trip20btn.Click += trip20btn_Click;
            // 
            // upperSingle20btn
            // 
            upperSingle20btn.FlatAppearance.BorderSize = 0;
            upperSingle20btn.FlatStyle = FlatStyle.Flat;
            upperSingle20btn.Image = Properties.Resources.black_outer_single;
            upperSingle20btn.Location = new Point(695, 276);
            upperSingle20btn.Name = "upperSingle20btn";
            upperSingle20btn.Size = new Size(88, 120);
            upperSingle20btn.TabIndex = 2;
            upperSingle20btn.UseVisualStyleBackColor = true;
            upperSingle20btn.Click += button2_Click;
            // 
            // double20btn
            // 
            double20btn.BackColor = Color.Transparent;
            double20btn.BackgroundImage = Properties.Resources.double20;
            double20btn.FlatAppearance.BorderColor = Color.Red;
            double20btn.FlatAppearance.BorderSize = 0;
            double20btn.FlatStyle = FlatStyle.Flat;
            double20btn.Image = (Image)resources.GetObject("double20btn.Image");
            double20btn.Location = new Point(695, 241);
            double20btn.Margin = new Padding(0);
            double20btn.Name = "double20btn";
            double20btn.Size = new Size(105, 23);
            double20btn.TabIndex = 4;
            double20btn.UseVisualStyleBackColor = false;
            double20btn.Click += double20btn_Click;
            // 
            // double1btn
            // 
            double1btn.BackColor = Color.Transparent;
            double1btn.BackgroundImage = (Image)resources.GetObject("double1btn.BackgroundImage");
            double1btn.FlatAppearance.BorderColor = Color.Red;
            double1btn.FlatAppearance.BorderSize = 0;
            double1btn.FlatStyle = FlatStyle.Flat;
            double1btn.Image = Properties.Resources.double1;
            double1btn.Location = new Point(819, 255);
            double1btn.Margin = new Padding(0);
            double1btn.Name = "double1btn";
            double1btn.Size = new Size(130, 29);
            double1btn.TabIndex = 5;
            double1btn.UseVisualStyleBackColor = false;
            double1btn.Click += double1btn_Click;
            // 
            // up_single_1btn
            // 
            up_single_1btn.FlatAppearance.BorderSize = 0;
            up_single_1btn.FlatStyle = FlatStyle.Flat;
            up_single_1btn.Image = Properties.Resources.upper_single_1;
            up_single_1btn.Location = new Point(819, 314);
            up_single_1btn.Name = "up_single_1btn";
            up_single_1btn.Size = new Size(79, 111);
            up_single_1btn.TabIndex = 6;
            up_single_1btn.UseVisualStyleBackColor = true;
            up_single_1btn.Click += up_single_1btn_Click;
            // 
            // triple1btn
            // 
            triple1btn.BackColor = Color.Transparent;
            triple1btn.BackgroundImage = (Image)resources.GetObject("triple1btn.BackgroundImage");
            triple1btn.FlatAppearance.BorderColor = Color.Red;
            triple1btn.FlatAppearance.BorderSize = 0;
            triple1btn.FlatStyle = FlatStyle.Flat;
            triple1btn.Image = Properties.Resources.triple_1;
            triple1btn.Location = new Point(802, 438);
            triple1btn.Margin = new Padding(0);
            triple1btn.Name = "triple1btn";
            triple1btn.Size = new Size(75, 23);
            triple1btn.TabIndex = 7;
            triple1btn.UseVisualStyleBackColor = false;
            // 
            // boardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 1429);
            Controls.Add(triple1btn);
            Controls.Add(up_single_1btn);
            Controls.Add(double1btn);
            Controls.Add(double20btn);
            Controls.Add(upperSingle20btn);
            Controls.Add(trip20btn);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "boardForm";
            Text = "boardForm";
            Load += boardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button trip20btn;
        private Button upperSingle20btn;
        private Button double20btn;
        private Button double1btn;
        private Button up_single_1btn;
        private Button triple1btn;
    }
}