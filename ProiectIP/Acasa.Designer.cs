
namespace ProiectIP
{
    partial class Acasa
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDespre = new System.Windows.Forms.Button();
            this.buttonAjutor = new System.Windows.Forms.Button();
            this.buttonContact = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.textBoxUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Maroon;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(445, 415);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 63);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Autentificare";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(271, 234);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(140, 25);
            this.user.TabIndex = 5;
            this.user.Text = "Nume utilizator";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(307, 310);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(68, 25);
            this.password.TabIndex = 6;
            this.password.Text = "Parola";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonDespre);
            this.groupBox1.Controls.Add(this.buttonAjutor);
            this.groupBox1.Controls.Add(this.buttonContact);
            this.groupBox1.Location = new System.Drawing.Point(-20, -10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(252, 567);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(23, 23);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(229, 50);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDespre
            // 
            this.buttonDespre.BackColor = System.Drawing.Color.Maroon;
            this.buttonDespre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDespre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDespre.Location = new System.Drawing.Point(20, 186);
            this.buttonDespre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDespre.Name = "buttonDespre";
            this.buttonDespre.Size = new System.Drawing.Size(229, 71);
            this.buttonDespre.TabIndex = 10;
            this.buttonDespre.Text = "Despre";
            this.buttonDespre.UseVisualStyleBackColor = false;
            this.buttonDespre.Click += new System.EventHandler(this.buttonDespre_Click);
            // 
            // buttonAjutor
            // 
            this.buttonAjutor.BackColor = System.Drawing.Color.Maroon;
            this.buttonAjutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjutor.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAjutor.Location = new System.Drawing.Point(20, 318);
            this.buttonAjutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAjutor.Name = "buttonAjutor";
            this.buttonAjutor.Size = new System.Drawing.Size(229, 71);
            this.buttonAjutor.TabIndex = 9;
            this.buttonAjutor.Text = "Ajutor";
            this.buttonAjutor.UseVisualStyleBackColor = false;
            this.buttonAjutor.Click += new System.EventHandler(this.buttonAjutor_Click);
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.Color.Maroon;
            this.buttonContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContact.Location = new System.Drawing.Point(20, 252);
            this.buttonContact.Margin = new System.Windows.Forms.Padding(0);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(229, 71);
            this.buttonContact.TabIndex = 9;
            this.buttonContact.Text = "Contact";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.Maroon;
            this.titlu.Location = new System.Drawing.Point(320, 69);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(344, 71);
            this.titlu.TabIndex = 8;
            this.titlu.Text = "HOTEL T19";
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Location = new System.Drawing.Point(445, 234);
            this.textBoxUtilizator.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(156, 22);
            this.textBoxUtilizator.TabIndex = 11;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(445, 308);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(156, 22);
            this.textBoxParola.TabIndex = 12;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // Acasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 550);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUtilizator);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Acasa";
            this.Text = "Hotel T19";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAjutor;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Button buttonDespre;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxUtilizator;
        private System.Windows.Forms.TextBox textBoxParola;
    }
}

