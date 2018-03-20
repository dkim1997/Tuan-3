namespace tuan_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selecttxt = new System.Windows.Forms.TextBox();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.buabtn = new System.Windows.Forms.Button();
            this.keobtn = new System.Windows.Forms.Button();
            this.baobtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.svselecttxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn Chọn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết Quả :";
            // 
            // selecttxt
            // 
            this.selecttxt.Location = new System.Drawing.Point(126, 31);
            this.selecttxt.Name = "selecttxt";
            this.selecttxt.Size = new System.Drawing.Size(228, 20);
            this.selecttxt.TabIndex = 2;
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(126, 276);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(228, 20);
            this.resulttxt.TabIndex = 3;
            // 
            // buabtn
            // 
            this.buabtn.Location = new System.Drawing.Point(55, 124);
            this.buabtn.Name = "buabtn";
            this.buabtn.Size = new System.Drawing.Size(75, 69);
            this.buabtn.TabIndex = 4;
            this.buabtn.Text = "Búa";
            this.buabtn.UseVisualStyleBackColor = true;
            this.buabtn.Click += new System.EventHandler(this.buabtn_Click);
            // 
            // keobtn
            // 
            this.keobtn.Location = new System.Drawing.Point(165, 124);
            this.keobtn.Name = "keobtn";
            this.keobtn.Size = new System.Drawing.Size(75, 69);
            this.keobtn.TabIndex = 5;
            this.keobtn.Text = "Kéo";
            this.keobtn.UseVisualStyleBackColor = true;
            this.keobtn.Click += new System.EventHandler(this.keobtn_Click);
            // 
            // baobtn
            // 
            this.baobtn.Location = new System.Drawing.Point(279, 124);
            this.baobtn.Name = "baobtn";
            this.baobtn.Size = new System.Drawing.Size(75, 69);
            this.baobtn.TabIndex = 6;
            this.baobtn.Text = "Bao";
            this.baobtn.UseVisualStyleBackColor = true;
            this.baobtn.Click += new System.EventHandler(this.baobtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Chọn :";
            // 
            // svselecttxt
            // 
            this.svselecttxt.Location = new System.Drawing.Point(126, 76);
            this.svselecttxt.Name = "svselecttxt";
            this.svselecttxt.Size = new System.Drawing.Size(228, 20);
            this.svselecttxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 345);
            this.Controls.Add(this.svselecttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baobtn);
            this.Controls.Add(this.keobtn);
            this.Controls.Add(this.buabtn);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.selecttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selecttxt;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Button buabtn;
        private System.Windows.Forms.Button keobtn;
        private System.Windows.Forms.Button baobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox svselecttxt;
    }
}

