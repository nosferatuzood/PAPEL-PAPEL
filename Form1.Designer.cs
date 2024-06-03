namespace PAPEL_PAPEL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wintxt = new System.Windows.Forms.Label();
            this.Roundstxt = new System.Windows.Forms.Label();
            this.rockbtn = new System.Windows.Forms.Button();
            this.Paperbtn = new System.Windows.Forms.Button();
            this.Scissorsbtn = new System.Windows.Forms.Button();
            this.Choosetxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wintxt
            // 
            this.wintxt.AutoSize = true;
            this.wintxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wintxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wintxt.Location = new System.Drawing.Point(14, 68);
            this.wintxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wintxt.Name = "wintxt";
            this.wintxt.Size = new System.Drawing.Size(108, 26);
            this.wintxt.TabIndex = 0;
            this.wintxt.Text = "Wins : 0";
            // 
            // Roundstxt
            // 
            this.Roundstxt.AutoSize = true;
            this.Roundstxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roundstxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Roundstxt.Location = new System.Drawing.Point(13, 11);
            this.Roundstxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Roundstxt.Name = "Roundstxt";
            this.Roundstxt.Size = new System.Drawing.Size(163, 34);
            this.Roundstxt.TabIndex = 1;
            this.Roundstxt.Text = "Rounds: 0";
            // 
            // rockbtn
            // 
            this.rockbtn.BackgroundImage = global::PAPEL_PAPEL.Properties.Resources.stone_PNG13596_246765832;
            this.rockbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rockbtn.FlatAppearance.BorderSize = 0;
            this.rockbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rockbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rockbtn.Location = new System.Drawing.Point(14, 240);
            this.rockbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rockbtn.Name = "rockbtn";
            this.rockbtn.Size = new System.Drawing.Size(103, 106);
            this.rockbtn.TabIndex = 2;
            this.rockbtn.UseVisualStyleBackColor = false;
            this.rockbtn.Click += new System.EventHandler(this.rockbtn_Click);
            // 
            // Paperbtn
            // 
            this.Paperbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paperbtn.BackgroundImage")));
            this.Paperbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paperbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Paperbtn.FlatAppearance.BorderSize = 0;
            this.Paperbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Paperbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Paperbtn.Location = new System.Drawing.Point(136, 240);
            this.Paperbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Paperbtn.Name = "Paperbtn";
            this.Paperbtn.Size = new System.Drawing.Size(103, 106);
            this.Paperbtn.TabIndex = 3;
            this.Paperbtn.UseVisualStyleBackColor = false;
            this.Paperbtn.Click += new System.EventHandler(this.Paperbtn_Click);
            // 
            // Scissorsbtn
            // 
            this.Scissorsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Scissorsbtn.BackgroundImage")));
            this.Scissorsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scissorsbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scissorsbtn.FlatAppearance.BorderSize = 0;
            this.Scissorsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scissorsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scissorsbtn.Location = new System.Drawing.Point(261, 240);
            this.Scissorsbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scissorsbtn.Name = "Scissorsbtn";
            this.Scissorsbtn.Size = new System.Drawing.Size(103, 106);
            this.Scissorsbtn.TabIndex = 4;
            this.Scissorsbtn.UseVisualStyleBackColor = false;
            this.Scissorsbtn.Click += new System.EventHandler(this.Scissorsbtn_Click);
            // 
            // Choosetxt
            // 
            this.Choosetxt.AutoSize = true;
            this.Choosetxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choosetxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Choosetxt.Location = new System.Drawing.Point(106, 127);
            this.Choosetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choosetxt.Name = "Choosetxt";
            this.Choosetxt.Size = new System.Drawing.Size(132, 34);
            this.Choosetxt.TabIndex = 5;
            this.Choosetxt.Text = "Choose:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(379, 431);
            this.Controls.Add(this.Choosetxt);
            this.Controls.Add(this.Scissorsbtn);
            this.Controls.Add(this.Paperbtn);
            this.Controls.Add(this.rockbtn);
            this.Controls.Add(this.Roundstxt);
            this.Controls.Add(this.wintxt);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "um jogo ai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wintxt;
        private System.Windows.Forms.Label Roundstxt;
        private System.Windows.Forms.Button rockbtn;
        private System.Windows.Forms.Button Paperbtn;
        private System.Windows.Forms.Button Scissorsbtn;
        private System.Windows.Forms.Label Choosetxt;
    }
}

