namespace WFAHorseRacing_2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pbGunbatimi = new System.Windows.Forms.PictureBox();
            this.pbGolge = new System.Windows.Forms.PictureBox();
            this.pbRuzgar = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGunbatimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuzgar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1320, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1320, 15);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1320, 15);
            this.label3.TabIndex = 0;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(1330, -6);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(10, 688);
            this.lblFinish.TabIndex = 1;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGunbatimi
            // 
            this.pbGunbatimi.Image = global::WFAHorseRacing_2.Properties.Resources.at3;
            this.pbGunbatimi.Location = new System.Drawing.Point(12, 411);
            this.pbGunbatimi.Name = "pbGunbatimi";
            this.pbGunbatimi.Size = new System.Drawing.Size(125, 50);
            this.pbGunbatimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGunbatimi.TabIndex = 2;
            this.pbGunbatimi.TabStop = false;
            // 
            // pbGolge
            // 
            this.pbGolge.Image = global::WFAHorseRacing_2.Properties.Resources.at2;
            this.pbGolge.Location = new System.Drawing.Point(12, 224);
            this.pbGolge.Name = "pbGolge";
            this.pbGolge.Size = new System.Drawing.Size(125, 50);
            this.pbGolge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGolge.TabIndex = 2;
            this.pbGolge.TabStop = false;
            // 
            // pbRuzgar
            // 
            this.pbRuzgar.Image = global::WFAHorseRacing_2.Properties.Resources.at1;
            this.pbRuzgar.Location = new System.Drawing.Point(12, 47);
            this.pbRuzgar.Name = "pbRuzgar";
            this.pbRuzgar.Size = new System.Drawing.Size(125, 50);
            this.pbRuzgar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRuzgar.TabIndex = 2;
            this.pbRuzgar.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1224, 635);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Baslat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1352, 683);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbGunbatimi);
            this.Controls.Add(this.pbGolge);
            this.Controls.Add(this.pbRuzgar);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbGunbatimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuzgar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.PictureBox pbRuzgar;
        private System.Windows.Forms.PictureBox pbGolge;
        private System.Windows.Forms.PictureBox pbGunbatimi;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}