namespace Windows_Forms_App
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
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_option = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(244, 139);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(125, 27);
            this.tb_firstname.TabIndex = 2;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(638, 139);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(125, 27);
            this.tb_lastname.TabIndex = 4;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(28, 46);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(63, 24);
            this.rb_male.TabIndex = 6;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(176, 46);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(78, 24);
            this.rb_female.TabIndex = 7;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Location = new System.Drawing.Point(338, 46);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(67, 24);
            this.rb_other.TabIndex = 8;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "Other";
            this.rb_other.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(380, 314);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(199, 44);
            this.submit.TabIndex = 9;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_option
            // 
            this.gb_option.Controls.Add(this.rb_male);
            this.gb_option.Controls.Add(this.rb_female);
            this.gb_option.Controls.Add(this.rb_other);
            this.gb_option.Location = new System.Drawing.Point(244, 183);
            this.gb_option.Name = "gb_option";
            this.gb_option.Size = new System.Drawing.Size(488, 96);
            this.gb_option.TabIndex = 5;
            this.gb_option.TabStop = false;
            this.gb_option.Text = "Options";
            this.gb_option.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(307, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Registration Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_option);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_option.ResumeLayout(false);
            this.gb_option.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.Button submit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
