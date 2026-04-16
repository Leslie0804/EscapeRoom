namespace EscapeRoom
{
    partial class FormIntroduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroduction));
            panel1 = new Panel();
            btnStartGame = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblInstructions = new Label();
            lblIntroduction = new Label();
            lblTittleInstructions = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStartGame);
            panel1.Location = new Point(41, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 291);
            panel1.TabIndex = 0;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(3, 246);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(258, 42);
            btnStartGame.TabIndex = 2;
            btnStartGame.Text = "INICIAR";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(323, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 175);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblInstructions);
            panel2.Location = new Point(44, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 236);
            panel2.TabIndex = 0;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(8, 7);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(242, 220);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblIntroduction
            // 
            lblIntroduction.AutoSize = true;
            lblIntroduction.Location = new Point(323, 225);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(445, 160);
            lblIntroduction.TabIndex = 1;
            lblIntroduction.Text = resources.GetString("lblIntroduction.Text");
            lblIntroduction.Click += lblIntroduction_Click;
            // 
            // lblTittleInstructions
            // 
            lblTittleInstructions.AutoSize = true;
            lblTittleInstructions.Location = new Point(44, 53);
            lblTittleInstructions.Name = "lblTittleInstructions";
            lblTittleInstructions.Size = new Size(122, 20);
            lblTittleInstructions.TabIndex = 2;
            lblTittleInstructions.Text = "INSTRUCCIONES:";
            // 
            // FormIntroduction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(lblTittleInstructions);
            Controls.Add(lblIntroduction);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "FormIntroduction";
            Text = "Escape Room - Introduction";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblIntroduction;
        private Button btnStartGame;
        private Label lblInstructions;
        private Label lblTittleInstructions;
    }
}