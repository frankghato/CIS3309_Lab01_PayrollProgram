
namespace HealthClub
{
    partial class healthclubForm
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
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblMembershipLength = new System.Windows.Forms.Label();
            this.lblMembershipFees = new System.Windows.Forms.Label();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.lblEnterMonths = new System.Windows.Forms.Label();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.groupMembershipTypes = new System.Windows.Forms.GroupBox();
            this.lblMonthlyFeeText = new System.Windows.Forms.Label();
            this.lblTotalFeeText = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.groupMembershipTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Location = new System.Drawing.Point(148, 47);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(137, 17);
            this.lblMembershipType.TabIndex = 0;
            this.lblMembershipType.Text = "Type of Membership";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(470, 47);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(57, 17);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Options";
            // 
            // lblMembershipLength
            // 
            this.lblMembershipLength.AutoSize = true;
            this.lblMembershipLength.Location = new System.Drawing.Point(135, 251);
            this.lblMembershipLength.Name = "lblMembershipLength";
            this.lblMembershipLength.Size = new System.Drawing.Size(133, 17);
            this.lblMembershipLength.TabIndex = 2;
            this.lblMembershipLength.Text = "Membership Length";
            // 
            // lblMembershipFees
            // 
            this.lblMembershipFees.AutoSize = true;
            this.lblMembershipFees.Location = new System.Drawing.Point(451, 251);
            this.lblMembershipFees.Name = "lblMembershipFees";
            this.lblMembershipFees.Size = new System.Drawing.Size(120, 17);
            this.lblMembershipFees.TabIndex = 3;
            this.lblMembershipFees.Text = "Membership Fees";
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(427, 83);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(63, 21);
            this.chkYoga.TabIndex = 5;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(427, 124);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(72, 21);
            this.chkKarate.TabIndex = 6;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(427, 167);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(76, 21);
            this.chkTrainer.TabIndex = 7;
            this.chkTrainer.Text = "Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            // 
            // lblEnterMonths
            // 
            this.lblEnterMonths.AutoSize = true;
            this.lblEnterMonths.Location = new System.Drawing.Point(113, 286);
            this.lblEnterMonths.Name = "lblEnterMonths";
            this.lblEnterMonths.Size = new System.Drawing.Size(186, 17);
            this.lblEnterMonths.TabIndex = 8;
            this.lblEnterMonths.Text = "Enter the Number of Months";
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(23, 18);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(123, 21);
            this.radAdult.TabIndex = 9;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(23, 45);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(161, 21);
            this.radChild.TabIndex = 10;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 and Under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(23, 72);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(78, 21);
            this.radStudent.TabIndex = 11;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(23, 100);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(116, 21);
            this.radSenior.TabIndex = 12;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // groupMembershipTypes
            // 
            this.groupMembershipTypes.Controls.Add(this.radAdult);
            this.groupMembershipTypes.Controls.Add(this.radChild);
            this.groupMembershipTypes.Controls.Add(this.radStudent);
            this.groupMembershipTypes.Controls.Add(this.radSenior);
            this.groupMembershipTypes.Location = new System.Drawing.Point(99, 67);
            this.groupMembershipTypes.Name = "groupMembershipTypes";
            this.groupMembershipTypes.Size = new System.Drawing.Size(200, 128);
            this.groupMembershipTypes.TabIndex = 13;
            this.groupMembershipTypes.TabStop = false;
            // 
            // lblMonthlyFeeText
            // 
            this.lblMonthlyFeeText.AutoSize = true;
            this.lblMonthlyFeeText.Location = new System.Drawing.Point(424, 286);
            this.lblMonthlyFeeText.Name = "lblMonthlyFeeText";
            this.lblMonthlyFeeText.Size = new System.Drawing.Size(89, 17);
            this.lblMonthlyFeeText.TabIndex = 14;
            this.lblMonthlyFeeText.Text = "Monthly Fee:";
            // 
            // lblTotalFeeText
            // 
            this.lblTotalFeeText.AutoSize = true;
            this.lblTotalFeeText.Location = new System.Drawing.Point(424, 324);
            this.lblTotalFeeText.Name = "lblTotalFeeText";
            this.lblTotalFeeText.Size = new System.Drawing.Size(44, 17);
            this.lblTotalFeeText.TabIndex = 15;
            this.lblTotalFeeText.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 394);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 34);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(346, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(579, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 19;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(527, 328);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(0, 17);
            this.lblTotalFee.TabIndex = 20;
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(527, 286);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(0, 17);
            this.lblMonthlyFee.TabIndex = 21;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(138, 325);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(123, 22);
            this.txtMonths.TabIndex = 22;
            // 
            // healthclubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.lblMonthlyFee);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalFeeText);
            this.Controls.Add(this.lblMonthlyFeeText);
            this.Controls.Add(this.lblEnterMonths);
            this.Controls.Add(this.chkTrainer);
            this.Controls.Add(this.chkKarate);
            this.Controls.Add(this.chkYoga);
            this.Controls.Add(this.lblMembershipFees);
            this.Controls.Add(this.lblMembershipLength);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.groupMembershipTypes);
            this.Name = "healthclubForm";
            this.Text = "S";
            this.Load += new System.EventHandler(this.healthclubForm_Load);
            this.groupMembershipTypes.ResumeLayout(false);
            this.groupMembershipTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblMembershipLength;
        private System.Windows.Forms.Label lblMembershipFees;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.Label lblEnterMonths;
        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.GroupBox groupMembershipTypes;
        private System.Windows.Forms.Label lblMonthlyFeeText;
        private System.Windows.Forms.Label lblTotalFeeText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonthlyFee;
        private System.Windows.Forms.TextBox txtMonths;
    }
}

