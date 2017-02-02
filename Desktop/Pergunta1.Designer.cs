namespace Desktop
{
    partial class Pergunta1
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
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.btnResposta1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Location = new System.Drawing.Point(5, 20);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta1.TabIndex = 0;
            this.lblPergunta1.Text = "label1";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(28, 58);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(56, 17);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "a) Avó";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(28, 92);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(63, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "b) Prima";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(28, 130);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(58, 17);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "c) Mãe";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(28, 167);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(71, 17);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "d) Vizinha";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // btnResposta1
            // 
            this.btnResposta1.Location = new System.Drawing.Point(108, 219);
            this.btnResposta1.Name = "btnResposta1";
            this.btnResposta1.Size = new System.Drawing.Size(208, 23);
            this.btnResposta1.TabIndex = 5;
            this.btnResposta1.Text = "Ir para pergunta 2";
            this.btnResposta1.UseVisualStyleBackColor = true;
            this.btnResposta1.Click += new System.EventHandler(this.btnResposta1_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.btnResposta1);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.lblPergunta1);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.Load += new System.EventHandler(this.FormPergunta1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnResposta1;
    }
}