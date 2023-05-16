namespace CarsDatabase
{
    partial class frmCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.txtVehicleRegistration = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.txtDateRegister = new System.Windows.Forms.TextBox();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecordPrevious = new System.Windows.Forms.Button();
            this.btnRecordFirst = new System.Windows.Forms.Button();
            this.btnRecordNext = new System.Windows.Forms.Button();
            this.btnRecordLast = new System.Windows.Forms.Button();
            this.txtRecordNumber = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle registration number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Engine size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date registered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rental per day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(157, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bowman Car Hire";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(178, 216);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 7;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtVehicleRegistration
            // 
            this.txtVehicleRegistration.Location = new System.Drawing.Point(179, 75);
            this.txtVehicleRegistration.Name = "txtVehicleRegistration";
            this.txtVehicleRegistration.Size = new System.Drawing.Size(100, 23);
            this.txtVehicleRegistration.TabIndex = 8;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(178, 101);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            this.txtMake.TabIndex = 9;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(179, 130);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(100, 23);
            this.txtEngine.TabIndex = 10;
            // 
            // txtDateRegister
            // 
            this.txtDateRegister.Location = new System.Drawing.Point(178, 159);
            this.txtDateRegister.Name = "txtDateRegister";
            this.txtDateRegister.Size = new System.Drawing.Size(100, 23);
            this.txtDateRegister.TabIndex = 11;
            // 
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.Location = new System.Drawing.Point(179, 188);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(100, 23);
            this.txtRentalPerDay.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(436, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(436, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(436, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(436, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(436, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRecordPrevious
            // 
            this.btnRecordPrevious.Location = new System.Drawing.Point(98, 271);
            this.btnRecordPrevious.Name = "btnRecordPrevious";
            this.btnRecordPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnRecordPrevious.TabIndex = 19;
            this.btnRecordPrevious.Text = "Previous";
            this.btnRecordPrevious.UseVisualStyleBackColor = true;
            this.btnRecordPrevious.Click += new System.EventHandler(this.btnRecordPrevious_Click);
            // 
            // btnRecordFirst
            // 
            this.btnRecordFirst.Location = new System.Drawing.Point(17, 271);
            this.btnRecordFirst.Name = "btnRecordFirst";
            this.btnRecordFirst.Size = new System.Drawing.Size(75, 23);
            this.btnRecordFirst.TabIndex = 20;
            this.btnRecordFirst.Text = "First";
            this.btnRecordFirst.UseVisualStyleBackColor = true;
            this.btnRecordFirst.Click += new System.EventHandler(this.btnRecordFirst_Click);
            // 
            // btnRecordNext
            // 
            this.btnRecordNext.Location = new System.Drawing.Point(285, 271);
            this.btnRecordNext.Name = "btnRecordNext";
            this.btnRecordNext.Size = new System.Drawing.Size(75, 23);
            this.btnRecordNext.TabIndex = 21;
            this.btnRecordNext.Text = "Next";
            this.btnRecordNext.UseVisualStyleBackColor = true;
            this.btnRecordNext.Click += new System.EventHandler(this.btnRecordNext_Click);
            // 
            // btnRecordLast
            // 
            this.btnRecordLast.Location = new System.Drawing.Point(366, 271);
            this.btnRecordLast.Name = "btnRecordLast";
            this.btnRecordLast.Size = new System.Drawing.Size(75, 23);
            this.btnRecordLast.TabIndex = 22;
            this.btnRecordLast.Text = "Last";
            this.btnRecordLast.UseVisualStyleBackColor = true;
            this.btnRecordLast.Click += new System.EventHandler(this.btnRecordLast_Click);
            // 
            // txtRecordNumber
            // 
            this.txtRecordNumber.Location = new System.Drawing.Point(179, 271);
            this.txtRecordNumber.Name = "txtRecordNumber";
            this.txtRecordNumber.Size = new System.Drawing.Size(100, 23);
            this.txtRecordNumber.TabIndex = 23;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 306);
            this.Controls.Add(this.txtRecordNumber);
            this.Controls.Add(this.btnRecordLast);
            this.Controls.Add(this.btnRecordNext);
            this.Controls.Add(this.btnRecordFirst);
            this.Controls.Add(this.btnRecordPrevious);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.txtDateRegister);
            this.Controls.Add(this.txtEngine);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtVehicleRegistration);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "Task A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.TextBox txtVehicleRegistration;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.TextBox txtDateRegister;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRecordPrevious;
        private System.Windows.Forms.Button btnRecordFirst;
        private System.Windows.Forms.Button btnRecordNext;
        private System.Windows.Forms.Button btnRecordLast;
        private System.Windows.Forms.TextBox txtRecordNumber;
        private ToolTip toolTip1;
    }
}
