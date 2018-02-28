/********************************
 * ManagementItemEdit.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class ManagementItemEdit
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.textboxQuantity = new System.Windows.Forms.TextBox();
            this.textboxPrice = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 22);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(253, 309);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(256, 43);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "Save And Submit ";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // textboxNumber
            // 
            this.textboxNumber.Location = new System.Drawing.Point(225, 231);
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.Size = new System.Drawing.Size(175, 20);
            this.textboxNumber.TabIndex = 19;
            // 
            // textboxQuantity
            // 
            this.textboxQuantity.Location = new System.Drawing.Point(487, 181);
            this.textboxQuantity.Name = "textboxQuantity";
            this.textboxQuantity.Size = new System.Drawing.Size(176, 20);
            this.textboxQuantity.TabIndex = 18;
            // 
            // textboxPrice
            // 
            this.textboxPrice.Location = new System.Drawing.Point(488, 228);
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Size = new System.Drawing.Size(175, 20);
            this.textboxPrice.TabIndex = 17;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(225, 179);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(175, 20);
            this.textboxName.TabIndex = 16;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(69, 226);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(149, 24);
            this.labelNumber.TabIndex = 15;
            this.labelNumber.Text = "Product Number";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(403, 178);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(78, 24);
            this.labelQuantity.TabIndex = 14;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(428, 228);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(53, 24);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(87, 176);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 24);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Product Name";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(291, 43);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(171, 42);
            this.labelEdit.TabIndex = 11;
            this.labelEdit.Text = "Edit Item";
            // 
            // ManagementItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textboxNumber);
            this.Controls.Add(this.textboxQuantity);
            this.Controls.Add(this.textboxPrice);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEdit);
            this.Name = "ManagementItemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textboxNumber;
        private System.Windows.Forms.TextBox textboxQuantity;
        private System.Windows.Forms.TextBox textboxPrice;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEdit;
    }
}