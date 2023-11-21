namespace exercicio_11
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
            menuStrip1 = new MenuStrip();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            cordotextoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cordotextoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(100, 29);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // cordotextoToolStripMenuItem
            // 
            cordotextoToolStripMenuItem.Name = "cordotextoToolStripMenuItem";
            cordotextoToolStripMenuItem.Size = new Size(270, 34);
            cordotextoToolStripMenuItem.Text = "Cor e tipo de letra";
            cordotextoToolStripMenuItem.Click += cordotextoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 136);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "POO em C#";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(656, 398);
            button1.Name = "button1";
            button1.Size = new Size(144, 52);
            button1.TabIndex = 2;
            button1.Text = "Próx";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem cordotextoToolStripMenuItem;
        private Label label1;
        private Button button1;
    }
}