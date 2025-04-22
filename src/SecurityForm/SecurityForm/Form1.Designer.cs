
namespace SecurityForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.cbAuthenticationType = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows Identity";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(7, 24);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 24);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get windows identity";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(7, 55);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(371, 132);
            this.Info.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.cbAuthenticationType);
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generic Idenity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authentication Type:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(166, 27);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(212, 24);
            this.Username.TabIndex = 2;
            // 
            // cbAuthenticationType
            // 
            this.cbAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthenticationType.FormattingEnabled = true;
            this.cbAuthenticationType.Location = new System.Drawing.Point(10, 98);
            this.cbAuthenticationType.Name = "cbAuthenticationType";
            this.cbAuthenticationType.Size = new System.Drawing.Size(368, 26);
            this.cbAuthenticationType.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 150);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 26);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Security Form App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbAuthenticationType;
    }
}

