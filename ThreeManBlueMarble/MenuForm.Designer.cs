namespace ThreeManBlueMarble
{
    partial class MenuForm
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
            this.btnSinglePlay = new System.Windows.Forms.Button();
            this.btnMultiPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinglePlay
            // 
            this.btnSinglePlay.Location = new System.Drawing.Point(333, 118);
            this.btnSinglePlay.Name = "btnSinglePlay";
            this.btnSinglePlay.Size = new System.Drawing.Size(102, 60);
            this.btnSinglePlay.TabIndex = 0;
            this.btnSinglePlay.Text = "싱글플레이";
            this.btnSinglePlay.UseVisualStyleBackColor = true;
            this.btnSinglePlay.Click += new System.EventHandler(this.btnSinglePlay_Click);
            // 
            // btnMultiPlay
            // 
            this.btnMultiPlay.Location = new System.Drawing.Point(333, 184);
            this.btnMultiPlay.Name = "btnMultiPlay";
            this.btnMultiPlay.Size = new System.Drawing.Size(102, 60);
            this.btnMultiPlay.TabIndex = 1;
            this.btnMultiPlay.Text = "멀티플레이";
            this.btnMultiPlay.UseVisualStyleBackColor = true;
            this.btnMultiPlay.Click += new System.EventHandler(this.btnMultiPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "종료하기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMultiPlay);
            this.Controls.Add(this.btnSinglePlay);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlay;
        private System.Windows.Forms.Button btnMultiPlay;
        private System.Windows.Forms.Button btnExit;
    }
}

