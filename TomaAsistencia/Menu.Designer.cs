namespace TomaAsistencia
{
    partial class Menu
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
            this.btnListarU = new System.Windows.Forms.Button();
            this.btnListarA = new System.Windows.Forms.Button();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ";
            // 
            // btnListarU
            // 
            this.btnListarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.btnListarU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarU.Location = new System.Drawing.Point(343, 271);
            this.btnListarU.Name = "btnListarU";
            this.btnListarU.Size = new System.Drawing.Size(340, 43);
            this.btnListarU.TabIndex = 18;
            this.btnListarU.Text = "LISTAR USUARIOS";
            this.btnListarU.UseVisualStyleBackColor = false;
            this.btnListarU.Click += new System.EventHandler(this.btnListarU_Click);
            // 
            // btnListarA
            // 
            this.btnListarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.btnListarA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarA.Location = new System.Drawing.Point(343, 442);
            this.btnListarA.Name = "btnListarA";
            this.btnListarA.Size = new System.Drawing.Size(340, 43);
            this.btnListarA.TabIndex = 19;
            this.btnListarA.Text = "LISTAR ASISTENCIA";
            this.btnListarA.UseVisualStyleBackColor = false;
            this.btnListarA.Click += new System.EventHandler(this.btnListarA_Click);
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.btnAgregarA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarA.Location = new System.Drawing.Point(343, 354);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(340, 43);
            this.btnAgregarA.TabIndex = 20;
            this.btnAgregarA.Text = "AGREGAR ASISTENCIA";
            this.btnAgregarA.UseVisualStyleBackColor = false;
            this.btnAgregarA.Click += new System.EventHandler(this.btnAgregarA_Click);
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.btnAgregarU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarU.Location = new System.Drawing.Point(343, 194);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(340, 43);
            this.btnAgregarU.TabIndex = 21;
            this.btnAgregarU.Text = "AGREGAR USUARIO";
            this.btnAgregarU.UseVisualStyleBackColor = false;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1015, 615);
            this.Controls.Add(this.btnAgregarU);
            this.Controls.Add(this.btnAgregarA);
            this.Controls.Add(this.btnListarA);
            this.Controls.Add(this.btnListarU);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarU;
        private System.Windows.Forms.Button btnListarA;
        private System.Windows.Forms.Button btnAgregarA;
        private System.Windows.Forms.Button btnAgregarU;
    }
}