namespace military_shop
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(71, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(266, 267);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Terméknév";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cikkszám";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ár";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Készlet";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(362, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(246, 196);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(372, 40);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 2;
            button1.Text = "Megrendelés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(362, 339);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Kiíratás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}
