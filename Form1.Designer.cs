namespace Stadium_Seating
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
            this.classALabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classCLabel = new System.Windows.Forms.Label();
            this.ticketSoldDescription = new System.Windows.Forms.Label();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.revenueCLabel = new System.Windows.Forms.Label();
            this.revenueBLabel = new System.Windows.Forms.Label();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.revenueALabel = new System.Windows.Forms.Label();
            this.classCLabel2 = new System.Windows.Forms.Label();
            this.classBLabel2 = new System.Windows.Forms.Label();
            this.classAlabel2 = new System.Windows.Forms.Label();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classALabel
            // 
            this.classALabel.AutoSize = true;
            this.classALabel.Location = new System.Drawing.Point(78, 133);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(92, 25);
            this.classALabel.TabIndex = 0;
            this.classALabel.Text = "Class A:";
            // 
            // classBLabel
            // 
            this.classBLabel.AutoSize = true;
            this.classBLabel.Location = new System.Drawing.Point(78, 190);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(92, 25);
            this.classBLabel.TabIndex = 1;
            this.classBLabel.Text = "Class B:";
            // 
            // classCLabel
            // 
            this.classCLabel.AutoSize = true;
            this.classCLabel.Location = new System.Drawing.Point(78, 248);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(93, 25);
            this.classCLabel.TabIndex = 2;
            this.classCLabel.Text = "Class C:";
            // 
            // ticketSoldDescription
            // 
            this.ticketSoldDescription.Location = new System.Drawing.Point(42, 44);
            this.ticketSoldDescription.Name = "ticketSoldDescription";
            this.ticketSoldDescription.Size = new System.Drawing.Size(340, 52);
            this.ticketSoldDescription.TabIndex = 3;
            this.ticketSoldDescription.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(207, 133);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(191, 31);
            this.classATextBox.TabIndex = 4;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(207, 192);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(191, 31);
            this.classBTextBox.TabIndex = 5;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(207, 248);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(191, 31);
            this.classCTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(264, 489);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(160, 70);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(596, 489);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 70);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(430, 489);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 70);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketSoldDescription);
            this.ticketsSoldGroupBox.Controls.Add(this.classCLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classALabel);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(42, 89);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(450, 354);
            this.ticketsSoldGroupBox.TabIndex = 10;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalLabel);
            this.revenueGroupBox.Controls.Add(this.revenueCLabel);
            this.revenueGroupBox.Controls.Add(this.revenueBLabel);
            this.revenueGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.revenueALabel);
            this.revenueGroupBox.Controls.Add(this.classCLabel2);
            this.revenueGroupBox.Controls.Add(this.classBLabel2);
            this.revenueGroupBox.Controls.Add(this.classAlabel2);
            this.revenueGroupBox.Location = new System.Drawing.Point(547, 89);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(450, 354);
            this.revenueGroupBox.TabIndex = 11;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(93, 243);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(66, 25);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // revenueCLabel
            // 
            this.revenueCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueCLabel.Location = new System.Drawing.Point(192, 192);
            this.revenueCLabel.Name = "revenueCLabel";
            this.revenueCLabel.Size = new System.Drawing.Size(190, 30);
            this.revenueCLabel.TabIndex = 7;
            // 
            // revenueBLabel
            // 
            this.revenueBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueBLabel.Location = new System.Drawing.Point(192, 135);
            this.revenueBLabel.Name = "revenueBLabel";
            this.revenueBLabel.Size = new System.Drawing.Size(190, 30);
            this.revenueBLabel.TabIndex = 6;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenueLabel.Location = new System.Drawing.Point(192, 243);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(190, 30);
            this.totalRevenueLabel.TabIndex = 5;
            // 
            // revenueALabel
            // 
            this.revenueALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenueALabel.Location = new System.Drawing.Point(192, 71);
            this.revenueALabel.Name = "revenueALabel";
            this.revenueALabel.Size = new System.Drawing.Size(190, 30);
            this.revenueALabel.TabIndex = 4;
            // 
            // classCLabel2
            // 
            this.classCLabel2.AutoSize = true;
            this.classCLabel2.Location = new System.Drawing.Point(67, 190);
            this.classCLabel2.Name = "classCLabel2";
            this.classCLabel2.Size = new System.Drawing.Size(93, 25);
            this.classCLabel2.TabIndex = 2;
            this.classCLabel2.Text = "Class C:";
            // 
            // classBLabel2
            // 
            this.classBLabel2.AutoSize = true;
            this.classBLabel2.Location = new System.Drawing.Point(67, 133);
            this.classBLabel2.Name = "classBLabel2";
            this.classBLabel2.Size = new System.Drawing.Size(92, 25);
            this.classBLabel2.TabIndex = 1;
            this.classBLabel2.Text = "Class B:";
            // 
            // classAlabel2
            // 
            this.classAlabel2.AutoSize = true;
            this.classAlabel2.Location = new System.Drawing.Point(67, 76);
            this.classAlabel2.Name = "classAlabel2";
            this.classAlabel2.Size = new System.Drawing.Size(92, 25);
            this.classAlabel2.TabIndex = 0;
            this.classAlabel2.Text = "Class A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 693);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = " Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label ticketSoldDescription;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label classCLabel2;
        private System.Windows.Forms.Label classBLabel2;
        private System.Windows.Forms.Label classAlabel2;
        private System.Windows.Forms.Label revenueALabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label revenueCLabel;
        private System.Windows.Forms.Label revenueBLabel;
        private System.Windows.Forms.Label totalRevenueLabel;
    }
}

