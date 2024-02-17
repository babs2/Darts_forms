namespace Darts_forms
{
    partial class gameOf01
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
            splitContainer1 = new SplitContainer();
            playAgainbtn = new Button();
            outsP1lbl = new Label();
            roundScoreP1 = new Label();
            p1Throwlbl = new Label();
            p1throwbox = new TextBox();
            addthrowp1btn = new Button();
            p1501lbl = new Label();
            player1lbl = new Label();
            outsP2lbl = new Label();
            roundScoreP2 = new Label();
            label2 = new Label();
            p2throwbox = new TextBox();
            addthrowp2btn = new Button();
            p2501lbl = new Label();
            player2lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Snow;
            splitContainer1.Panel1.Controls.Add(playAgainbtn);
            splitContainer1.Panel1.Controls.Add(outsP1lbl);
            splitContainer1.Panel1.Controls.Add(roundScoreP1);
            splitContainer1.Panel1.Controls.Add(p1Throwlbl);
            splitContainer1.Panel1.Controls.Add(p1throwbox);
            splitContainer1.Panel1.Controls.Add(addthrowp1btn);
            splitContainer1.Panel1.Controls.Add(p1501lbl);
            splitContainer1.Panel1.Controls.Add(player1lbl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.MenuHighlight;
            splitContainer1.Panel2.Controls.Add(outsP2lbl);
            splitContainer1.Panel2.Controls.Add(roundScoreP2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(p2throwbox);
            splitContainer1.Panel2.Controls.Add(addthrowp2btn);
            splitContainer1.Panel2.Controls.Add(p2501lbl);
            splitContainer1.Panel2.Controls.Add(player2lbl);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(800, 604);
            splitContainer1.SplitterDistance = 402;
            splitContainer1.TabIndex = 0;
            // 
            // playAgainbtn
            // 
            playAgainbtn.Location = new Point(135, 332);
            playAgainbtn.Name = "playAgainbtn";
            playAgainbtn.Size = new Size(264, 88);
            playAgainbtn.TabIndex = 7;
            playAgainbtn.Text = "Play Again";
            playAgainbtn.UseVisualStyleBackColor = true;
            playAgainbtn.Visible = false;
            playAgainbtn.Click += playAgainbtn_Click;
            // 
            // outsP1lbl
            // 
            outsP1lbl.AutoSize = true;
            outsP1lbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            outsP1lbl.Location = new Point(40, 131);
            outsP1lbl.Name = "outsP1lbl";
            outsP1lbl.Size = new Size(0, 30);
            outsP1lbl.TabIndex = 6;
            // 
            // roundScoreP1
            // 
            roundScoreP1.AutoSize = true;
            roundScoreP1.Location = new Point(40, 405);
            roundScoreP1.Name = "roundScoreP1";
            roundScoreP1.Size = new Size(0, 15);
            roundScoreP1.TabIndex = 5;
            // 
            // p1Throwlbl
            // 
            p1Throwlbl.AutoSize = true;
            p1Throwlbl.Location = new Point(276, 507);
            p1Throwlbl.Name = "p1Throwlbl";
            p1Throwlbl.Size = new Size(75, 15);
            p1Throwlbl.TabIndex = 4;
            p1Throwlbl.Text = "Throw Score:";
            // 
            // p1throwbox
            // 
            p1throwbox.Location = new Point(252, 531);
            p1throwbox.Name = "p1throwbox";
            p1throwbox.PlaceholderText = "0";
            p1throwbox.Size = new Size(100, 23);
            p1throwbox.TabIndex = 3;
            p1throwbox.KeyPress += p1throwbox_KeyPress;
            // 
            // addthrowp1btn
            // 
            addthrowp1btn.Location = new Point(40, 508);
            addthrowp1btn.Name = "addthrowp1btn";
            addthrowp1btn.Size = new Size(206, 67);
            addthrowp1btn.TabIndex = 2;
            addthrowp1btn.Text = "Add  Throw for P1";
            addthrowp1btn.UseVisualStyleBackColor = true;
            addthrowp1btn.Click += addthrowp1btn_Click;
            addthrowp1btn.KeyDown += addthrowp1btn_KeyDown;
            // 
            // p1501lbl
            // 
            p1501lbl.AutoSize = true;
            p1501lbl.Location = new Point(100, 41);
            p1501lbl.Name = "p1501lbl";
            p1501lbl.Size = new Size(25, 15);
            p1501lbl.TabIndex = 1;
            p1501lbl.Text = "501";
            // 
            // player1lbl
            // 
            player1lbl.AutoSize = true;
            player1lbl.Location = new Point(93, 18);
            player1lbl.Name = "player1lbl";
            player1lbl.Size = new Size(48, 15);
            player1lbl.TabIndex = 0;
            player1lbl.Text = "Player 1";
            // 
            // outsP2lbl
            // 
            outsP2lbl.AutoSize = true;
            outsP2lbl.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            outsP2lbl.Location = new Point(25, 131);
            outsP2lbl.Name = "outsP2lbl";
            outsP2lbl.Size = new Size(0, 30);
            outsP2lbl.TabIndex = 8;
            // 
            // roundScoreP2
            // 
            roundScoreP2.AutoSize = true;
            roundScoreP2.Location = new Point(36, 405);
            roundScoreP2.Name = "roundScoreP2";
            roundScoreP2.Size = new Size(0, 15);
            roundScoreP2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 507);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 6;
            label2.Text = "Throw Score:";
            // 
            // p2throwbox
            // 
            p2throwbox.Location = new Point(248, 531);
            p2throwbox.Name = "p2throwbox";
            p2throwbox.PlaceholderText = "0";
            p2throwbox.Size = new Size(100, 23);
            p2throwbox.TabIndex = 5;
            p2throwbox.KeyDown += p2throwbox_KeyDown;
            p2throwbox.KeyPress += p2throwbox_KeyPress;
            // 
            // addthrowp2btn
            // 
            addthrowp2btn.Location = new Point(36, 507);
            addthrowp2btn.Name = "addthrowp2btn";
            addthrowp2btn.Size = new Size(206, 67);
            addthrowp2btn.TabIndex = 3;
            addthrowp2btn.Text = "Add  Throw for P2";
            addthrowp2btn.UseVisualStyleBackColor = true;
            addthrowp2btn.Click += addthrowp2btn_Click;
            // 
            // p2501lbl
            // 
            p2501lbl.AutoSize = true;
            p2501lbl.Location = new Point(129, 41);
            p2501lbl.Name = "p2501lbl";
            p2501lbl.Size = new Size(25, 15);
            p2501lbl.TabIndex = 2;
            p2501lbl.Text = "501";
            // 
            // player2lbl
            // 
            player2lbl.AutoSize = true;
            player2lbl.Location = new Point(117, 18);
            player2lbl.Name = "player2lbl";
            player2lbl.Size = new Size(48, 15);
            player2lbl.TabIndex = 0;
            player2lbl.Text = "Player 2";
            // 
            // gameOf01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(splitContainer1);
            Name = "gameOf01";
            Text = "501 Game";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label p1501lbl;
        private Label player1lbl;
        private Label p2501lbl;
        private Label player2lbl;
        private Label p1Throwlbl;
        private TextBox p1throwbox;
        private Button addthrowp1btn;
        private Label label2;
        private TextBox p2throwbox;
        private Button addthrowp2btn;
        private Label roundScoreP1;
        private Label roundScoreP2;
        private Label outsP1lbl;
        private Label outsP2lbl;
        private Button playAgainbtn;
    }
}