namespace ProyectoBDDistribuidas
{
    partial class Login
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.buttonsalir1 = new System.Windows.Forms.Button();
            this.labeltipouser = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Bodeguero",
            "Cajero",
            "Secretaria"});
            this.comboBox1.Location = new System.Drawing.Point(442, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // buttoningresar
            // 
            this.buttoningresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttoningresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoningresar.Location = new System.Drawing.Point(268, 330);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(97, 38);
            this.buttoningresar.TabIndex = 1;
            this.buttoningresar.Text = "Ingresar";
            this.buttoningresar.UseVisualStyleBackColor = false;
            this.buttoningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsalir1
            // 
            this.buttonsalir1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonsalir1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir1.Location = new System.Drawing.Point(488, 330);
            this.buttonsalir1.Name = "buttonsalir1";
            this.buttonsalir1.Size = new System.Drawing.Size(97, 38);
            this.buttonsalir1.TabIndex = 2;
            this.buttonsalir1.Text = "Salir";
            this.buttonsalir1.UseVisualStyleBackColor = false;
            // 
            // labeltipouser
            // 
            this.labeltipouser.AutoSize = true;
            this.labeltipouser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipouser.Location = new System.Drawing.Point(475, 33);
            this.labeltipouser.Name = "labeltipouser";
            this.labeltipouser.Size = new System.Drawing.Size(130, 21);
            this.labeltipouser.TabIndex = 3;
            this.labeltipouser.Text = "Tipo de Usuario";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(309, 152);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(68, 21);
            this.labeluser.TabIndex = 4;
            this.labeluser.Text = "Usuario";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(309, 200);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(97, 21);
            this.labelpassword.TabIndex = 5;
            this.labelpassword.Text = "Contraseña";
            // 
            // textBoxuser
            // 
            this.textBoxuser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxuser.Location = new System.Drawing.Point(454, 152);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(151, 28);
            this.textBoxuser.TabIndex = 6;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(454, 203);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(151, 28);
            this.textBoxpassword.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labeltipouser);
            this.Controls.Add(this.buttonsalir1);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.Button buttonsalir1;
        private System.Windows.Forms.Label labeltipouser;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxpassword;
    }
}