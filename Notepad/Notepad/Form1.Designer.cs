namespace Notepad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Size = new System.Drawing.Size(560, 360);

            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "Открыть";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Location = new System.Drawing.Point(120, 385);
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "Сохранить";
            this.button2.Click += new System.EventHandler(this.button2_Click);

            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Text = "Блокнот";
            this.ResumeLayout(false);
        }

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}