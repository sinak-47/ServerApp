namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Order_Event = new System.Windows.Forms.Button();
            this.Setup_Bluetooth = new System.Windows.Forms.Button();
            this.Direct_Stream = new System.Windows.Forms.Button();
            this.Create_Event = new System.Windows.Forms.Button();
            this.Email_SMS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Order_Event
            // 
            this.Order_Event.Location = new System.Drawing.Point(537, 135);
            this.Order_Event.Name = "Order_Event";
            this.Order_Event.Size = new System.Drawing.Size(111, 53);
            this.Order_Event.TabIndex = 1;
            this.Order_Event.Text = "سفارش اعلان";
            this.Order_Event.UseVisualStyleBackColor = true;
            this.Order_Event.Click += new System.EventHandler(this.Order_Event_Click);
            // 
            // Setup_Bluetooth
            // 
            this.Setup_Bluetooth.Location = new System.Drawing.Point(537, 253);
            this.Setup_Bluetooth.Name = "Setup_Bluetooth";
            this.Setup_Bluetooth.Size = new System.Drawing.Size(111, 50);
            this.Setup_Bluetooth.TabIndex = 2;
            this.Setup_Bluetooth.Text = "پخش بلوتوث";
            this.Setup_Bluetooth.UseVisualStyleBackColor = true;
            this.Setup_Bluetooth.Click += new System.EventHandler(this.Setup_Bluetooth_Click);
            // 
            // Direct_Stream
            // 
            this.Direct_Stream.Location = new System.Drawing.Point(537, 511);
            this.Direct_Stream.Name = "Direct_Stream";
            this.Direct_Stream.Size = new System.Drawing.Size(111, 53);
            this.Direct_Stream.TabIndex = 4;
            this.Direct_Stream.Text = "پخش مجزا";
            this.Direct_Stream.UseVisualStyleBackColor = true;
            this.Direct_Stream.Click += new System.EventHandler(this.Direct_Stream_Click);
            // 
            // Create_Event
            // 
            this.Create_Event.Location = new System.Drawing.Point(537, 43);
            this.Create_Event.Name = "Create_Event";
            this.Create_Event.Size = new System.Drawing.Size(111, 54);
            this.Create_Event.TabIndex = 5;
            this.Create_Event.Text = "ثبت اعلان";
            this.Create_Event.UseVisualStyleBackColor = true;
            this.Create_Event.Click += new System.EventHandler(this.Create_Event_Click);
            // 
            // Email_SMS
            // 
            this.Email_SMS.Location = new System.Drawing.Point(537, 393);
            this.Email_SMS.Name = "Email_SMS";
            this.Email_SMS.Size = new System.Drawing.Size(111, 47);
            this.Email_SMS.TabIndex = 6;
            this.Email_SMS.Text = "ایمیل و پیامک";
            this.Email_SMS.UseVisualStyleBackColor = true;
            this.Email_SMS.Click += new System.EventHandler(this.Email_SMS_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(814, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 249);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 706);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Email_SMS);
            this.Controls.Add(this.Create_Event);
            this.Controls.Add(this.Direct_Stream);
            this.Controls.Add(this.Setup_Bluetooth);
            this.Controls.Add(this.Order_Event);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Order_Event;
        private System.Windows.Forms.Button Setup_Bluetooth;
        private System.Windows.Forms.Button Direct_Stream;
        private System.Windows.Forms.Button Create_Event;
        private System.Windows.Forms.Button Email_SMS;
        private System.Windows.Forms.TextBox textBox1;
    }
}

