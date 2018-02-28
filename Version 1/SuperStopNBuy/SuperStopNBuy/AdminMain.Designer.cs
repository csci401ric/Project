/********************************
 * AdminMain.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class AdminMain
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
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.datagridviewMain = new System.Windows.Forms.DataGridView();
            this.datagridviewtbcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewtbcLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(178, 38);
            this.labelMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(365, 72);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Manage Management";
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(11, 159);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(141, 25);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View Manager\'s Details";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(11, 211);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(141, 25);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit Manager\'s Information";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(11, 263);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 25);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete Manager";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(11, 310);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 25);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add New Manager";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(10, 11);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(65, 28);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // datagridviewMain
            // 
            this.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagridviewtbcFirstName,
            this.datagridviewtbcLastName,
            this.datagridviewtbcUsername,
            this.datagridviewtbcEmployeeId,
            this.datagridviewtbcLogin});
            this.datagridviewMain.Location = new System.Drawing.Point(179, 130);
            this.datagridviewMain.Name = "datagridviewMain";
            this.datagridviewMain.Size = new System.Drawing.Size(543, 258);
            this.datagridviewMain.TabIndex = 8;
            // 
            // datagridviewtbcFirstName
            // 
            this.datagridviewtbcFirstName.HeaderText = "First Name";
            this.datagridviewtbcFirstName.Name = "datagridviewtbcFirstName";
            // 
            // datagridviewtbcLastName
            // 
            this.datagridviewtbcLastName.HeaderText = "Last Name";
            this.datagridviewtbcLastName.Name = "datagridviewtbcLastName";
            // 
            // datagridviewtbcUsername
            // 
            this.datagridviewtbcUsername.HeaderText = "Username";
            this.datagridviewtbcUsername.Name = "datagridviewtbcUsername";
            // 
            // datagridviewtbcEmployeeId
            // 
            this.datagridviewtbcEmployeeId.HeaderText = "Employee ID";
            this.datagridviewtbcEmployeeId.Name = "datagridviewtbcEmployeeId";
            // 
            // datagridviewtbcLogin
            // 
            this.datagridviewtbcLogin.HeaderText = "Login Status";
            this.datagridviewtbcLogin.Name = "datagridviewtbcLogin";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.datagridviewMain);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.labelMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DataGridView datagridviewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagridviewtbcLogin;
    }
}

