namespace Food_Waste_Tracker
{
    partial class logInForm
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userNameTbx = new System.Windows.Forms.TextBox();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.conTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(239, 114);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(58, 13);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Username:";
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(303, 114);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(100, 20);
            this.userNameTbx.TabIndex = 1;
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(303, 161);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(100, 20);
            this.passwordTbx.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(239, 161);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password:";
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(242, 237);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(375, 237);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(25, 28);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(82, 23);
            this.goBackBtn.TabIndex = 6;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // conTestBtn
            // 
            this.conTestBtn.Location = new System.Drawing.Point(549, 228);
            this.conTestBtn.Name = "conTestBtn";
            this.conTestBtn.Size = new System.Drawing.Size(152, 23);
            this.conTestBtn.TabIndex = 7;
            this.conTestBtn.Text = "ConnectionTest";
            this.conTestBtn.UseVisualStyleBackColor = true;
            this.conTestBtn.Click += new System.EventHandler(this.conTestBtn_Click);
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conTestBtn);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameTbx);
            this.Controls.Add(this.userNameLbl);
            this.Name = "logInForm";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button conTestBtn;
    }
}

