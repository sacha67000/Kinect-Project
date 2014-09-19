namespace Test
{
    partial class SmartTalk
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
            this.StartButton = new System.Windows.Forms.Button();
            this.OptionButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StartRecordingButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.GhostWhite;
            this.StartButton.Location = new System.Drawing.Point(425, 450);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 100);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionButton.BackColor = System.Drawing.Color.GhostWhite;
            this.OptionButton.Location = new System.Drawing.Point(880, 900);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(70, 30);
            this.OptionButton.TabIndex = 1;
            this.OptionButton.Text = "Options";
            this.OptionButton.UseVisualStyleBackColor = false;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.AliceBlue;
            this.Title.Location = new System.Drawing.Point(400, 100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 100);
            this.Title.TabIndex = 2;
            this.Title.Text = "SmartTalk";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.Location = new System.Drawing.Point(2, 890);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 64);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Fermer";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartRecordingButton
            // 
            this.StartRecordingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRecordingButton.Location = new System.Drawing.Point(350, 780);
            this.StartRecordingButton.Name = "StartRecordingButton";
            this.StartRecordingButton.Size = new System.Drawing.Size(300, 70);
            this.StartRecordingButton.TabIndex = 4;
            this.StartRecordingButton.Text = "Start Recording";
            this.StartRecordingButton.UseVisualStyleBackColor = true;
            this.StartRecordingButton.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 893);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 60);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(20, 169);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(80, 21);
            this.Option1.TabIndex = 6;
            this.Option1.Text = "Option1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Visible = false;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(20, 196);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(80, 21);
            this.Option2.TabIndex = 7;
            this.Option2.Text = "Option2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Visible = false;
            // 
            // SmartTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(982, 955);
            this.ControlBox = false;
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StartRecordingButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.StartButton);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "SmartTalk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTalk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StartRecordingButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.CheckBox Option2;
    }
}

