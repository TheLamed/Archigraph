
namespace Archigraph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbRoot = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRoot
            // 
            this.tbRoot.Location = new System.Drawing.Point(12, 55);
            this.tbRoot.Name = "tbRoot";
            this.tbRoot.ReadOnly = true;
            this.tbRoot.Size = new System.Drawing.Size(260, 23);
            this.tbRoot.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(260, 37);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose .zip";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 139);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Telegra.ph";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 179);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 15);
            this.lbInfo.TabIndex = 3;
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(12, 225);
            this.tbLink.Name = "tbLink";
            this.tbLink.ReadOnly = true;
            this.tbLink.Size = new System.Drawing.Size(260, 23);
            this.tbLink.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 110);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(260, 23);
            this.tbTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.tbRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Archigraph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRoot;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
    }
}

