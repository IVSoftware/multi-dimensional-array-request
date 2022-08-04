
namespace multi_dimensional_array_request
{
    partial class MainForm
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
            this.buttonChildTest1 = new System.Windows.Forms.Button();
            this.buttonChildTest2 = new System.Windows.Forms.Button();
            this.buttonChildTest3 = new System.Windows.Forms.Button();
            this.buttonChildTest4 = new System.Windows.Forms.Button();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.buttonClear3 = new System.Windows.Forms.Button();
            this.buttonClear4 = new System.Windows.Forms.Button();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChildTest1
            // 
            this.buttonChildTest1.Location = new System.Drawing.Point(29, 33);
            this.buttonChildTest1.Name = "buttonChildTest1";
            this.buttonChildTest1.Size = new System.Drawing.Size(112, 34);
            this.buttonChildTest1.TabIndex = 1;
            this.buttonChildTest1.Text = "ChildTest 1";
            this.buttonChildTest1.UseVisualStyleBackColor = true;
            this.buttonChildTest1.Click += new System.EventHandler(this.buttonChildTest1_Click);
            // 
            // buttonChildTest2
            // 
            this.buttonChildTest2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChildTest2.Location = new System.Drawing.Point(29, 73);
            this.buttonChildTest2.Name = "buttonChildTest2";
            this.buttonChildTest2.Size = new System.Drawing.Size(112, 34);
            this.buttonChildTest2.TabIndex = 1;
            this.buttonChildTest2.Text = "ChildTest 2";
            this.buttonChildTest2.UseVisualStyleBackColor = true;
            this.buttonChildTest2.Click += new System.EventHandler(this.buttonChildTest2_Click);
            // 
            // buttonChildTest3
            // 
            this.buttonChildTest3.Location = new System.Drawing.Point(29, 113);
            this.buttonChildTest3.Name = "buttonChildTest3";
            this.buttonChildTest3.Size = new System.Drawing.Size(112, 34);
            this.buttonChildTest3.TabIndex = 1;
            this.buttonChildTest3.Text = "ChildTest 3";
            this.buttonChildTest3.UseVisualStyleBackColor = true;
            this.buttonChildTest3.Click += new System.EventHandler(this.buttonChildTest3_Click);
            // 
            // buttonChildTest4
            // 
            this.buttonChildTest4.Location = new System.Drawing.Point(29, 153);
            this.buttonChildTest4.Name = "buttonChildTest4";
            this.buttonChildTest4.Size = new System.Drawing.Size(112, 34);
            this.buttonChildTest4.TabIndex = 1;
            this.buttonChildTest4.Text = "ChildTest 4";
            this.buttonChildTest4.UseVisualStyleBackColor = true;
            this.buttonChildTest4.Click += new System.EventHandler(this.buttonChildTest4_Click);
            // 
            // buttonClear1
            // 
            this.buttonClear1.Location = new System.Drawing.Point(169, 33);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(112, 34);
            this.buttonClear1.TabIndex = 1;
            this.buttonClear1.Text = "Clear";
            this.buttonClear1.UseVisualStyleBackColor = true;
            this.buttonClear1.Click += new System.EventHandler(this.buttonClear1_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear2.Location = new System.Drawing.Point(169, 73);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(112, 34);
            this.buttonClear2.TabIndex = 1;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // buttonClear3
            // 
            this.buttonClear3.Location = new System.Drawing.Point(169, 113);
            this.buttonClear3.Name = "buttonClear3";
            this.buttonClear3.Size = new System.Drawing.Size(112, 34);
            this.buttonClear3.TabIndex = 1;
            this.buttonClear3.Text = "Clear";
            this.buttonClear3.UseVisualStyleBackColor = true;
            this.buttonClear3.Click += new System.EventHandler(this.buttonClear3_Click);
            // 
            // buttonClear4
            // 
            this.buttonClear4.Location = new System.Drawing.Point(169, 153);
            this.buttonClear4.Name = "buttonClear4";
            this.buttonClear4.Size = new System.Drawing.Size(112, 34);
            this.buttonClear4.TabIndex = 1;
            this.buttonClear4.Text = "Clear";
            this.buttonClear4.UseVisualStyleBackColor = true;
            this.buttonClear4.Click += new System.EventHandler(this.buttonClear4_Click);
            // 
            // buttonTest1
            // 
            this.buttonTest1.Location = new System.Drawing.Point(287, 33);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(112, 34);
            this.buttonTest1.TabIndex = 1;
            this.buttonTest1.Text = "Test";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonClear4);
            this.Controls.Add(this.buttonChildTest4);
            this.Controls.Add(this.buttonClear3);
            this.Controls.Add(this.buttonChildTest3);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonChildTest2);
            this.Controls.Add(this.buttonTest1);
            this.Controls.Add(this.buttonClear1);
            this.Controls.Add(this.buttonChildTest1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChildTest1;
        private System.Windows.Forms.Button buttonChildTest2;
        private System.Windows.Forms.Button buttonChildTest3;
        private System.Windows.Forms.Button buttonChildTest4;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Button buttonClear3;
        private System.Windows.Forms.Button buttonClear4;
        private System.Windows.Forms.Button buttonTest1;
    }
}

