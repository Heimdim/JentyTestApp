namespace JentyTestApp
{
    partial class FieldSizeForm
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
            this.setWidthLabel = new System.Windows.Forms.Label();
            this.setHeightLabel = new System.Windows.Forms.Label();
            this.setWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setSizeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setWidthLabel
            // 
            this.setWidthLabel.AutoSize = true;
            this.setWidthLabel.Location = new System.Drawing.Point(64, 36);
            this.setWidthLabel.Name = "setWidthLabel";
            this.setWidthLabel.Size = new System.Drawing.Size(49, 20);
            this.setWidthLabel.TabIndex = 0;
            this.setWidthLabel.Text = "Width";
            // 
            // setHeightLabel
            // 
            this.setHeightLabel.AutoSize = true;
            this.setHeightLabel.Location = new System.Drawing.Point(64, 112);
            this.setHeightLabel.Name = "setHeightLabel";
            this.setHeightLabel.Size = new System.Drawing.Size(54, 20);
            this.setHeightLabel.TabIndex = 1;
            this.setHeightLabel.Text = "Height";
            // 
            // setWidthNumericUpDown
            // 
            this.setWidthNumericUpDown.Location = new System.Drawing.Point(25, 73);
            this.setWidthNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setWidthNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.setWidthNumericUpDown.Name = "setWidthNumericUpDown";
            this.setWidthNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.setWidthNumericUpDown.TabIndex = 4;
            this.setWidthNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // setHeightNumericUpDown
            // 
            this.setHeightNumericUpDown.Location = new System.Drawing.Point(25, 144);
            this.setHeightNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setHeightNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.setHeightNumericUpDown.Name = "setHeightNumericUpDown";
            this.setHeightNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.setHeightNumericUpDown.TabIndex = 5;
            this.setHeightNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // setSizeButton
            // 
            this.setSizeButton.Location = new System.Drawing.Point(47, 186);
            this.setSizeButton.Name = "setSizeButton";
            this.setSizeButton.Size = new System.Drawing.Size(94, 29);
            this.setSizeButton.TabIndex = 6;
            this.setSizeButton.Text = "Set Size";
            this.setSizeButton.UseVisualStyleBackColor = true;
            this.setSizeButton.Click += new System.EventHandler(this.setSizeButton_Click);
            // 
            // FieldSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 227);
            this.Controls.Add(this.setSizeButton);
            this.Controls.Add(this.setHeightNumericUpDown);
            this.Controls.Add(this.setWidthNumericUpDown);
            this.Controls.Add(this.setHeightLabel);
            this.Controls.Add(this.setWidthLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FieldSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FieldSizeForm";
            ((System.ComponentModel.ISupportInitialize)(this.setWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label setWidthLabel;
        private Label setHeightLabel;
        private NumericUpDown setWidthNumericUpDown;
        private NumericUpDown setHeightNumericUpDown;
        private Button setSizeButton;
    }
}