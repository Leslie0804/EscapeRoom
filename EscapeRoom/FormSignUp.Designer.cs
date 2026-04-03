namespace EscapeRoom
{
    partial class FormSignUp
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
            pnlHigher = new Panel();
            pnlLower = new Panel();
            lblTittle = new Label();
            lblSubtittle = new Label();
            lblAutor = new Label();
            lblEnterName = new Label();
            txtEnterName = new TextBox();
            btnStart = new Button();
            btnStatistics = new Button();
            pnlHigher.SuspendLayout();
            pnlLower.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHigher
            // 
            pnlHigher.Controls.Add(lblAutor);
            pnlHigher.Controls.Add(lblSubtittle);
            pnlHigher.Controls.Add(lblTittle);
            pnlHigher.Location = new Point(12, 12);
            pnlHigher.Name = "pnlHigher";
            pnlHigher.Size = new Size(458, 105);
            pnlHigher.TabIndex = 0;
            // 
            // pnlLower
            // 
            pnlLower.Controls.Add(btnStatistics);
            pnlLower.Controls.Add(btnStart);
            pnlLower.Controls.Add(txtEnterName);
            pnlLower.Controls.Add(lblEnterName);
            pnlLower.Location = new Point(12, 135);
            pnlLower.Name = "pnlLower";
            pnlLower.Size = new Size(458, 206);
            pnlLower.TabIndex = 1;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Location = new Point(199, 15);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(108, 20);
            lblTittle.TabIndex = 2;
            lblTittle.Text = "ESCAPE ROOM";
            // 
            // lblSubtittle
            // 
            lblSubtittle.AutoSize = true;
            lblSubtittle.Location = new Point(199, 40);
            lblSubtittle.Name = "lblSubtittle";
            lblSubtittle.Size = new Size(87, 20);
            lblSubtittle.TabIndex = 3;
            lblSubtittle.Text = "SIMULATOR";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(199, 66);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(166, 20);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Created by Leslie Romo";
            // 
            // lblEnterName
            // 
            lblEnterName.AutoSize = true;
            lblEnterName.Location = new Point(163, 33);
            lblEnterName.Name = "lblEnterName";
            lblEnterName.Size = new Size(133, 20);
            lblEnterName.TabIndex = 5;
            lblEnterName.Text = "Ingresa tu nombre:";
            // 
            // txtEnterName
            // 
            txtEnterName.BorderStyle = BorderStyle.None;
            txtEnterName.Location = new Point(163, 65);
            txtEnterName.Name = "txtEnterName";
            txtEnterName.Size = new Size(125, 20);
            txtEnterName.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(163, 91);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(125, 29);
            btnStart.TabIndex = 5;
            btnStart.Text = "INICIAR";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(163, 126);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(123, 29);
            btnStatistics.TabIndex = 7;
            btnStatistics.Text = "ESADÍSTICAS";
            btnStatistics.UseVisualStyleBackColor = true;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(pnlLower);
            Controls.Add(pnlHigher);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormSignUp";
            Text = "Escape Room - Sign/Up";
            pnlHigher.ResumeLayout(false);
            pnlHigher.PerformLayout();
            pnlLower.ResumeLayout(false);
            pnlLower.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHigher;
        private Panel pnlLower;
        private Label lblAutor;
        private Label lblSubtittle;
        private Label lblTittle;
        private Button btnStatistics;
        private Button btnStart;
        private TextBox txtEnterName;
        private Label lblEnterName;
    }
}
