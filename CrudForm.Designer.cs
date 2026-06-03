namespace JobsCRUD
{
    partial class CrudForm
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
            this.btnObterTodes = new System.Windows.Forms.Button();
            this.btnCadastrarJob = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAtualizarCRUD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterTodes
            // 
            this.btnObterTodes.Location = new System.Drawing.Point(56, 54);
            this.btnObterTodes.Margin = new System.Windows.Forms.Padding(2);
            this.btnObterTodes.Name = "btnObterTodes";
            this.btnObterTodes.Size = new System.Drawing.Size(84, 35);
            this.btnObterTodes.TabIndex = 0;
            this.btnObterTodes.Text = "Obter Todes";
            this.btnObterTodes.UseVisualStyleBackColor = true;
            this.btnObterTodes.Click += new System.EventHandler(this.btnObterTodes_Click);
            // 
            // btnCadastrarJob
            // 
            this.btnCadastrarJob.Location = new System.Drawing.Point(184, 54);
            this.btnCadastrarJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarJob.Name = "btnCadastrarJob";
            this.btnCadastrarJob.Size = new System.Drawing.Size(84, 35);
            this.btnCadastrarJob.TabIndex = 1;
            this.btnCadastrarJob.Text = "Cadastrar";
            this.btnCadastrarJob.UseVisualStyleBackColor = true;
            this.btnCadastrarJob.Click += new System.EventHandler(this.btnCadastrarJob_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarCRUD
            // 
            this.btnAtualizarCRUD.Location = new System.Drawing.Point(309, 54);
            this.btnAtualizarCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizarCRUD.Name = "btnAtualizarCRUD";
            this.btnAtualizarCRUD.Size = new System.Drawing.Size(84, 35);
            this.btnAtualizarCRUD.TabIndex = 3;
            this.btnAtualizarCRUD.Text = "Atualizar";
            this.btnAtualizarCRUD.UseVisualStyleBackColor = true;
            this.btnAtualizarCRUD.Click += new System.EventHandler(this.btnAtualizarCRUD_Click);
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 134);
            this.Controls.Add(this.btnAtualizarCRUD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCadastrarJob);
            this.Controls.Add(this.btnObterTodes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrudForm";
            this.Text = "Jobs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObterTodes;
        private System.Windows.Forms.Button btnCadastrarJob;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAtualizarCRUD;
    }
}