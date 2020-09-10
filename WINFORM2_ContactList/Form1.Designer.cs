namespace WINFORM2_ContactList
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
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBFirstname = new System.Windows.Forms.TextBox();
            this.TBLastname = new System.Windows.Forms.TextBox();
            this.LBcontactList = new System.Windows.Forms.ListBox();
            this.removeselectedcontact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(53, 241);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(205, 50);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Contact";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¨LastName";
            // 
            // TBFirstname
            // 
            this.TBFirstname.Location = new System.Drawing.Point(53, 107);
            this.TBFirstname.Name = "TBFirstname";
            this.TBFirstname.Size = new System.Drawing.Size(205, 20);
            this.TBFirstname.TabIndex = 3;
            // 
            // TBLastname
            // 
            this.TBLastname.Location = new System.Drawing.Point(53, 181);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.Size = new System.Drawing.Size(205, 20);
            this.TBLastname.TabIndex = 4;
            // 
            // LBcontactList
            // 
            this.LBcontactList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcontactList.FormattingEnabled = true;
            this.LBcontactList.ItemHeight = 18;
            this.LBcontactList.Location = new System.Drawing.Point(422, 82);
            this.LBcontactList.Name = "LBcontactList";
            this.LBcontactList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBcontactList.Size = new System.Drawing.Size(336, 310);
            this.LBcontactList.TabIndex = 5;
            this.LBcontactList.Visible = false;
            // 
            // removeselectedcontact
            // 
            this.removeselectedcontact.Location = new System.Drawing.Point(422, 398);
            this.removeselectedcontact.Name = "removeselectedcontact";
            this.removeselectedcontact.Size = new System.Drawing.Size(336, 40);
            this.removeselectedcontact.TabIndex = 6;
            this.removeselectedcontact.Text = "remove";
            this.removeselectedcontact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeselectedcontact);
            this.Controls.Add(this.LBcontactList);
            this.Controls.Add(this.TBLastname);
            this.Controls.Add(this.TBFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBFirstname;
        private System.Windows.Forms.TextBox TBLastname;
        private System.Windows.Forms.ListBox LBcontactList;
        private System.Windows.Forms.Button removeselectedcontact;
    }
}

