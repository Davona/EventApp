
namespace EventApp
{
    partial class EventForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameValidLbl = new System.Windows.Forms.Label();
            this.lastNameValidLbl = new System.Windows.Forms.Label();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(106, 128);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 29);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(113, 27);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(127, 22);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            this.firstNameBox.MouseEnter += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(113, 76);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(127, 22);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            this.lastNameBox.MouseEnter += new System.EventHandler(this.LastName_TextChanged);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(24, 27);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(45, 17);
            this.firstNameLbl.TabIndex = 3;
            this.firstNameLbl.Text = "Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(12, 76);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.lastNameLbl.TabIndex = 4;
            this.lastNameLbl.Text = "Last Name";
            // 
            // firstNameValidLbl
            // 
            this.firstNameValidLbl.AutoSize = true;
            this.firstNameValidLbl.Location = new System.Drawing.Point(110, 52);
            this.firstNameValidLbl.Name = "firstNameValidLbl";
            this.firstNameValidLbl.Size = new System.Drawing.Size(0, 17);
            this.firstNameValidLbl.TabIndex = 5;
            // 
            // lastNameValidLbl
            // 
            this.lastNameValidLbl.AutoSize = true;
            this.lastNameValidLbl.Location = new System.Drawing.Point(110, 101);
            this.lastNameValidLbl.Name = "lastNameValidLbl";
            this.lastNameValidLbl.Size = new System.Drawing.Size(0, 17);
            this.lastNameValidLbl.TabIndex = 6;
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(241, 207);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 24;
            this.studentGridView.Size = new System.Drawing.Size(451, 210);
            this.studentGridView.TabIndex = 7;
            this.studentGridView.SelectionChanged += new System.EventHandler(this.StudentGridView_SelectionChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(106, 173);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(82, 28);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.StudentUpdate_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(106, 218);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(82, 30);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.lastNameValidLbl);
            this.Controls.Add(this.firstNameValidLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.saveBtn);
            this.Name = "EventForm";
            this.Text = "EventApp";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameValidLbl;
        private System.Windows.Forms.Label lastNameValidLbl;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

