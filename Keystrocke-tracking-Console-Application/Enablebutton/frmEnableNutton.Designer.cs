﻿namespace Enablebutton
{
    partial class frmEnableButton
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
            this.cmdEnable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEnable
            // 
            this.cmdEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnable.Location = new System.Drawing.Point(12, 12);
            this.cmdEnable.Name = "cmdEnable";
            this.cmdEnable.Size = new System.Drawing.Size(471, 426);
            this.cmdEnable.TabIndex = 0;
            this.cmdEnable.Text = "Enable";
            this.cmdEnable.UseVisualStyleBackColor = true;
            this.cmdEnable.Click += new System.EventHandler(this.cmdEnable_Click);
            // 
            // frmEnableButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.cmdEnable);
            this.Name = "frmEnableButton";
            this.Text = "Enable-Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdEnable;
    }
}

