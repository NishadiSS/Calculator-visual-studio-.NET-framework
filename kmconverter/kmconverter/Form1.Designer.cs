namespace kmconverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtmile = new TextBox();
            txtweight = new TextBox();
            btndistance = new Button();
            btnweight = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 65);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the distance in miles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 131);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter the weight in pounds";
            // 
            // txtmile
            // 
            txtmile.Location = new Point(306, 62);
            txtmile.Name = "txtmile";
            txtmile.Size = new Size(374, 27);
            txtmile.TabIndex = 2;
            txtmile.TextChanged += txtmile_TextChanged;
            // 
            // txtweight
            // 
            txtweight.Location = new Point(306, 131);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(374, 27);
            txtweight.TabIndex = 3;
            // 
            // btndistance
            // 
            btndistance.Location = new Point(171, 259);
            btndistance.Name = "btndistance";
            btndistance.Size = new Size(94, 29);
            btndistance.TabIndex = 4;
            btndistance.Text = "Distance";
            btndistance.UseVisualStyleBackColor = true;
            btndistance.Click += btndistance_Click;
            // 
            // btnweight
            // 
            btnweight.Location = new Point(377, 259);
            btnweight.Name = "btnweight";
            btnweight.Size = new Size(94, 29);
            btnweight.TabIndex = 5;
            btnweight.Text = "Weight";
            btnweight.UseVisualStyleBackColor = true;
            btnweight.Click += btnweight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnweight);
            Controls.Add(btndistance);
            Controls.Add(txtweight);
            Controls.Add(txtmile);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmile;
        private TextBox txtweight;
        private Button btndistance;
        private Button btnweight;
    }
}