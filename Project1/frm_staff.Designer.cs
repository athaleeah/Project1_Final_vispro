namespace Project1
{
    partial class frm_staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_staff));
            this.BTNViewEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNViewEdit
            // 
            this.BTNViewEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNViewEdit.Location = new System.Drawing.Point(338, 174);
            this.BTNViewEdit.Name = "BTNViewEdit";
            this.BTNViewEdit.Size = new System.Drawing.Size(117, 83);
            this.BTNViewEdit.TabIndex = 0;
            this.BTNViewEdit.Text = "View and Edit Data";
            this.BTNViewEdit.UseVisualStyleBackColor = true;
            this.BTNViewEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNViewEdit);
            this.DoubleBuffered = true;
            this.Name = "frm_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_staff";
            this.Load += new System.EventHandler(this.frm_staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNViewEdit;
    }
}