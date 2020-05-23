namespace Dua_Varun_Assignment5_MS806
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.MealView = new System.Windows.Forms.ListView();
            this.LocationView = new System.Windows.Forms.ListView();
            this.EventView = new System.Windows.Forms.ListView();
            this.DisplayBox = new System.Windows.Forms.GroupBox();
            this.MealLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.EventBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.DisplayBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.CompleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Controls.Add(this.MealView);
            this.panel1.Controls.Add(this.LocationView);
            this.panel1.Controls.Add(this.EventView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 254);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(333, 197);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(312, 40);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add To Booking";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(314, 163);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(140, 20);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Number of Spots:";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(475, 163);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(170, 22);
            this.AddTextBox.TabIndex = 3;
            this.AddTextBox.TextChanged += new System.EventHandler(this.AddTextBox_TextChanged);
            // 
            // MealView
            // 
            this.MealView.FullRowSelect = true;
            this.MealView.GridLines = true;
            this.MealView.HideSelection = false;
            this.MealView.Location = new System.Drawing.Point(475, 3);
            this.MealView.MultiSelect = false;
            this.MealView.Name = "MealView";
            this.MealView.Size = new System.Drawing.Size(170, 139);
            this.MealView.TabIndex = 2;
            this.MealView.UseCompatibleStateImageBehavior = false;
            this.MealView.View = System.Windows.Forms.View.Details;
            this.MealView.SelectedIndexChanged += new System.EventHandler(this.MealView_SelectedIndexChanged);
            // 
            // LocationView
            // 
            this.LocationView.FullRowSelect = true;
            this.LocationView.GridLines = true;
            this.LocationView.HideSelection = false;
            this.LocationView.Location = new System.Drawing.Point(318, 3);
            this.LocationView.MultiSelect = false;
            this.LocationView.Name = "LocationView";
            this.LocationView.Size = new System.Drawing.Size(151, 139);
            this.LocationView.TabIndex = 1;
            this.LocationView.UseCompatibleStateImageBehavior = false;
            this.LocationView.View = System.Windows.Forms.View.Details;
            this.LocationView.SelectedIndexChanged += new System.EventHandler(this.LocationView_SelectedIndexChanged);
            // 
            // EventView
            // 
            this.EventView.FullRowSelect = true;
            this.EventView.GridLines = true;
            this.EventView.HideSelection = false;
            this.EventView.Location = new System.Drawing.Point(0, 3);
            this.EventView.MultiSelect = false;
            this.EventView.Name = "EventView";
            this.EventView.Size = new System.Drawing.Size(312, 246);
            this.EventView.TabIndex = 0;
            this.EventView.UseCompatibleStateImageBehavior = false;
            this.EventView.View = System.Windows.Forms.View.Details;
            this.EventView.SelectedIndexChanged += new System.EventHandler(this.EventView_SelectedIndexChanged);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Controls.Add(this.MealLabel);
            this.DisplayBox.Controls.Add(this.LocationLabel);
            this.DisplayBox.Controls.Add(this.EventLabel);
            this.DisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.Location = new System.Drawing.Point(12, 272);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(435, 241);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.Text = "Events:";
            // 
            // MealLabel
            // 
            this.MealLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealLabel.Location = new System.Drawing.Point(18, 180);
            this.MealLabel.Name = "MealLabel";
            this.MealLabel.Size = new System.Drawing.Size(391, 58);
            this.MealLabel.TabIndex = 2;
            // 
            // LocationLabel
            // 
            this.LocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(18, 105);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(391, 62);
            this.LocationLabel.TabIndex = 1;
            // 
            // EventLabel
            // 
            this.EventLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventLabel.Location = new System.Drawing.Point(18, 34);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(391, 59);
            this.EventLabel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReportButton);
            this.groupBox1.Controls.Add(this.CostLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(453, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costs";
            // 
            // CompleteButton
            // 
            this.CompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteButton.Location = new System.Drawing.Point(672, 15);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(165, 40);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "Complete Order";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostLabel.Location = new System.Drawing.Point(17, 91);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(391, 59);
            this.CostLabel.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(672, 104);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(165, 38);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(672, 197);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 40);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(17, 180);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(391, 55);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Management Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // EventBox
            // 
            this.EventBox.FormattingEnabled = true;
            this.EventBox.ItemHeight = 16;
            this.EventBox.Location = new System.Drawing.Point(900, 23);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(235, 484);
            this.EventBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 525);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DisplayBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView EventView;
        private System.Windows.Forms.ListView LocationView;
        private System.Windows.Forms.ListView MealView;
        private System.Windows.Forms.GroupBox DisplayBox;
        private System.Windows.Forms.Label MealLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ListBox EventBox;
    }
}

