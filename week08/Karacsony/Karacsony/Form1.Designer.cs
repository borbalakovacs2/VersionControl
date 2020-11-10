namespace Karacsony
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.carBtn = new System.Windows.Forms.Button();
            this.ballBtn = new System.Windows.Forms.Button();
            this.ballColor = new System.Windows.Forms.Button();
            this.presentBtn = new System.Windows.Forms.Button();
            this.presentBox = new System.Windows.Forms.Button();
            this.presentRibbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(3, 215);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coming next:";
            // 
            // carBtn
            // 
            this.carBtn.Location = new System.Drawing.Point(12, 29);
            this.carBtn.Name = "carBtn";
            this.carBtn.Size = new System.Drawing.Size(75, 23);
            this.carBtn.TabIndex = 2;
            this.carBtn.Text = "CAR";
            this.carBtn.UseVisualStyleBackColor = true;
            this.carBtn.Click += new System.EventHandler(this.carBtn_Click);
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(113, 29);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(75, 23);
            this.ballBtn.TabIndex = 3;
            this.ballBtn.Text = "BALL";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Click += new System.EventHandler(this.ballBtn_Click);
            // 
            // ballColor
            // 
            this.ballColor.BackColor = System.Drawing.Color.Blue;
            this.ballColor.ForeColor = System.Drawing.Color.Cornsilk;
            this.ballColor.Location = new System.Drawing.Point(113, 69);
            this.ballColor.Name = "ballColor";
            this.ballColor.Size = new System.Drawing.Size(75, 48);
            this.ballColor.TabIndex = 4;
            this.ballColor.UseVisualStyleBackColor = false;
            this.ballColor.Click += new System.EventHandler(this.ballColor_Click);
            // 
            // presentBtn
            // 
            this.presentBtn.Location = new System.Drawing.Point(224, 29);
            this.presentBtn.Name = "presentBtn";
            this.presentBtn.Size = new System.Drawing.Size(111, 23);
            this.presentBtn.TabIndex = 5;
            this.presentBtn.Text = "PRESENT";
            this.presentBtn.UseVisualStyleBackColor = true;
            this.presentBtn.Click += new System.EventHandler(this.presentBtn_Click);
            // 
            // presentBox
            // 
            this.presentBox.BackColor = System.Drawing.Color.Blue;
            this.presentBox.ForeColor = System.Drawing.Color.Cornsilk;
            this.presentBox.Location = new System.Drawing.Point(224, 69);
            this.presentBox.Name = "presentBox";
            this.presentBox.Size = new System.Drawing.Size(111, 48);
            this.presentBox.TabIndex = 6;
            this.presentBox.UseVisualStyleBackColor = false;
            this.presentBox.Click += new System.EventHandler(this.ballColor_Click);
            // 
            // presentRibbon
            // 
            this.presentRibbon.BackColor = System.Drawing.Color.Yellow;
            this.presentRibbon.ForeColor = System.Drawing.Color.Cornsilk;
            this.presentRibbon.Location = new System.Drawing.Point(224, 123);
            this.presentRibbon.Name = "presentRibbon";
            this.presentRibbon.Size = new System.Drawing.Size(111, 29);
            this.presentRibbon.TabIndex = 7;
            this.presentRibbon.UseVisualStyleBackColor = false;
            this.presentRibbon.Click += new System.EventHandler(this.ballColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.presentRibbon);
            this.Controls.Add(this.presentBox);
            this.Controls.Add(this.presentBtn);
            this.Controls.Add(this.ballColor);
            this.Controls.Add(this.ballBtn);
            this.Controls.Add(this.carBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button carBtn;
        private System.Windows.Forms.Button ballBtn;
        private System.Windows.Forms.Button ballColor;
        private System.Windows.Forms.Button presentBtn;
        private System.Windows.Forms.Button presentBox;
        private System.Windows.Forms.Button presentRibbon;
    }
}

