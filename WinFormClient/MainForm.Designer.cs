namespace WinFormClient
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Target = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.unregisterBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "API:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Target,
            this.Counter});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(29, 121);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(632, 302);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Target
            // 
            this.Target.Text = "Target";
            // 
            // Counter
            // 
            this.Counter.Text = "Counter";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(64, 65);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(145, 65);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(667, 190);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(87, 40);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // unregisterBtn
            // 
            this.unregisterBtn.Location = new System.Drawing.Point(667, 236);
            this.unregisterBtn.Name = "unregisterBtn";
            this.unregisterBtn.Size = new System.Drawing.Size(87, 38);
            this.unregisterBtn.TabIndex = 5;
            this.unregisterBtn.Text = "Unregister";
            this.unregisterBtn.UseVisualStyleBackColor = true;
            this.unregisterBtn.Click += new System.EventHandler(this.unregisterButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(64, 37);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(678, 22);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "https://localhost:7248/Randomizer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.unregisterBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label1);
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button unregisterBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Target;
        private System.Windows.Forms.ColumnHeader Counter;
    }
}