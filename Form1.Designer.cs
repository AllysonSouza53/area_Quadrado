namespace area_Quadrado
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
            QPicturesBox = new PictureBox();
            VLTextBox = new TextBox();
            Cbutton = new Button();
            FButton = new Button();
            LButton = new Button();
            VLabel = new Label();
            RLabel = new Label();
            RTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)QPicturesBox).BeginInit();
            SuspendLayout();
            // 
            // QPicturesBox
            // 
            QPicturesBox.BackgroundImage = Properties.Resources.Area_do_quadrado7;
            QPicturesBox.BackgroundImageLayout = ImageLayout.Stretch;
            QPicturesBox.Location = new Point(381, 12);
            QPicturesBox.Name = "QPicturesBox";
            QPicturesBox.Size = new Size(407, 321);
            QPicturesBox.TabIndex = 0;
            QPicturesBox.TabStop = false;
            // 
            // VLTextBox
            // 
            VLTextBox.Location = new Point(153, 68);
            VLTextBox.Name = "VLTextBox";
            VLTextBox.Size = new Size(129, 23);
            VLTextBox.TabIndex = 3;
            VLTextBox.TextChanged += VLTextBox_TextChanged;
            // 
            // Cbutton
            // 
            Cbutton.Location = new Point(153, 136);
            Cbutton.Name = "Cbutton";
            Cbutton.Size = new Size(129, 23);
            Cbutton.TabIndex = 5;
            Cbutton.Text = "<<Calcular>>";
            Cbutton.UseVisualStyleBackColor = true;
            Cbutton.Click += Cbutton_Click;
            // 
            // FButton
            // 
            FButton.Location = new Point(199, 310);
            FButton.Name = "FButton";
            FButton.Size = new Size(83, 23);
            FButton.TabIndex = 6;
            FButton.Text = "<<Fechar>>";
            FButton.UseVisualStyleBackColor = true;
            FButton.Click += FButton_Click;
            // 
            // LButton
            // 
            LButton.Location = new Point(61, 310);
            LButton.Name = "LButton";
            LButton.Size = new Size(86, 23);
            LButton.TabIndex = 7;
            LButton.Text = "<<Limpar>>";
            LButton.UseVisualStyleBackColor = true;
            LButton.Click += LButton_Click;
            // 
            // VLabel
            // 
            VLabel.AutoSize = true;
            VLabel.Location = new Point(36, 71);
            VLabel.Name = "VLabel";
            VLabel.Size = new Size(111, 15);
            VLabel.TabIndex = 8;
            VLabel.Text = "<<Valor do Lado>>";
            VLabel.Click += VLabel_Click;
            // 
            // RLabel
            // 
            RLabel.AutoSize = true;
            RLabel.Location = new Point(36, 210);
            RLabel.Name = "RLabel";
            RLabel.Size = new Size(91, 15);
            RLabel.TabIndex = 9;
            RLabel.Text = "<<Resultado>>";
            // 
            // RTextBox
            // 
            RTextBox.Location = new Point(153, 207);
            RTextBox.Name = "RTextBox";
            RTextBox.Size = new Size(129, 23);
            RTextBox.TabIndex = 10;
            RTextBox.TextChanged += RTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RTextBox);
            Controls.Add(RLabel);
            Controls.Add(VLabel);
            Controls.Add(LButton);
            Controls.Add(FButton);
            Controls.Add(Cbutton);
            Controls.Add(VLTextBox);
            Controls.Add(QPicturesBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)QPicturesBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QPicturesBox;
        private TextBox VLTextBox;
        private Button Cbutton;
        private Button FButton;
        private Button LButton;
        private Label VLabel;
        private Label RLabel;
        private TextBox RTextBox;
    }
}
