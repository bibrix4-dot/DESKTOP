namespace _4ºPIM_DESKTOP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1237, 90);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(831, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 31);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Buscar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(24, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 29);
            label1.Name = "label1";
            label1.Size = new Size(217, 41);
            label1.TabIndex = 0;
            label1.Text = "Suporte Certo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(53, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 513);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(53, 120);
            label2.Name = "label2";
            label2.Size = new Size(413, 38);
            label2.TabIndex = 3;
            label2.Text = "Adicionar ou Remover Técnico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(61, 158);
            label3.Name = "label3";
            label3.Size = new Size(400, 23);
            label3.TabIndex = 4;
            label3.Text = "Página destinada para técnicos da Suporte Técnico.\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InactiveCaption;
            label4.Location = new Point(46, 159);
            label4.Name = "label4";
            label4.Size = new Size(428, 54);
            label4.TabIndex = 4;
            label4.Text = "ADICIONAR TÉCNICO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(33, 251);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 5;
            label5.Text = "Nome e Sobrenome:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(33, 326);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 6;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(33, 406);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 7;
            label7.Text = "Senha:";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(207, 238);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 36);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(101, 393);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 36);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Location = new Point(101, 313);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 36);
            panel5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(161, 440);
            button1.Name = "button1";
            button1.Size = new Size(159, 50);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(186, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 107);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(617, 204);
            panel6.Name = "panel6";
            panel6.Size = new Size(506, 513);
            panel6.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(217, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 107);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(192, 440);
            button2.Name = "button2";
            button2.Size = new Size(159, 50);
            button2.TabIndex = 11;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Location = new Point(101, 313);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 36);
            panel7.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Location = new Point(101, 393);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 36);
            panel8.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Location = new Point(207, 238);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 36);
            panel9.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(34, 406);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 7;
            label8.Text = "Senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(33, 326);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 6;
            label9.Text = "E-mail:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(33, 251);
            label10.Name = "label10";
            label10.Size = new Size(168, 23);
            label10.TabIndex = 5;
            label10.Text = "Nome e Sobrenome:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.RosyBrown;
            label11.Location = new Point(65, 159);
            label11.Name = "label11";
            label11.Size = new Size(392, 54);
            label11.TabIndex = 4;
            label11.Text = "REMOVER TÉCNICO";
            label11.Click += label11_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1236, 744);
            Controls.Add(panel6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Button button2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}