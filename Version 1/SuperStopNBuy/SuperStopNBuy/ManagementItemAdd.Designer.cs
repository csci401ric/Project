/********************************
 * ManagementItemAdd.Designer.cs
 * Created by The Dev Doods
********************************/

namespace SuperStopNBuy
{
    partial class ManagementItemAdd
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
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxPrice = new System.Windows.Forms.TextBox();
            this.textboxQuantity = new System.Windows.Forms.TextBox();
            this.textboxNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(291, 45);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(173, 42);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add Item";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(87, 178);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(131, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(428, 230);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(53, 24);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(403, 180);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(78, 24);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(69, 228);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(149, 24);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Product Number";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(225, 181);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(175, 20);
            this.textboxName.TabIndex = 5;
            // 
            // textboxPrice
            // 
            this.textboxPrice.Location = new System.Drawing.Point(488, 230);
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Size = new System.Drawing.Size(175, 20);
            this.textboxPrice.TabIndex = 6;
            // 
            // textboxQuantity
            // 
            this.textboxQuantity.Location = new System.Drawing.Point(487, 183);
            this.textboxQuantity.Name = "textboxQuantity";
            this.textboxQuantity.Size = new System.Drawing.Size(176, 20);
            this.textboxQuantity.TabIndex = 7;
            // 
            // textboxNumber
            // 
            this.textboxNumber.Location = new System.Drawing.Point(225, 233);
            this.textboxNumber.Name = "textboxNumber";
            this.textboxNumber.Size = new System.Drawing.Size(175, 20);
            this.textboxNumber.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(253, 311);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(256, 43);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Save And Submit ";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 24);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // ManagementItemAdd
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
            this.Controls.Add(this.labelAdd);
            this.Name = "ManagementItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Stop \'N Buy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxPrice;
        private System.Windows.Forms.TextBox textboxQuantity;
        private System.Windows.Forms.TextBox textboxNumber;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
    }
}