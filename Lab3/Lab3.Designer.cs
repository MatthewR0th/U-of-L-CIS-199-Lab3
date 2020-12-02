namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radiusOfSphereTextbox = new System.Windows.Forms.TextBox();
            this.calculationButton = new System.Windows.Forms.Button();
            this.radiusOfSphere = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.diameterOutput = new System.Windows.Forms.Label();
            this.volumeOutput = new System.Windows.Forms.Label();
            this.surfaceAreaOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // radiusOfSphereTextbox
            // 
            this.radiusOfSphereTextbox.Location = new System.Drawing.Point(262, 72);
            this.radiusOfSphereTextbox.Name = "radiusOfSphereTextbox";
            this.radiusOfSphereTextbox.Size = new System.Drawing.Size(100, 20);
            this.radiusOfSphereTextbox.TabIndex = 2;
            this.radiusOfSphereTextbox.TextChanged += new System.EventHandler(this.radiusOfSphereTextbox_TextChanged);
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(262, 128);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(75, 23);
            this.calculationButton.TabIndex = 6;
            this.calculationButton.Text = "Calculate";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // radiusOfSphere
            // 
            this.radiusOfSphere.AutoSize = true;
            this.radiusOfSphere.Location = new System.Drawing.Point(166, 75);
            this.radiusOfSphere.Name = "radiusOfSphere";
            this.radiusOfSphere.Size = new System.Drawing.Size(90, 13);
            this.radiusOfSphere.TabIndex = 7;
            this.radiusOfSphere.Text = "Radius of sphere:";
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(25, 291);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 8;
            this.volumeLabel.Text = "Volume";
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.AutoSize = true;
            this.surfaceAreaLabel.Location = new System.Drawing.Point(25, 245);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(69, 13);
            this.surfaceAreaLabel.TabIndex = 9;
            this.surfaceAreaLabel.Text = "Surface Area";
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(25, 195);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 10;
            this.diameterLabel.Text = "Diameter";
            // 
            // diameterOutput
            // 
            this.diameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutput.Location = new System.Drawing.Point(115, 195);
            this.diameterOutput.Name = "diameterOutput";
            this.diameterOutput.Size = new System.Drawing.Size(100, 23);
            this.diameterOutput.TabIndex = 11;
            // 
            // volumeOutput
            // 
            this.volumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutput.Location = new System.Drawing.Point(115, 291);
            this.volumeOutput.Name = "volumeOutput";
            this.volumeOutput.Size = new System.Drawing.Size(100, 23);
            this.volumeOutput.TabIndex = 12;
            // 
            // surfaceAreaOutput
            // 
            this.surfaceAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceAreaOutput.Location = new System.Drawing.Point(115, 245);
            this.surfaceAreaOutput.Name = "surfaceAreaOutput";
            this.surfaceAreaOutput.Size = new System.Drawing.Size(100, 23);
            this.surfaceAreaOutput.TabIndex = 13;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.surfaceAreaOutput);
            this.Controls.Add(this.volumeOutput);
            this.Controls.Add(this.diameterOutput);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.surfaceAreaLabel);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.radiusOfSphere);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.radiusOfSphereTextbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lab3";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox radiusOfSphereTextbox;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label radiusOfSphere;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label diameterOutput;
        private System.Windows.Forms.Label volumeOutput;
        private System.Windows.Forms.Label surfaceAreaOutput;
    }
}

