namespace Desktop
{
    partial class Pergunta5
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
            this.bntResposta5 = new System.Windows.Forms.Button();
            this.lblPergunta5 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bntResposta5
            // 
            this.bntResposta5.Location = new System.Drawing.Point(114, 226);
            this.bntResposta5.Name = "bntResposta5";
            this.bntResposta5.Size = new System.Drawing.Size(75, 23);
            this.bntResposta5.TabIndex = 0;
            this.bntResposta5.Text = "Finalizar";
            this.bntResposta5.UseVisualStyleBackColor = true;
            this.bntResposta5.Click += new System.EventHandler(this.bntResposta5_Click);
            // 
            // lblPergunta5
            // 
            this.lblPergunta5.AutoSize = true;
            this.lblPergunta5.Location = new System.Drawing.Point(5, 20);
            this.lblPergunta5.Name = "lblPergunta5";
            this.lblPergunta5.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta5.TabIndex = 1;
            this.lblPergunta5.Text = "label1";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(34, 62);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(85, 17);
            this.rb1.TabIndex = 2;
            this.rb1.TabStop = true;
            this.rb1.Text = "radioButton1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(34, 100);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(85, 17);
            this.rb2.TabIndex = 3;
            this.rb2.TabStop = true;
            this.rb2.Text = "radioButton2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(34, 143);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(85, 17);
            this.rb3.TabIndex = 4;
            this.rb3.TabStop = true;
            this.rb3.Text = "radioButton3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(34, 179);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(85, 17);
            this.rb4.TabIndex = 5;
            this.rb4.TabStop = true;
            this.rb4.Text = "radioButton4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // Pergunta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblPergunta5);
            this.Controls.Add(this.bntResposta5);
            this.Name = "Pergunta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta5";
            this.Load += new System.EventHandler(this.Pergunta5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntResposta5;
        private System.Windows.Forms.Label lblPergunta5;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
    }
}