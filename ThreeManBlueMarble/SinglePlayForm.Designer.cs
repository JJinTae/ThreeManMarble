namespace ThreeManBlueMarble
{
    partial class SinglePlayForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StopBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player3 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.DIceBox = new System.Windows.Forms.PictureBox();
            this.BoardBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopBtn.Location = new System.Drawing.Point(391, 411);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(88, 32);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "주사위 멈추기";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            this.StopBtn.MouseHover += new System.EventHandler(this.StopBtn_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(921, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(161, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(921, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(161, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(921, 396);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(161, 163);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.DiceRoll);
            // 
            // Player3
            // 
            this.Player3.Image = global::ThreeManBlueMarble.Properties.Resources.Player3;
            this.Player3.Location = new System.Drawing.Point(76, 661);
            this.Player3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(31, 38);
            this.Player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3.TabIndex = 7;
            this.Player3.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = global::ThreeManBlueMarble.Properties.Resources.Player2;
            this.Player2.Location = new System.Drawing.Point(37, 661);
            this.Player2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(33, 38);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 6;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Image = global::ThreeManBlueMarble.Properties.Resources.Player1;
            this.Player1.Location = new System.Drawing.Point(1, 661);
            this.Player1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(30, 38);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 5;
            this.Player1.TabStop = false;
            // 
            // DIceBox
            // 
            this.DIceBox.Image = global::ThreeManBlueMarble.Properties.Resources.Dice1;
            this.DIceBox.Location = new System.Drawing.Point(391, 314);
            this.DIceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DIceBox.Name = "DIceBox";
            this.DIceBox.Size = new System.Drawing.Size(88, 93);
            this.DIceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DIceBox.TabIndex = 1;
            this.DIceBox.TabStop = false;
            // 
            // BoardBox
            // 
            this.BoardBox.Image = global::ThreeManBlueMarble.Properties.Resources.Board;
            this.BoardBox.Location = new System.Drawing.Point(1, -1);
            this.BoardBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoardBox.Name = "BoardBox";
            this.BoardBox.Size = new System.Drawing.Size(840, 700);
            this.BoardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoardBox.TabIndex = 0;
            this.BoardBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 732);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.DIceBox);
            this.Controls.Add(this.BoardBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardBox;
        private System.Windows.Forms.PictureBox DIceBox;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Player3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

