namespace Darts_forms
{
    partial class Game_select
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            game_selectGrpBox = new GroupBox();
            OpenOutChkBox = new CheckBox();
            OpenInChkBox = new CheckBox();
            CricketLowBallBox = new CheckBox();
            cricketPointsCap = new CheckBox();
            splitBullChkBoc = new CheckBox();
            MasterOutChkBox = new CheckBox();
            MasterInChkBox = new CheckBox();
            doubleOutChkBox = new CheckBox();
            DoubleInChkBox = new CheckBox();
            checkBox_cricket = new CheckBox();
            checkBox01 = new CheckBox();
            Training = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            softTipOuts = new CheckBox();
            OutsTrainer = new CheckBox();
            beginButton = new Button();
            gameOf01Startbox = new TextBox();
            gmae01startlbl = new Label();
            game_selectGrpBox.SuspendLayout();
            Training.SuspendLayout();
            SuspendLayout();
            // 
            // game_selectGrpBox
            // 
            game_selectGrpBox.Controls.Add(gmae01startlbl);
            game_selectGrpBox.Controls.Add(gameOf01Startbox);
            game_selectGrpBox.Controls.Add(OpenOutChkBox);
            game_selectGrpBox.Controls.Add(OpenInChkBox);
            game_selectGrpBox.Controls.Add(CricketLowBallBox);
            game_selectGrpBox.Controls.Add(cricketPointsCap);
            game_selectGrpBox.Controls.Add(splitBullChkBoc);
            game_selectGrpBox.Controls.Add(MasterOutChkBox);
            game_selectGrpBox.Controls.Add(MasterInChkBox);
            game_selectGrpBox.Controls.Add(doubleOutChkBox);
            game_selectGrpBox.Controls.Add(DoubleInChkBox);
            game_selectGrpBox.Controls.Add(checkBox_cricket);
            game_selectGrpBox.Controls.Add(checkBox01);
            game_selectGrpBox.ForeColor = Color.Yellow;
            game_selectGrpBox.Location = new Point(12, 12);
            game_selectGrpBox.Name = "game_selectGrpBox";
            game_selectGrpBox.Size = new Size(387, 245);
            game_selectGrpBox.TabIndex = 0;
            game_selectGrpBox.TabStop = false;
            game_selectGrpBox.Text = "Select Game Options";
            game_selectGrpBox.Enter += game_selectGrpBox_Enter;
            // 
            // OpenOutChkBox
            // 
            OpenOutChkBox.AutoSize = true;
            OpenOutChkBox.Location = new Point(16, 174);
            OpenOutChkBox.Name = "OpenOutChkBox";
            OpenOutChkBox.Size = new Size(78, 19);
            OpenOutChkBox.TabIndex = 14;
            OpenOutChkBox.Text = "Open Out";
            OpenOutChkBox.UseVisualStyleBackColor = true;
            OpenOutChkBox.CheckedChanged += OpenOutChkBox_CheckedChanged;
            // 
            // OpenInChkBox
            // 
            OpenInChkBox.AutoSize = true;
            OpenInChkBox.Location = new Point(16, 149);
            OpenInChkBox.Name = "OpenInChkBox";
            OpenInChkBox.Size = new Size(68, 19);
            OpenInChkBox.TabIndex = 13;
            OpenInChkBox.Text = "Open In";
            OpenInChkBox.UseVisualStyleBackColor = true;
            OpenInChkBox.CheckedChanged += OpenInChkBox_CheckedChanged;
            // 
            // CricketLowBallBox
            // 
            CricketLowBallBox.AutoSize = true;
            CricketLowBallBox.Location = new Point(174, 72);
            CricketLowBallBox.Name = "CricketLowBallBox";
            CricketLowBallBox.Size = new Size(110, 19);
            CricketLowBallBox.TabIndex = 12;
            CricketLowBallBox.Text = "Low Ball Cricket";
            CricketLowBallBox.UseVisualStyleBackColor = true;
            CricketLowBallBox.CheckedChanged += CricketLowBallBox_CheckedChanged;
            // 
            // cricketPointsCap
            // 
            cricketPointsCap.AutoSize = true;
            cricketPointsCap.Location = new Point(174, 47);
            cricketPointsCap.Name = "cricketPointsCap";
            cricketPointsCap.Size = new Size(135, 19);
            cricketPointsCap.TabIndex = 11;
            cricketPointsCap.Text = "Points Cap (200 / 20)";
            cricketPointsCap.UseVisualStyleBackColor = true;
            cricketPointsCap.CheckedChanged += cricketPointsCap_CheckedChanged;
            // 
            // splitBullChkBoc
            // 
            splitBullChkBoc.AutoSize = true;
            splitBullChkBoc.Location = new Point(15, 220);
            splitBullChkBoc.Name = "splitBullChkBoc";
            splitBullChkBoc.Size = new Size(112, 19);
            splitBullChkBoc.TabIndex = 9;
            splitBullChkBoc.Text = "Split Bull (25/50)";
            splitBullChkBoc.UseVisualStyleBackColor = true;
            splitBullChkBoc.CheckedChanged += splitBullChkBoc_CheckedChanged;
            // 
            // MasterOutChkBox
            // 
            MasterOutChkBox.AutoSize = true;
            MasterOutChkBox.Location = new Point(16, 124);
            MasterOutChkBox.Name = "MasterOutChkBox";
            MasterOutChkBox.Size = new Size(85, 19);
            MasterOutChkBox.TabIndex = 8;
            MasterOutChkBox.Text = "Master Out";
            MasterOutChkBox.UseVisualStyleBackColor = true;
            MasterOutChkBox.CheckedChanged += MasterOutChkBox_CheckedChanged;
            // 
            // MasterInChkBox
            // 
            MasterInChkBox.AutoSize = true;
            MasterInChkBox.Location = new Point(16, 99);
            MasterInChkBox.Name = "MasterInChkBox";
            MasterInChkBox.Size = new Size(75, 19);
            MasterInChkBox.TabIndex = 7;
            MasterInChkBox.Text = "Master In";
            MasterInChkBox.UseVisualStyleBackColor = true;
            MasterInChkBox.CheckedChanged += MasterInChkBox_CheckedChanged;
            // 
            // doubleOutChkBox
            // 
            doubleOutChkBox.AutoSize = true;
            doubleOutChkBox.Location = new Point(16, 72);
            doubleOutChkBox.Name = "doubleOutChkBox";
            doubleOutChkBox.Size = new Size(87, 19);
            doubleOutChkBox.TabIndex = 6;
            doubleOutChkBox.Text = "Double Out";
            doubleOutChkBox.UseVisualStyleBackColor = true;
            doubleOutChkBox.CheckedChanged += doubleOutChkBox_CheckedChanged;
            // 
            // DoubleInChkBox
            // 
            DoubleInChkBox.AutoSize = true;
            DoubleInChkBox.Location = new Point(16, 47);
            DoubleInChkBox.Name = "DoubleInChkBox";
            DoubleInChkBox.Size = new Size(77, 19);
            DoubleInChkBox.TabIndex = 2;
            DoubleInChkBox.Text = "Double In";
            DoubleInChkBox.UseVisualStyleBackColor = true;
            DoubleInChkBox.CheckedChanged += DoubleInChkBox_CheckedChanged;
            // 
            // checkBox_cricket
            // 
            checkBox_cricket.AutoSize = true;
            checkBox_cricket.ForeColor = Color.Yellow;
            checkBox_cricket.Location = new Point(174, 22);
            checkBox_cricket.Name = "checkBox_cricket";
            checkBox_cricket.Size = new Size(63, 19);
            checkBox_cricket.TabIndex = 1;
            checkBox_cricket.Text = "Cricket";
            checkBox_cricket.UseVisualStyleBackColor = true;
            checkBox_cricket.CheckedChanged += checkBox_cricket_CheckedChanged;
            // 
            // checkBox01
            // 
            checkBox01.AutoSize = true;
            checkBox01.Location = new Point(16, 22);
            checkBox01.Name = "checkBox01";
            checkBox01.Size = new Size(72, 19);
            checkBox01.TabIndex = 0;
            checkBox01.Text = "01 Game";
            checkBox01.UseVisualStyleBackColor = true;
            checkBox01.CheckedChanged += checkBox01_CheckedChanged;
            // 
            // Training
            // 
            Training.Controls.Add(label2);
            Training.Controls.Add(label1);
            Training.Controls.Add(softTipOuts);
            Training.Controls.Add(OutsTrainer);
            Training.ForeColor = Color.Yellow;
            Training.Location = new Point(12, 263);
            Training.Name = "Training";
            Training.Size = new Size(387, 186);
            Training.TabIndex = 1;
            Training.TabStop = false;
            Training.Text = "Training Options";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // softTipOuts
            // 
            softTipOuts.AutoSize = true;
            softTipOuts.Location = new Point(10, 52);
            softTipOuts.Name = "softTipOuts";
            softTipOuts.Size = new Size(134, 19);
            softTipOuts.TabIndex = 1;
            softTipOuts.Text = "Soft tip outs training";
            softTipOuts.UseVisualStyleBackColor = true;
            softTipOuts.CheckedChanged += softTipOuts_CheckedChanged;
            // 
            // OutsTrainer
            // 
            OutsTrainer.AutoSize = true;
            OutsTrainer.Location = new Point(11, 28);
            OutsTrainer.Name = "OutsTrainer";
            OutsTrainer.Size = new Size(111, 19);
            OutsTrainer.TabIndex = 0;
            OutsTrainer.Text = "01 Outs Training";
            OutsTrainer.UseVisualStyleBackColor = true;
            OutsTrainer.CheckedChanged += OutsTrainer_CheckedChanged;
            // 
            // beginButton
            // 
            beginButton.BackColor = Color.Black;
            beginButton.ForeColor = Color.Tomato;
            beginButton.Location = new Point(112, 455);
            beginButton.Name = "beginButton";
            beginButton.Size = new Size(184, 54);
            beginButton.TabIndex = 2;
            beginButton.Text = "Begin";
            beginButton.UseVisualStyleBackColor = false;
            beginButton.Click += beginButton_Click;
            // 
            // gameOf01Startbox
            // 
            gameOf01Startbox.Location = new Point(16, 196);
            gameOf01Startbox.Name = "gameOf01Startbox";
            gameOf01Startbox.Size = new Size(128, 23);
            gameOf01Startbox.TabIndex = 15;
            // 
            // gmae01startlbl
            // 
            gmae01startlbl.AutoSize = true;
            gmae01startlbl.Location = new Point(165, 202);
            gmae01startlbl.Name = "gmae01startlbl";
            gmae01startlbl.Size = new Size(129, 15);
            gmae01startlbl.TabIndex = 16;
            gmae01startlbl.Text = "01 Game Starting Score";
            // 
            // Game_select
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(422, 521);
            Controls.Add(beginButton);
            Controls.Add(Training);
            Controls.Add(game_selectGrpBox);
            Name = "Game_select";
            Text = "Darts Game Select";
            game_selectGrpBox.ResumeLayout(false);
            game_selectGrpBox.PerformLayout();
            Training.ResumeLayout(false);
            Training.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox game_selectGrpBox;
        private CheckBox checkBox_cricket;
        private CheckBox checkBox01;
        private CheckBox MasterOutChkBox;
        private CheckBox MasterInChkBox;
        private CheckBox doubleOutChkBox;
        private CheckBox DoubleInChkBox;
        private CheckBox splitBullChkBoc;
        private CheckBox CricketLowBallBox;
        private CheckBox cricketPointsCap;
        private GroupBox Training;
        private CheckBox softTipOuts;
        private CheckBox OutsTrainer;
        private CheckBox OpenOutChkBox;
        private CheckBox OpenInChkBox;
        private Button beginButton;
        public Label label1;
        public Label label2;
        private Label gmae01startlbl;
        private TextBox gameOf01Startbox;
    }
}