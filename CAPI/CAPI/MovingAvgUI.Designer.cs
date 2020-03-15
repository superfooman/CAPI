namespace CAPI
{
    partial class MovingAvgUI
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
            this.computeButton = new System.Windows.Forms.Button();
            this.movingAvgUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputArraypropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.movingAvgUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(12, 12);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(107, 38);
            this.computeButton.TabIndex = 1;
            this.computeButton.Text = "[ COMPUTE ]";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // movingAvgUIBindingSource
            // 
            this.movingAvgUIBindingSource.DataSource = typeof(CAPI.MovingAvgUI);
            // 
            // inputArraypropertyGrid
            // 
            this.inputArraypropertyGrid.Location = new System.Drawing.Point(12, 67);
            this.inputArraypropertyGrid.Name = "inputArraypropertyGrid";
            this.inputArraypropertyGrid.Size = new System.Drawing.Size(207, 346);
            this.inputArraypropertyGrid.TabIndex = 2;
            this.inputArraypropertyGrid.ToolbarVisible = false;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(226, 67);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(395, 346);
            this.outputTextBox.TabIndex = 3;
            // 
            // MovingAvgUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 425);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputArraypropertyGrid);
            this.Controls.Add(this.computeButton);
            this.Name = "MovingAvgUI";
            this.Text = "Moving Average UI";
            this.Load += new System.EventHandler(this.MovingAvgUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movingAvgUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.BindingSource movingAvgUIBindingSource;
        private System.Windows.Forms.PropertyGrid inputArraypropertyGrid;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

