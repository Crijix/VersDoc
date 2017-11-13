namespace CarpetingShopV2._0
{
    partial class myCarptingShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPSF = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnRoomCost = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtPSF = new System.Windows.Forms.TextBox();
            this.lblAreaCost = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(12, 38);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(183, 32);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Enter Width:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(12, 317);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(173, 32);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Room Cost:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(12, 268);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(158, 32);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area Cost:";
            // 
            // lblPSF
            // 
            this.lblPSF.AutoSize = true;
            this.lblPSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSF.Location = new System.Drawing.Point(12, 127);
            this.lblPSF.Name = "lblPSF";
            this.lblPSF.Size = new System.Drawing.Size(233, 32);
            this.lblPSF.TabIndex = 3;
            this.lblPSF.Text = "Enter Cost PSF:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(12, 83);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(199, 32);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Enter Length:";
            // 
            // btnRoomCost
            // 
            this.btnRoomCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCost.Location = new System.Drawing.Point(565, 102);
            this.btnRoomCost.Name = "btnRoomCost";
            this.btnRoomCost.Size = new System.Drawing.Size(90, 74);
            this.btnRoomCost.TabIndex = 6;
            this.btnRoomCost.Text = "Room Cost";
            this.btnRoomCost.UseVisualStyleBackColor = true;
            this.btnRoomCost.Click += new System.EventHandler(this.BtnRoomCost_Click);
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(565, 13);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(90, 74);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(565, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 74);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(259, 43);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 27);
            this.txtWidth.TabIndex = 9;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(259, 88);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 27);
            this.txtLength.TabIndex = 10;
            // 
            // txtPSF
            // 
            this.txtPSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSF.Location = new System.Drawing.Point(259, 132);
            this.txtPSF.Name = "txtPSF";
            this.txtPSF.Size = new System.Drawing.Size(100, 27);
            this.txtPSF.TabIndex = 11;
            // 
            // lblAreaCost
            // 
            this.lblAreaCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAreaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCost.Location = new System.Drawing.Point(253, 268);
            this.lblAreaCost.Name = "lblAreaCost";
            this.lblAreaCost.Size = new System.Drawing.Size(158, 32);
            this.lblAreaCost.TabIndex = 12;
            // 
            // lblRoom
            // 
            this.lblRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(253, 317);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(158, 32);
            this.lblRoom.TabIndex = 13;
            // 
            // myCarptingShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(708, 518);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblAreaCost);
            this.Controls.Add(this.txtPSF);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnRoomCost);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblPSF);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblWidth);
            this.Name = "myCarptingShop";
            this.Text = "Carpeting Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPSF;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnRoomCost;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtPSF;
        private System.Windows.Forms.Label lblAreaCost;
        private System.Windows.Forms.Label lblRoom;
    }
}

